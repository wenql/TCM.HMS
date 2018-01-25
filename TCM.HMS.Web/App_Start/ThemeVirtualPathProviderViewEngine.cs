using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace TCM.HMS.Web
{
    /// <summary>
    /// 主题路径提供者视图引擎
    /// </summary>
    public abstract class ThemeVirtualPathProviderViewEngine : VirtualPathProviderViewEngine
    {
        /// <summary>
        /// 前台视图位置格式
        /// </summary>
        private readonly string[] _webviewlocationformats = new string[2] { "~/views/{1}/{0}.cshtml", "~/views/shared/{0}.cshtml" };

        /// <summary>
        /// 后台视图位置格式
        /// </summary>
        private readonly string[] _adminviewlocationformats = new string[2] { "~/App_Module/Admin/views/{1}/{0}.cshtml", "~/App_Module/Admin/views/shared/{0}.cshtml" };

        /// <summary>
        /// 微信视图位置格式
        /// </summary>
        private readonly string[] _weixinviewlocationformats = new string[2] { "~/App_Module/Weixin/views/{1}/{0}.cshtml", "~/App_Weixin/views/shared/{0}.cshtml" };

        protected ThemeVirtualPathProviderViewEngine()
        {
            //将视图文件扩展名限制为cshtml
            FileExtensions = new[] { "cshtml" };
        }

        #region 重写方法

        /// <summary>
        /// 使用指定的控制器上下文和母版视图名称来查找指定的视图
        /// </summary>
        /// <param name="controllerContext">控制器上下文</param>
        /// <param name="viewName">视图的名称</param>
        /// <param name="masterName">母版视图的名称</param>
        /// <param name="useCache">若为 true，则使用缓存的视图</param>
        /// <returns>页视图</returns>
        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName,
            string masterName, bool useCache)
        {
            //构建一个视图引擎结果
            var result = FindThemeView(controllerContext, viewName, masterName, useCache);
            return result;

        }

        /// <summary>
        /// 寻找分部视图的方法
        /// </summary>
        /// <param name="controllerContext">控制器上下文</param>
        /// <param name="partialViewName">分部视图的名称</param>
        /// <param name="useCache">若为 true，则使用缓存的分部视图</param>
        /// <returns>分部视图</returns>
        public override ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName,
            bool useCache)
        {
            //构建一个分部视图引擎结果
            var result = FindThemePartialView(controllerContext, partialViewName, useCache);
            return result;
        }

        #endregion

        #region 工具方法

        /// <summary>
        /// 获取文件的路径
        /// </summary>
        private string GetPath(ControllerContext controllerContext, string name, string controllerName,
            string cacheKeyPrefix, bool useCache, out string[] searchedLocations)
        {
            searchedLocations = null;

            //视图位置列表
            string[] locations = null;
            //主题
            var theme = string.Empty;

            //获取区域
            var area = GetRouteDataTokenValue("area", controllerContext.RouteData.DataTokens).ToLower();
            if (area.Length == 0)
            {
                theme = GetRouteDataTokenValue("theme", controllerContext.RouteData.DataTokens);
                //locations = theme.Length == 0 ? _webviewlocationformats : _webviewlocationformats;
                locations = _webviewlocationformats;
            }
            else if (area == "admin") //后台视图位置的处理
                locations = _adminviewlocationformats;
            else if (area == "weixin")
                locations = _weixinviewlocationformats;

            //是否为特殊路径的标识
            var flag2 = IsSpecificName(name);

            //从缓存中获取视图位置
            var cacheKey = CreateCacheKey(cacheKeyPrefix, name, flag2 ? string.Empty : controllerName, area, theme);
            //视图位置的缓存键
            if (!useCache)
                return !flag2
                    ? GetPathFromGeneralName(controllerContext, locations, name, controllerName, theme, cacheKey,
                        ref searchedLocations)
                    : GetPathFromSpecificName(controllerContext, name, cacheKey, ref searchedLocations);
            //从缓存中得到视图位置
            var cachedPath = ViewLocationCache.GetViewLocation(controllerContext.HttpContext, cacheKey);
            if (cachedPath != null)
                return cachedPath;

            //如果视图位置不在缓存中，则构建视图位置并存储到缓存中
            return !flag2
                ? GetPathFromGeneralName(controllerContext, locations, name, controllerName, theme, cacheKey,
                    ref searchedLocations)
                : GetPathFromSpecificName(controllerContext, name, cacheKey, ref searchedLocations);
        }

        /// <summary>
        /// 特殊名称时构建视图路径
        /// </summary>
        private string GetPathFromSpecificName(ControllerContext controllerContext, string name, string cacheKey,
            ref string[] searchedLocations)
        {
            //将路径添加到视图位置缓存
            ViewLocationCache.InsertViewLocation(controllerContext.HttpContext, cacheKey, name);
            //扩展名不为“.cshtml”或者文件不存在时
            if (IsSupportedExtension(name) && FileExists(controllerContext, name)) return name;
            searchedLocations = new string[] { name };
            return string.Empty;
        }

        /// <summary>
        /// 普通名称时构建视图路径
        /// </summary>
        private string GetPathFromGeneralName(ControllerContext controllerContext, string[] viewLocationFormats,
            string name, string controllerName, string theme, string cacheKey, ref string[] searchedLocations)
        {
            int count = viewLocationFormats.Length;
            searchedLocations = new string[count];

            //循环视图位置
            for (var i = 0; i < count; i++)
            {
                var path = string.Format(viewLocationFormats[i], name, controllerName, theme);
                if (FileExists(controllerContext, path))
                {
                    searchedLocations = null;
                    ViewLocationCache.InsertViewLocation(controllerContext.HttpContext, cacheKey, path);
                    return path;
                }
                //将路径添加到搜索位置列表中
                searchedLocations[i] = path;
            }

            return string.Empty;
        }

        /// <summary>
        /// 创建视图位置的缓存键
        /// </summary>
        private string CreateCacheKey(string prefix, string name, string controllerName, string area, string theme)
        {
            return string.Format(":ViewCacheKey:{0}:{1}:{2}:{3}:{4}:{5}",
                new object[] { base.GetType().AssemblyQualifiedName, prefix, name, controllerName, area, theme });
        }

        /// <summary>
        /// 构建视图引擎结果
        /// </summary>
        private ViewEngineResult FindThemeView(ControllerContext controllerContext, string viewName, string masterName,
            bool useCache)
        {
            //视图文件路径搜索列表
            string[] strArray1 = null;
            //布局文件路径搜索列表
            string[] strArray2 = null;

            //获取控制器名称
            var controllerName = controllerContext.RouteData.GetRequiredString("controller");

            //获取视图文件路径
            var viewPath = GetPath(controllerContext, viewName, controllerName, "View", useCache, out strArray1);

            //当视图文件存在时
            if (!string.IsNullOrWhiteSpace(viewPath))
            {
                if (string.IsNullOrWhiteSpace(masterName))
                {
                    return new ViewEngineResult(CreateView(controllerContext, viewPath, string.Empty), this);
                }
                else
                {
                    //获取布局文件的路径
                    var masterPath = GetPath(controllerContext, masterName, controllerName, "Master", useCache,
                        out strArray2);
                    if (!string.IsNullOrWhiteSpace(masterPath))
                    {
                        return new ViewEngineResult(CreateView(controllerContext, viewPath, masterPath), this);
                    }
                }
            }

            //当视图文件或布局文件不存在时将搜索路径返回
            return strArray2 == null ? new ViewEngineResult(strArray1) : new ViewEngineResult(strArray1.Union<string>(strArray2));
        }

        /// <summary>
        /// 构建分部视图引擎结果
        /// </summary>
        private ViewEngineResult FindThemePartialView(ControllerContext controllerContext, string partialViewName,
            bool useCache)
        {
            //分部视图文件路径搜索列表
            string[] strArray;

            //获取控制器名称
            var controllerName = controllerContext.RouteData.GetRequiredString("controller");

            //获取分部视图文件路径
            var partialViewPath = GetPath(controllerContext, partialViewName, controllerName, "Partial", useCache,
                out strArray);

            return !string.IsNullOrWhiteSpace(partialViewPath)//当分部视图文件存在时
                ? new ViewEngineResult(CreatePartialView(controllerContext, partialViewPath), this)
                : new ViewEngineResult(strArray); //分部视图文件不存在时返回搜索路径       
        }

        /// <summary>
        /// 判读视图名称是否以“~”或“/”开头
        /// </summary>
        private bool IsSpecificName(string name)
        {
            char ch = name[0];
            return ch == '~' || ch == '/';
        }

        /// <summary>
        /// 判读文件扩展名是否为“.cshtml”
        /// </summary>
        private bool IsSupportedExtension(string path)
        {
            return path.EndsWith(".cshtml", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 获取路由集合中指定键的值
        /// </summary>
        private string GetRouteDataTokenValue(string key, RouteValueDictionary dict)
        {
            object value = dict[key];
            return value == null ? string.Empty : value.ToString();
        }

        #endregion
    }
}

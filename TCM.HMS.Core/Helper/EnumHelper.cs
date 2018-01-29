using System;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;

namespace TCM.HMS.Core.Helper
{
    /// <summary>
    /// 枚举帮助类
    /// <author>
    ///   <name>wenql</name>  
    ///   <date>2017-04-18</date>
    /// </author>
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// 获取枚举Attribute
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetDescription(Enum obj)
        {
            var objName = obj.ToString();
            var t = obj.GetType();
            var fi = t.GetField(objName);
            if (fi == null)
            {
                return "";
            }
            var arrDesc = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return arrDesc[0].Description;
        }
        private static DescriptionAttribute[] GetDescriptAttr(this FieldInfo fieldInfo)
        {
            if (fieldInfo != null)
            {
                return (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            }
            return null;
        }
        /// <summary>
        /// 根据描述获取枚举
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="description"></param>
        /// <returns></returns>
        public static T GetEnumName<T>(string description)
        {
            var type = typeof(T);
            foreach (var field in type.GetFields())
            {
                var curDesc = field.GetDescriptAttr();
                if (curDesc != null && curDesc.Length > 0)
                {
                    if (curDesc[0].Description == description) return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description) return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException(string.Format("{0} 未能找到对应的枚举.", description), "description");
        }

        public static List<SelectListItem> GetEnumList<T>()
        {
            var selectList = new List<SelectListItem>();
            var arrays = Enum.GetValues(typeof(T));
            for (var i = 0; i < arrays.LongLength; i++)
            {
                var test = (T)arrays.GetValue(i);
                selectList.Add(new SelectListItem()
                {
                    Text =
                        ((DescriptionAttribute)test.GetType().GetField(test.ToString()).GetCustomAttributes(false)[0])
                            .Description,
                    Value = (Convert.ToInt32(test)).ToString()
                });
            }
            return selectList.ToList();
        }
    }
}

using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TCM.HMS.EntityFramework.Repositories
{
    public abstract class HMSRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<HMSDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected HMSRepositoryBase(IDbContextProvider<HMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class HMSRepositoryBase<TEntity> : HMSRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected HMSRepositoryBase(IDbContextProvider<HMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}

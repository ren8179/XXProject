using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace QrF.XXProject.EntityFramework.Repositories
{
    public abstract class XXProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<XXProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected XXProjectRepositoryBase(IDbContextProvider<XXProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class XXProjectRepositoryBase<TEntity> : XXProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected XXProjectRepositoryBase(IDbContextProvider<XXProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}

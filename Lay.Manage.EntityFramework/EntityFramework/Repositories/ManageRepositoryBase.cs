using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Lay.Manage.EntityFramework.Repositories
{
    public abstract class ManageRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ManageDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ManageRepositoryBase(IDbContextProvider<ManageDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ManageRepositoryBase<TEntity> : ManageRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ManageRepositoryBase(IDbContextProvider<ManageDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}

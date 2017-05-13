using System.Data.Common;
using Abp.Zero.EntityFramework;
using Lay.Manage.Authorization.Roles;
using Lay.Manage.MultiTenancy;
using Lay.Manage.Users;
using System.Data.Entity;
using Lay.Manage.Products;

namespace Lay.Manage.EntityFramework
{
    public class ManageDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ManageDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ManageDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ManageDbContext since ABP automatically handles it.
         */
        public ManageDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            

    }

        //This constructor is used in tests
        public ManageDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ManageDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
        
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Cashback> Cashbacks { get; set; }
        public IDbSet<Remark> Remarks { get; set; }
        public IDbSet<Category> Categories { get; set; }


    }
}

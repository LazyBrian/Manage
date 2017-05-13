using Lay.Manage.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Lay.Manage.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ManageDbContext _context;

        public InitialHostDbBuilder(ManageDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

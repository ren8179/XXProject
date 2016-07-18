using QrF.XXProject.EntityFramework;
using EntityFramework.DynamicFilters;

namespace QrF.XXProject.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly XXProjectDbContext _context;

        public InitialHostDbBuilder(XXProjectDbContext context)
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

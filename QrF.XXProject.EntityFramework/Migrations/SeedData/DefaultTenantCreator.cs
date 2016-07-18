using System.Linq;
using QrF.XXProject.EntityFramework;
using QrF.XXProject.MultiTenancy;

namespace QrF.XXProject.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly XXProjectDbContext _context;

        public DefaultTenantCreator(XXProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}

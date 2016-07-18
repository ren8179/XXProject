using Abp.Authorization;
using QrF.XXProject.Authorization.Roles;
using QrF.XXProject.MultiTenancy;
using QrF.XXProject.Users;

namespace QrF.XXProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

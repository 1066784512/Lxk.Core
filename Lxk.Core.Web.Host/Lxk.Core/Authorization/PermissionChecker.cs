using Abp.Authorization;
using Lxk.Core.Authorization.Roles;
using Lxk.Core.Authorization.Users;

namespace Lxk.Core.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

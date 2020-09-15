using Abp.Authorization.Users;
using Abp.Extensions;
using System;
using System.Collections.Generic;

namespace Lxk.Core.Authorization.Users
{
    public class User: AbpUser<User>
    {
        public const string DefaultPassWord = "123qwe";

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }
    }
}

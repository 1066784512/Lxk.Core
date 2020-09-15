using Abp.MultiTenancy;
using Lxk.Core.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lxk.Core.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }

    }
}

using System.Collections.Generic;
using Core.Entities;

namespace Core.Settings
{
    public class TenantSettings
    {
        public Configuration Defaults { get; set; }
        public List<Tenant> Tenants { get; set; }
    }
}
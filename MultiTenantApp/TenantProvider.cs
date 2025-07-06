namespace MultiTenantApp
{
    public class TenantProvider
    {
        private readonly Dictionary<string, string> _tenants = new();

        public string GetTenant(string host)
        {
            if (_tenants.TryGetValue(host, out var tenant))
            {
                return tenant;
            }
            return "default";
        }

        public void RegisterTenant(string host, string tenantName)
        {
            _tenants[host] = tenantName;
        }
    }
}

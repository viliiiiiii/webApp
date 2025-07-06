using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MultiTenantApp
{
    public class TenantMiddleware
    {
        private readonly RequestDelegate _next;

        public TenantMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, TenantProvider provider)
        {
            var host = context.Request.Host.Host;
            var tenant = provider.GetTenant(host);
            context.Items["Tenant"] = tenant;
            await _next(context);
        }
    }
}

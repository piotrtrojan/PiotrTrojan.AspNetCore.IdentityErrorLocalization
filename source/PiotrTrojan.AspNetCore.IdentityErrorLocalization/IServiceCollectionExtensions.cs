using Microsoft.AspNetCore.Http;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization;
using System.Linq;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddMultilangIdentityErrorDescriberFactory(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IdentityErrorDescriberFactory>(sp =>
            {
                var httpContext = sp.GetRequiredService<IHttpContextAccessor>().HttpContext;
                var culture = httpContext.Request
                    .GetTypedHeaders()
                    .AcceptLanguage
                    .OrderByDescending(q => q.Quality)
                    .FirstOrDefault()?.Value.Value ?? string.Empty;
                return new IdentityErrorDescriberFactory(culture);
            });
            return serviceCollection;
        }
    }
}

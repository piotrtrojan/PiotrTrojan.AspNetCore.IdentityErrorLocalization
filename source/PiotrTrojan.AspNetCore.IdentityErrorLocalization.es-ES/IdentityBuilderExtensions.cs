using Microsoft.AspNetCore.Identity;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.es_ES;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddSpanishIdentityErrorDescriber(this IdentityBuilder identityBuilder) 
            => identityBuilder.AddErrorDescriber<SpanishIdentityErrorDescriber>();
    }
}

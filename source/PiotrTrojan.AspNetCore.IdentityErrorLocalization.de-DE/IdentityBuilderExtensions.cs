using Microsoft.AspNetCore.Identity;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.de_DE;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddGermanIdentityErrorDescriber(this IdentityBuilder identityBuilder)
            => identityBuilder.AddErrorDescriber<GermanIdentityErrorDescriber>();
    }
}
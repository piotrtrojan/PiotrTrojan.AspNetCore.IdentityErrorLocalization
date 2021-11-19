using Microsoft.AspNetCore.Identity;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.fr_FR;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddFrenchIdentityErrorDescriber(this IdentityBuilder identityBuilder)
            => identityBuilder.AddErrorDescriber<FrenchIdentityErrorDescriber>();
    }
}
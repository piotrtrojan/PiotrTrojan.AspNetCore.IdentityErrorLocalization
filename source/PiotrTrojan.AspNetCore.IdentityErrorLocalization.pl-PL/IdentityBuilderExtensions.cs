using Microsoft.AspNetCore.Identity;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.pl_PL;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddPolishIdentityErrorDescriber(this IdentityBuilder identityBuilder)
            => identityBuilder.AddErrorDescriber<PolishIdentityErrorDescriber>();
    }
}
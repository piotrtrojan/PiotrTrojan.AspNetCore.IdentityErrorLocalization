using Microsoft.AspNetCore.Identity;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.pt_PT;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddPortugueseIdentityErrorDescriber(this IdentityBuilder identityBuilder)
            => identityBuilder.AddErrorDescriber<PortugueseIdentityErrorDescriber>();
    }
}
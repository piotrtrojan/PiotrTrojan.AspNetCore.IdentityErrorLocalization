using Microsoft.AspNetCore.Identity;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.pt_br_PT_BR;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddPortugueseBrIdentityErrorDescriber(this IdentityBuilder identityBuilder)
        => identityBuilder.AddErrorDescriber<PortugueseBrIdentityErrorDescriber>();
    }
}

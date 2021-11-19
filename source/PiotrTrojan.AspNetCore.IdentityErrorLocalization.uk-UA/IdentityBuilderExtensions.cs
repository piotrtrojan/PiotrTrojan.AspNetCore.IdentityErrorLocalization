using Microsoft.AspNetCore.Identity;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.uk_UA;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddUkrainianIdentityErrorDescriber(this IdentityBuilder identityBuilder)
            => identityBuilder.AddErrorDescriber<UkrainianIdentityErrorDescriber>();
    }
}
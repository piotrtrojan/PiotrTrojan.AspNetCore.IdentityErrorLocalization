using Microsoft.AspNetCore.Identity;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.ru_RU;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddRussianIdentityErrorDescriber(this IdentityBuilder identityBuilder) 
            => identityBuilder.AddErrorDescriber<RussianIdentityErrorDescriber>();
    }
}

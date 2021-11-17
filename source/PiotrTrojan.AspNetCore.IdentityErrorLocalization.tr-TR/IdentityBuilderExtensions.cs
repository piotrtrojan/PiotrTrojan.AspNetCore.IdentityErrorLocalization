using Microsoft.AspNetCore.Identity;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.tr_TR;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddTurkishIdentityErrorDescriber(this IdentityBuilder identityBuilder) 
            => identityBuilder.AddErrorDescriber<TurkishIdentityErrorDescriber>();
    }
}

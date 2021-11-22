using Microsoft.AspNetCore.Identity;
using System;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization
{
    public class MultilangIdentityErrorDescriber : IdentityErrorDescriber
    {
        private readonly IdentityErrorDescriber describer;

        public MultilangIdentityErrorDescriber(IdentityErrorDescriberFactory factory = null)
        {
            describer = factory?.GetDescriber() ?? throw new Exception(
                    "IdentityErrorDescriberFactory not registered." +
                    "Call AddMultilangIdentityErrorDescriberFactory() on IServiceCollection during services registration.");
        }

        public override IdentityError ConcurrencyFailure() => describer.ConcurrencyFailure();

        public override IdentityError DefaultError() => describer.DefaultError();

        public override IdentityError DuplicateEmail(string email) => describer.DuplicateEmail(email);

        public override IdentityError DuplicateRoleName(string role) => describer.DuplicateRoleName(role);

        public override IdentityError DuplicateUserName(string userName) => describer.DuplicateUserName(userName);

        public override IdentityError InvalidEmail(string email) => describer.InvalidEmail(email);

        public override IdentityError InvalidRoleName(string role) => describer.InvalidRoleName(role);

        public override IdentityError InvalidToken() => describer.InvalidToken();

        public override IdentityError InvalidUserName(string userName) => describer.InvalidUserName(userName);

        public override IdentityError LoginAlreadyAssociated() => describer.LoginAlreadyAssociated();

        public override IdentityError PasswordMismatch() => describer.PasswordMismatch();

        public override IdentityError PasswordRequiresDigit() => describer.PasswordRequiresDigit();

        public override IdentityError PasswordRequiresLower() => describer.PasswordRequiresLower();

        public override IdentityError PasswordRequiresNonAlphanumeric() => describer.PasswordRequiresNonAlphanumeric();

        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars) => describer.PasswordRequiresUniqueChars(uniqueChars: uniqueChars);

        public override IdentityError PasswordRequiresUpper() => describer.PasswordRequiresUpper();

        public override IdentityError PasswordTooShort(int length) => describer.PasswordTooShort(length);

        public override IdentityError RecoveryCodeRedemptionFailed() => describer.RecoveryCodeRedemptionFailed();

        public override IdentityError UserAlreadyHasPassword() => describer.UserAlreadyHasPassword();

        public override IdentityError UserAlreadyInRole(string role) => describer.UserAlreadyInRole(role);

        public override IdentityError UserLockoutNotEnabled() => describer.UserLockoutNotEnabled();

        public override IdentityError UserNotInRole(string role) => describer.UserNotInRole(role);
    }
}
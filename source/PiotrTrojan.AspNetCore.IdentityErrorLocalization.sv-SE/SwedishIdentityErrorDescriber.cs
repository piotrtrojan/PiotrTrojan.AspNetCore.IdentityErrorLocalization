using Microsoft.AspNetCore.Identity;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization.sv_SE
{
    public class SwedishIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError ConcurrencyFailure() => new() { Code = nameof(ConcurrencyFailure), Description = "Objektet har ändrats sedan uppläsning." };
        public override IdentityError DefaultError() => new() { Code = nameof(DefaultError), Description = "Ett okänt fel har inträffat." };
        public override IdentityError DuplicateEmail(string email) => new() { Code = nameof(DuplicateEmail), Description = $"E-postadressen {email} finns redan." };
        public override IdentityError DuplicateRoleName(string role) => new() { Code = nameof(DuplicateRoleName), Description = $"Rollen '{role}' finns redan." };
        public override IdentityError DuplicateUserName(string userName) => new() { Code = nameof(DuplicateUserName), Description = $"Användarnamnet '{userName}' finns redan." };
        public override IdentityError InvalidEmail(string email) => new() { Code = nameof(InvalidEmail), Description = $"E-postadressen {email} är ogiltig." };
        public override IdentityError InvalidRoleName(string role) => new() { Code = nameof(InvalidRoleName), Description = $"Rollen '{role}' är ogiltig." };
        public override IdentityError InvalidToken() => new() { Code = nameof(InvalidToken), Description = "Ogiltigt token." };
        public override IdentityError InvalidUserName(string userName) => new() { Code = nameof(InvalidUserName), Description = $"Användarnamnet '{userName}' är ogiltigt, kan endast innehålla bokstäver eller siffror." };
        public override IdentityError LoginAlreadyAssociated() => new() { Code = nameof(LoginAlreadyAssociated), Description = "En användare med den här inloggningen finns redan." };
        public override IdentityError PasswordMismatch() => new() { Code = nameof(PasswordMismatch), Description = "Felaktigt lösenord." };
        public override IdentityError PasswordRequiresDigit() => new() { Code = nameof(PasswordRequiresDigit), Description = "Lösenordet måste innehålla minst en siffra ('0'-'9')." };
        public override IdentityError PasswordRequiresLower() => new() { Code = nameof(PasswordRequiresLower), Description = "Lösenordet måste innehålla minst en gemen ('a'-'z')." };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new() { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "Lösenordet måste ha minst ett icke alfanumeriskt tecken." };
        public override IdentityError PasswordRequiresUpper() => new() { Code = nameof(PasswordRequiresUpper), Description = "Lösenordet måste innehålla minst en versal ('A'-'Z')." };
        public override IdentityError PasswordTooShort(int length) => new() { Code = nameof(PasswordTooShort), Description = $"Lösenordet måste ha minst {length} tecken." };
        public override IdentityError UserAlreadyHasPassword() => new() { Code = nameof(UserAlreadyHasPassword), Description = "Användaren har redan angett ett lösenord." };
        public override IdentityError UserAlreadyInRole(string role) => new() { Code = nameof(UserAlreadyInRole), Description = $"Användaren har redan rollen '{role}'." };
        public override IdentityError UserLockoutNotEnabled() => new() { Code = nameof(UserLockoutNotEnabled), Description = "Lockout är inte aktiverat för den här användaren." };
        public override IdentityError UserNotInRole(string role) => new() { Code = nameof(UserNotInRole), Description = $"Användaren har inte rollen '{role}'." };
    }
}
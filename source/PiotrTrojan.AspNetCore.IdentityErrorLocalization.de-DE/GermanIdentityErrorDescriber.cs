using Microsoft.AspNetCore.Identity;
using System;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization.de_DE
{
    public class GermanIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = $"Ein unbekannter Fehler ist aufgetreten." }; }
        public override IdentityError ConcurrencyFailure() { return new IdentityError { Code = nameof(ConcurrencyFailure), Description = "Fehler bzgl. der Optimistischen Nebenläufigkeit, das Objekt wurde verändert." }; }
        public override IdentityError PasswordMismatch() { return new IdentityError { Code = nameof(PasswordMismatch), Description = "Ungültiges Passwort." }; }
        public override IdentityError InvalidToken() { return new IdentityError { Code = nameof(InvalidToken), Description = "Ungültiger Token." }; }
        public override IdentityError LoginAlreadyAssociated() { return new IdentityError { Code = nameof(LoginAlreadyAssociated), Description = "Es ist bereits ein Nutzer mit diesem Login vorhanden." }; }
        public override IdentityError InvalidUserName(string userName) { return new IdentityError { Code = nameof(InvalidUserName), Description = $"Nutzername '{userName}' ist ungültig. Erlaubt sind nur Buchstaben und Zahlen." }; }
        public override IdentityError InvalidEmail(string email) { return new IdentityError { Code = nameof(InvalidEmail), Description = $"E-Mail '{email}' ist ungültig." }; }
        public override IdentityError DuplicateUserName(string userName) { return new IdentityError { Code = nameof(DuplicateUserName), Description = $"Nutzername '{userName}' ist bereits vergeben." }; }
        public override IdentityError DuplicateEmail(string email) { return new IdentityError { Code = nameof(DuplicateEmail), Description = $"E-Mail '{email}' ist bereits vergeben." }; }
        public override IdentityError InvalidRoleName(string role) { return new IdentityError { Code = nameof(InvalidRoleName), Description = $"Rollen-Name '{role}' ist ungültig." }; }
        public override IdentityError DuplicateRoleName(string role) { return new IdentityError { Code = nameof(DuplicateRoleName), Description = $"Rollen-Name '{role}' ist bereits vergeben." }; }
        public override IdentityError UserAlreadyHasPassword() { return new IdentityError { Code = nameof(UserAlreadyHasPassword), Description = "Nutzer hat bereits ein Passwort gesetzt." }; }
        public override IdentityError UserLockoutNotEnabled() { return new IdentityError { Code = nameof(UserLockoutNotEnabled), Description = "Aussperrung ist für diesen Nutzer nicht aktiviert." }; }
        public override IdentityError UserAlreadyInRole(string role) { return new IdentityError { Code = nameof(UserAlreadyInRole), Description = $"Nutzer ist bereits in Rolle '{role}'." }; }
        public override IdentityError UserNotInRole(string role) { return new IdentityError { Code = nameof(UserNotInRole), Description = $"Nutzer ist nicht in Rolle '{role}'." }; }
        public override IdentityError PasswordTooShort(int length) { return new IdentityError { Code = nameof(PasswordTooShort), Description = $"Passwörter müssen mindestens {length} Zeichen lang sein." }; }
        public override IdentityError PasswordRequiresNonAlphanumeric() { return new IdentityError { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "Passwörter müssen mindestens ein Sonderzeichen enthalten." }; }
        public override IdentityError PasswordRequiresDigit() { return new IdentityError { Code = nameof(PasswordRequiresDigit), Description = "Passwörter müssen mindestens eine Ziffer enthalten ('0'-'9')." }; }
        public override IdentityError PasswordRequiresLower() { return new IdentityError { Code = nameof(PasswordRequiresLower), Description = "Passwörter müssen mindestens einen Kleinbuchstaben enthalten ('a'-'z')." }; }
        public override IdentityError PasswordRequiresUpper() { return new IdentityError { Code = nameof(PasswordRequiresUpper), Description = "Passwörter müssen mindestens einen Großbuchstaben enthalten ('A'-'Z')." }; }
    }
}

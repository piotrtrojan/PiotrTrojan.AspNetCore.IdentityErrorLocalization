using Microsoft.AspNetCore.Identity;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization.pl_PL
{
    public class PolishIdentityErrorDescriber : IdentityErrorDescriber
    {

        public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = $"Wystąpił nieanany błąd." }; }
        public override IdentityError ConcurrencyFailure() { return new IdentityError { Code = nameof(ConcurrencyFailure), Description = "Błąd współbieżności, obiekt został zmodyfikowany." }; }
        public override IdentityError PasswordMismatch() { return new IdentityError { Code = nameof(PasswordMismatch), Description = "Nieprawidłowe hasło." }; }
        public override IdentityError InvalidToken() { return new IdentityError { Code = nameof(InvalidToken), Description = "Nieprawidłowy token." }; }
        public override IdentityError LoginAlreadyAssociated() { return new IdentityError { Code = nameof(LoginAlreadyAssociated), Description = "Użytkownik o takiej nazwie już istnieje." }; }
        public override IdentityError InvalidUserName(string userName) { return new IdentityError { Code = nameof(InvalidUserName), Description = $"Nazwa użytkownika '{userName}' jest nieprawidłowa, może posiadać tylko znaki i cyfry." }; }
        public override IdentityError InvalidEmail(string email) { return new IdentityError { Code = nameof(InvalidEmail), Description = $"Email '{email}' jest nieprawidłowy." }; }
        public override IdentityError DuplicateUserName(string userName) { return new IdentityError { Code = nameof(DuplicateUserName), Description = $"Nazwa użytkownika '{userName}' jest zajęta." }; }
        public override IdentityError DuplicateEmail(string email) { return new IdentityError { Code = nameof(DuplicateEmail), Description = $"Adres '{email}' jest zajęty." }; }
        public override IdentityError InvalidRoleName(string role) { return new IdentityError { Code = nameof(InvalidRoleName), Description = $"Grupa '{role}' jest nieprawidłowa." }; }
        public override IdentityError DuplicateRoleName(string role) { return new IdentityError { Code = nameof(DuplicateRoleName), Description = $"Nazwa grupy '{role}' jest zajęta." }; }
        public override IdentityError UserAlreadyHasPassword() { return new IdentityError { Code = nameof(UserAlreadyHasPassword), Description = "Hasło użytkownika jest już ustawione." }; }
        public override IdentityError UserLockoutNotEnabled() { return new IdentityError { Code = nameof(UserLockoutNotEnabled), Description = "Blokada nie jest ustawiona dla tego użytkownika." }; }
        public override IdentityError UserAlreadyInRole(string role) { return new IdentityError { Code = nameof(UserAlreadyInRole), Description = $"Użytkownik ma już przypisaną grupę '{role}'." }; }
        public override IdentityError UserNotInRole(string role) { return new IdentityError { Code = nameof(UserNotInRole), Description = $"Użytkownik nie należy do grupy '{role}'." }; }
        public override IdentityError PasswordTooShort(int length) { return new IdentityError { Code = nameof(PasswordTooShort), Description = $"Hasło musi posiadać conajmniej {length} znaków." }; }
        public override IdentityError PasswordRequiresNonAlphanumeric() { return new IdentityError { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "Hasło musi posiadać przynajmniej jeden znak alfanumeryczny." }; }
        public override IdentityError PasswordRequiresDigit() { return new IdentityError { Code = nameof(PasswordRequiresDigit), Description = "Hasło musi posiadać przynajmniej jedną cyfrę ('0'-'9')." }; }
        public override IdentityError PasswordRequiresLower() { return new IdentityError { Code = nameof(PasswordRequiresLower), Description = "Hasło musi posiadać przynajmniej jedną małą literę ('a'-'z')." }; }
        public override IdentityError PasswordRequiresUpper() { return new IdentityError { Code = nameof(PasswordRequiresUpper), Description = "Hasło musi posiadać przynajmniej jedną wielką literę ('A'-'Z')." }; }
        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars) { return new IdentityError { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "Hasło musi posiadać przynajmniej jeden znak specjalny." }; }
        public override IdentityError RecoveryCodeRedemptionFailed() { return new IdentityError { Code = nameof(RecoveryCodeRedemptionFailed), Description = "Błąd podczas próby użycia kodu odzyskiwania ." }; }
    }
}

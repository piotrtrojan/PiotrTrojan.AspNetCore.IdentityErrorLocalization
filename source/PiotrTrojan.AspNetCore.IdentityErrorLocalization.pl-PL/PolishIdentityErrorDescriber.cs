using Microsoft.AspNetCore.Identity;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization.pl_PL
{
    public class PolishIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError ConcurrencyFailure() => new() { Code = nameof(ConcurrencyFailure), Description = "Błąd współbieżności, obiekt został zmodyfikowany." };
        public override IdentityError DefaultError() => new() { Code = nameof(DefaultError), Description = $"Wystąpił nieznany błąd." };
        public override IdentityError DuplicateEmail(string email) => new() { Code = nameof(DuplicateEmail), Description = $"Adres '{email}' jest zajęty." };
        public override IdentityError DuplicateRoleName(string role) => new() { Code = nameof(DuplicateRoleName), Description = $"Nazwa grupy '{role}' jest zajęta." };
        public override IdentityError DuplicateUserName(string userName) => new() { Code = nameof(DuplicateUserName), Description = $"Nazwa użytkownika '{userName}' jest zajęta." };
        public override IdentityError InvalidEmail(string email) => new() { Code = nameof(InvalidEmail), Description = $"Email '{email}' jest nieprawidłowy." };
        public override IdentityError InvalidRoleName(string role) => new() { Code = nameof(InvalidRoleName), Description = $"Grupa '{role}' jest nieprawidłowa." };
        public override IdentityError InvalidToken() => new() { Code = nameof(InvalidToken), Description = "Nieprawidłowy token." };
        public override IdentityError InvalidUserName(string userName) => new() { Code = nameof(InvalidUserName), Description = $"Nazwa użytkownika '{userName}' jest nieprawidłowa, może posiadać tylko znaki i cyfry." };
        public override IdentityError LoginAlreadyAssociated() => new() { Code = nameof(LoginAlreadyAssociated), Description = "Użytkownik o takiej nazwie już istnieje." };
        public override IdentityError PasswordMismatch() => new() { Code = nameof(PasswordMismatch), Description = "Nieprawidłowe hasło." };
        public override IdentityError PasswordRequiresDigit() => new() { Code = nameof(PasswordRequiresDigit), Description = "Hasło musi posiadać przynajmniej jedną cyfrę ('0'-'9')." };
        public override IdentityError PasswordRequiresLower() => new() { Code = nameof(PasswordRequiresLower), Description = "Hasło musi posiadać przynajmniej jedną małą literę ('a'-'z')." };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new() { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "Hasło musi posiadać przynajmniej jeden znak alfanumeryczny." };
        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars) => new() { Code = nameof(PasswordRequiresUniqueChars), Description = "Hasło musi posiadać przynajmniej jeden znak specjalny." };
        public override IdentityError PasswordRequiresUpper() => new() { Code = nameof(PasswordRequiresUpper), Description = "Hasło musi posiadać przynajmniej jedną wielką literę ('A'-'Z')." };
        public override IdentityError PasswordTooShort(int length) => new() { Code = nameof(PasswordTooShort), Description = $"Hasło musi posiadać conajmniej {length} znaków." };
        public override IdentityError RecoveryCodeRedemptionFailed() => new() { Code = nameof(RecoveryCodeRedemptionFailed), Description = "Błąd podczas próby użycia kodu odzyskiwania ." };
        public override IdentityError UserAlreadyHasPassword() => new() { Code = nameof(UserAlreadyHasPassword), Description = "Hasło użytkownika jest już ustawione." };
        public override IdentityError UserAlreadyInRole(string role) => new() { Code = nameof(UserAlreadyInRole), Description = $"Użytkownik ma już przypisaną grupę '{role}'." };
        public override IdentityError UserLockoutNotEnabled() => new() { Code = nameof(UserLockoutNotEnabled), Description = "Blokada nie jest ustawiona dla tego użytkownika." };
        public override IdentityError UserNotInRole(string role) => new() { Code = nameof(UserNotInRole), Description = $"Użytkownik nie należy do grupy '{role}'." };
    }
}

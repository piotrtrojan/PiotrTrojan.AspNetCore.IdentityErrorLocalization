using Microsoft.AspNetCore.Identity;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization.uk_UA
{
    public class UkrainianIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError ConcurrencyFailure() => new() { Code = nameof(ConcurrencyFailure), Description = "Помилка паралельності, об’єкт змінено." };
        public override IdentityError DefaultError() => new() { Code = nameof(DefaultError), Description = $"Сталася невідома помилка." };
        public override IdentityError DuplicateEmail(string email) => new() { Code = nameof(DuplicateEmail), Description = $"Адреса '{email}' зайнята." };
        public override IdentityError DuplicateRoleName(string role) => new() { Code = nameof(DuplicateRoleName), Description = $"Ім'я групи '{role}' зайняте." };
        public override IdentityError DuplicateUserName(string userName) => new() { Code = nameof(DuplicateUserName), Description = $"Ім'я користувача '{userName}' зайняте." };
        public override IdentityError InvalidEmail(string email) => new() { Code = nameof(InvalidEmail), Description = $"Неприпустима адреса Email '{email}'." };
        public override IdentityError InvalidRoleName(string role) => new() { Code = nameof(InvalidRoleName), Description = $"Неприпустима назва групи '{role}'." };
        public override IdentityError InvalidToken() => new() { Code = nameof(InvalidToken), Description = "Недійсний або невірний токен." };
        public override IdentityError InvalidUserName(string userName) => new() { Code = nameof(InvalidUserName), Description = $"Неприпустиме ім'я користувача '{0}', ім'я може містити тільки символи і цифри." };
        public override IdentityError LoginAlreadyAssociated() => new() { Code = nameof(LoginAlreadyAssociated), Description = "Користувач з таким іменем вже існує." };
        public override IdentityError PasswordMismatch() => new() { Code = nameof(PasswordMismatch), Description = "Невірний пароль." };
        public override IdentityError PasswordRequiresDigit() => new() { Code = nameof(PasswordRequiresDigit), Description = "Пароль повинен мати хоча б одну цифру ('0'-'9')." };
        public override IdentityError PasswordRequiresLower() => new() { Code = nameof(PasswordRequiresLower), Description = "Пароль повинен мати як мінімум одну малу літеру ('a'-'z')." };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new() { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "Пароль повинен мати хоча б один буквенно-цифровий символ." };
        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars) => new() { Code = nameof(PasswordRequiresUniqueChars), Description = $"Пароль повинен мати {uniqueChars} спеціальних символів." };
        public override IdentityError PasswordRequiresUpper() => new() { Code = nameof(PasswordRequiresUpper), Description = "Пароль повинен мати хоча б одну велику літеру ('A'-'Z')." };
        public override IdentityError PasswordTooShort(int length) => new() { Code = nameof(PasswordTooShort), Description = $"Пароль повинен містити як мінімум {length} символів." };
        public override IdentityError UserAlreadyHasPassword() => new() { Code = nameof(UserAlreadyHasPassword), Description = "Пароль користувача вже встановлений." };
        public override IdentityError UserAlreadyInRole(string role) => new() { Code = nameof(UserAlreadyInRole), Description = $"Користувач вже має призначену групу '{0}'." };
        public override IdentityError UserLockoutNotEnabled() => new() { Code = nameof(UserLockoutNotEnabled), Description = "Блокування не встановлено для цього користувача." };
        public override IdentityError UserNotInRole(string role) => new() { Code = nameof(UserNotInRole), Description = $"Користувач не входить до групи '{role}'." };
    }
}
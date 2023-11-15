using Microsoft.AspNetCore.Identity;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization.ru_RU
{
    public class RussianIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError ConcurrencyFailure() => new() { Code = nameof(ConcurrencyFailure), Description = "Ошибка оптимистичного контроля параллелизма, объект был изменён" };
        public override IdentityError DefaultError() => new() { Code = nameof(DefaultError), Description = $"Произошла неизвестная ошибка" };
        public override IdentityError DuplicateEmail(string email) => new() { Code = nameof(DuplicateEmail), Description = $"Email '{email}' уже используется" };
        public override IdentityError DuplicateRoleName(string role) => new() { Code = nameof(DuplicateRoleName), Description = $"Имя роли '{role}' уже используется" };
        public override IdentityError DuplicateUserName(string userName) => new() { Code = nameof(DuplicateUserName), Description = $"Пользователь с именем '{userName}' уже существует" };
        public override IdentityError InvalidEmail(string email) => new() { Code = nameof(InvalidEmail), Description = $"Email '{email}' некорректен" };
        public override IdentityError InvalidRoleName(string role) => new() { Code = nameof(InvalidRoleName), Description = $"Имя роли '{role}' некорректно" };
        public override IdentityError InvalidToken() => new() { Code = nameof(InvalidToken), Description = "Недействительный токен" };
        public override IdentityError InvalidUserName(string userName) => new() { Code = nameof(InvalidUserName), Description = $"Имя пользователя '{userName}' некорректно, может содержать только буквы и цифры" };
        public override IdentityError LoginAlreadyAssociated() => new() { Code = nameof(LoginAlreadyAssociated), Description = "Пользователь с таким логином уже существует" };
        public override IdentityError PasswordMismatch() => new() { Code = nameof(PasswordMismatch), Description = "Некорретный пароль" };
        public override IdentityError PasswordRequiresDigit() => new() { Code = nameof(PasswordRequiresDigit), Description = "Пароль должен содержать хотя бы одну цифру ('0'-'9')." };
        public override IdentityError PasswordRequiresLower() => new() { Code = nameof(PasswordRequiresLower), Description = "Пароль должен содержать хотя бы один символ в нижнем регистре ('a'-'z')." };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new() { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "Пароль должен содержать хотя бы один не буквенно-цифровой символ" };
        public override IdentityError PasswordRequiresUpper() => new() { Code = nameof(PasswordRequiresUpper), Description = "Пароль должен содержать хотя бы один символ в верхнем регистре ('A'-'Z')" };
        public override IdentityError PasswordTooShort(int length) => new() { Code = nameof(PasswordTooShort), Description = $"Пароль должен быть длиной не менее {length} символов" };
        public override IdentityError UserAlreadyHasPassword() => new() { Code = nameof(UserAlreadyHasPassword), Description = "Пользователь уже установил пароль" };
        public override IdentityError UserAlreadyInRole(string role) => new() { Code = nameof(UserAlreadyInRole), Description = $"Пользователю уже присвоена роль '{role}'." };
        public override IdentityError UserLockoutNotEnabled() => new() { Code = nameof(UserLockoutNotEnabled), Description = "Блокировка недоступна для этого пользователя" };
        public override IdentityError UserNotInRole(string role) => new() { Code = nameof(UserNotInRole), Description = $"У пользователя нет роли '{role}'." };
    }
}
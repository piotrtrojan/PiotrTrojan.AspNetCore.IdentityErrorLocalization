using Microsoft.AspNetCore.Identity;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization.es_ES
{
    public class SpanishIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError ConcurrencyFailure() => new() { Code = nameof(ConcurrencyFailure), Description = "Ha ocurrido un error, el objeto ya ha sido modificado (Optimistic concurrency failure)." };
        public override IdentityError DefaultError() => new() { Code = nameof(DefaultError), Description = $"Ha ocurrido un error." };
        public override IdentityError DuplicateEmail(string email) => new() { Code = nameof(DuplicateEmail), Description = $"La direccion de email '{email}' ya se encuentra registrada. Puede recupar su contraseña para ingresar nuevamente al sistema." };
        public override IdentityError DuplicateRoleName(string role) => new() { Code = nameof(DuplicateRoleName), Description = $"El nombre de rol '{role}' ya existe." };
        public override IdentityError DuplicateUserName(string userName) => new() { Code = nameof(DuplicateUserName), Description = $"El usuario '{userName}' ya existe, por favor ingrese un nombre diferente." };
        public override IdentityError InvalidEmail(string email) => new() { Code = nameof(InvalidEmail), Description = $"La dirección de email '{email}' es incorrecta." };
        public override IdentityError InvalidRoleName(string role) => new() { Code = nameof(InvalidRoleName), Description = $"El nombre de rol '{role}' es inválido." };
        public override IdentityError InvalidToken() => new() { Code = nameof(InvalidToken), Description = "Ha ingresado un código Inválido." };
        public override IdentityError InvalidUserName(string userName) => new() { Code = nameof(InvalidUserName), Description = $"El nombre de usuario '{userName}' es inválido. Solo puede contener letras y números." };
        public override IdentityError LoginAlreadyAssociated() => new() { Code = nameof(LoginAlreadyAssociated), Description = "Un usuario con ese nombre ya existe." };
        public override IdentityError PasswordMismatch() => new() { Code = nameof(PasswordMismatch), Description = "Password Incorrecta." };
        public override IdentityError PasswordRequiresDigit() => new() { Code = nameof(PasswordRequiresDigit), Description = "La contraseña debe incluir al menos un dígito ('0'-'9')." };
        public override IdentityError PasswordRequiresLower() => new() { Code = nameof(PasswordRequiresLower), Description = "La contraseña debe incluir al menos una letra minúscula ('a'-'z')." };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new() { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "La contraseña debe contener al menos un caracter alfanumérico." };
        public override IdentityError PasswordRequiresUpper() => new() { Code = nameof(PasswordRequiresUpper), Description = "La contraseña debe incluir al menos una letra MAYÚSCULA ('A'-'Z')." };
        public override IdentityError PasswordTooShort(int length) => new() { Code = nameof(PasswordTooShort), Description = $"La contraseña deben tener un largo mínimo de {length} caracteres." };
        public override IdentityError UserAlreadyHasPassword() => new() { Code = nameof(UserAlreadyHasPassword), Description = "El usuario ya tiene contraseña." };
        public override IdentityError UserAlreadyInRole(string role) => new() { Code = nameof(UserAlreadyInRole), Description = $"El usuario ya es parte del rol '{role}'." };
        public override IdentityError UserLockoutNotEnabled() => new() { Code = nameof(UserLockoutNotEnabled), Description = "El bloqueo no esta habilitado para este usuario." };
        public override IdentityError UserNotInRole(string role) => new() { Code = nameof(UserNotInRole), Description = $"El usuario no es parte del rol '{role}'." };
    }
}
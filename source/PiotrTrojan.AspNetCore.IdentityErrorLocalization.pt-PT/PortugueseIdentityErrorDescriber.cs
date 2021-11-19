using Microsoft.AspNetCore.Identity;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization.pt_PT
{
    public class PortugueseIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError ConcurrencyFailure() => new() { Code = nameof(ConcurrencyFailure), Description = "Falha de concorrência otimista, o objeto foi modificado." };
        public override IdentityError DefaultError() => new() { Code = nameof(DefaultError), Description = $"Um erro desconhecido ocorreu." };
        public override IdentityError DuplicateEmail(string email) => new() { Code = nameof(DuplicateEmail), Description = $"Email '{email}' já está sendo utilizado." };
        public override IdentityError DuplicateRoleName(string role) => new() { Code = nameof(DuplicateRoleName), Description = $"A permissão '{role}' já está sendo utilizada." };
        public override IdentityError DuplicateUserName(string userName) => new() { Code = nameof(DuplicateUserName), Description = $"Login '{userName}' já está sendo utilizado." };
        public override IdentityError InvalidEmail(string email) => new() { Code = nameof(InvalidEmail), Description = $"Email '{email}' é inválido." };
        public override IdentityError InvalidRoleName(string role) => new() { Code = nameof(InvalidRoleName), Description = $"A permissão '{role}' é inválida." };
        public override IdentityError InvalidToken() => new() { Code = nameof(InvalidToken), Description = "Token inválido." };
        public override IdentityError InvalidUserName(string userName) => new() { Code = nameof(InvalidUserName), Description = $"Login '{userName}' é inválido, pode conter apenas letras ou dígitos." };
        public override IdentityError LoginAlreadyAssociated() => new() { Code = nameof(LoginAlreadyAssociated), Description = "Já existe um usuário com este login." };
        public override IdentityError PasswordMismatch() => new() { Code = nameof(PasswordMismatch), Description = "Senha incorreta." };
        public override IdentityError PasswordRequiresDigit() => new() { Code = nameof(PasswordRequiresDigit), Description = "Senhas devem conter ao menos um digito ('0'-'9')." };
        public override IdentityError PasswordRequiresLower() => new() { Code = nameof(PasswordRequiresLower), Description = "Senhas devem conter ao menos um caracter em caixa baixa ('a'-'z')." };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new() { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "Senhas devem conter ao menos um caracter não alfanumérico." };
        public override IdentityError PasswordRequiresUpper() => new() { Code = nameof(PasswordRequiresUpper), Description = "Senhas devem conter ao menos um caracter em caixa alta ('A'-'Z')." };
        public override IdentityError PasswordTooShort(int length) => new() { Code = nameof(PasswordTooShort), Description = $"Senhas devem conter ao menos {length} caracteres." };
        public override IdentityError UserAlreadyHasPassword() => new() { Code = nameof(UserAlreadyHasPassword), Description = "Usuário já possui uma senha definida." };
        public override IdentityError UserAlreadyInRole(string role) => new() { Code = nameof(UserAlreadyInRole), Description = $"Usuário já possui a permissão '{role}'." };
        public override IdentityError UserLockoutNotEnabled() => new() { Code = nameof(UserLockoutNotEnabled), Description = "Lockout não está habilitado para este usuário." };
        public override IdentityError UserNotInRole(string role) => new() { Code = nameof(UserNotInRole), Description = $"Usuário não tem a permissão '{role}'." };
    }
}
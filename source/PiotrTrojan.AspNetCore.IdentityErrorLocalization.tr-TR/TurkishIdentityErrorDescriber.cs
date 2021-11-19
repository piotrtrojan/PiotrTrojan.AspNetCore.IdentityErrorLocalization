using Microsoft.AspNetCore.Identity;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization.tr_TR
{
    public class TurkishIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError ConcurrencyFailure() => new() { Code = nameof(ConcurrencyFailure), Description = "Bir eşzamanlılık hatası meydana geldi lütfen tekrar deneyin." };
        public override IdentityError DefaultError() => new() { Code = nameof(DefaultError), Description = $"Bilinmeyen bir hata meydana geldi." };
        public override IdentityError DuplicateEmail(string email) => new() { Code = nameof(DuplicateEmail), Description = $"'{email}', bu e-posta adresi zaten kullanımda." };
        public override IdentityError DuplicateRoleName(string role) => new() { Code = nameof(DuplicateRoleName), Description = $"'{role}', bu rol adı zaten kullanımda." };
        public override IdentityError DuplicateUserName(string userName) => new() { Code = nameof(DuplicateUserName), Description = $"'{userName}', bu kullanıcı adı zaten kullanımda." };
        public override IdentityError InvalidEmail(string email) => new() { Code = nameof(InvalidEmail), Description = $"'{email}', bu e-posta adresi geçersiz." };
        public override IdentityError InvalidRoleName(string role) => new() { Code = nameof(InvalidRoleName), Description = $"'{role}', bu rol adı geçerli değil." };
        public override IdentityError InvalidToken() => new() { Code = nameof(InvalidToken), Description = "Üretilen eşleştirme kodu geçerli değil." };
        public override IdentityError InvalidUserName(string userName) => new() { Code = nameof(InvalidUserName), Description = $"'{userName}', bu kullanıcı adı geçersiz; sadece harf ve sayı kullanın." };
        public override IdentityError LoginAlreadyAssociated() => new() { Code = nameof(LoginAlreadyAssociated), Description = "Bu bilgilere sahip bir kullanıcı sistemde zaten var." };
        public override IdentityError PasswordMismatch() => new() { Code = nameof(PasswordMismatch), Description = "Şifreler eşleşmiyor." };
        public override IdentityError PasswordRequiresDigit() => new() { Code = nameof(PasswordRequiresDigit), Description = "Parola en az bir rakam içermelidir." };
        public override IdentityError PasswordRequiresLower() => new() { Code = nameof(PasswordRequiresLower), Description = "Parola en az bir küçük harf içermelidir. ('a'-'z')." };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new() { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "Parola en az bir özel karakter içermelidir (örn. *,!_- vb.)." };
        public override IdentityError PasswordRequiresUpper() => new() { Code = nameof(PasswordRequiresUpper), Description = "Parola en az bir büyük harf içermelidir. ('A'-'Z')." };
        public override IdentityError PasswordTooShort(int length) => new() { Code = nameof(PasswordTooShort), Description = $"Parola en az {length} uzunluğunda olmalı." };
        public override IdentityError UserAlreadyHasPassword() => new() { Code = nameof(UserAlreadyHasPassword), Description = "Bu kullanıcı için zaten bir şifre atanmış durumda." };
        public override IdentityError UserAlreadyInRole(string role) => new() { Code = nameof(UserAlreadyInRole), Description = $"Kullanıcı zaten '{role}' adlı role sahip." };
        public override IdentityError UserLockoutNotEnabled() => new() { Code = nameof(UserLockoutNotEnabled), Description = "Bu kullanıcı için giriş engelleme özelliği aktif değil." };
        public override IdentityError UserNotInRole(string role) => new() { Code = nameof(UserNotInRole), Description = $"Kullanıcı '{role}' adlı role sahip değil." };
    }
}
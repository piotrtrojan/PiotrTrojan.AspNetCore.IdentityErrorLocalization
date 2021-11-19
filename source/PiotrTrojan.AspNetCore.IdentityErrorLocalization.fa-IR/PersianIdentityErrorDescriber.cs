using Microsoft.AspNetCore.Identity;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization.fa_IR
{
    public class PersianIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError ConcurrencyFailure() => new() { Code = nameof(ConcurrencyFailure), Description = "رکورد جاری پیشتر ویرایش شده‌است و تغییرات شما آن‌را بازنویسی خواهد کرد." };
        public override IdentityError DefaultError() => new() { Code = nameof(DefaultError), Description = $"یک خطای ناشناخته رخ داده است." };
        public override IdentityError DuplicateEmail(string email) => new() { Code = nameof(DuplicateEmail), Description = $"ایمیل '{email}' به کاربر دیگری اختصاص یافته است." };
        public override IdentityError DuplicateRoleName(string role) => new() { Code = nameof(DuplicateRoleName), Description = $"این نام نقش '{role}' به کاربر دیگری اختصاص یافته است." };
        public override IdentityError DuplicateUserName(string userName) => new() { Code = nameof(DuplicateUserName), Description = $"این نام کاربری '{userName}' به کاربر دیگری اختصاص یافته است." };
        public override IdentityError InvalidEmail(string email) => new() { Code = nameof(InvalidEmail), Description = $"ایمیل '{email}' نامعتبر است." };
        public override IdentityError InvalidRoleName(string role) => new() { Code = nameof(InvalidRoleName), Description = $"نام نقش '{role}' نامعتبر است." };
        public override IdentityError InvalidToken() => new() { Code = nameof(InvalidToken), Description = "کلمه عبور نامعتبر است." };
        public override IdentityError InvalidUserName(string userName) => new() { Code = nameof(InvalidUserName), Description = $"نام کاربری '{userName}' نامعتبر است، فقط می تواند حاوی حروف ویا اعداد باشد." };
        public override IdentityError LoginAlreadyAssociated() => new() { Code = nameof(LoginAlreadyAssociated), Description = "این کاربر قبلأ اضافه شده‌است." };
        public override IdentityError PasswordMismatch() => new() { Code = nameof(PasswordMismatch), Description = "کلمه عبور نادرست است." };
        public override IdentityError PasswordRequiresDigit() => new() { Code = nameof(PasswordRequiresDigit), Description = "کلمه عبور باید حداقل یک عدد داشته باشد." };
        public override IdentityError PasswordRequiresLower() => new() { Code = nameof(PasswordRequiresLower), Description = "کلمه عبور باید حداقل یک حرف کوچک داشته باشد." };
        public override IdentityError PasswordRequiresNonAlphanumeric() => new() { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "کلمه عبور باید حداقل یک کاراکتر غیر از حروف الفبا داشته باشد." };
        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars) => new() { Code = nameof(PasswordRequiresUniqueChars), Description = $"کلمه عبور باید حداقل داراى {uniqueChars} حرف متفاوت باشد." };
        public override IdentityError PasswordRequiresUpper() => new() { Code = nameof(PasswordRequiresUpper), Description = "کلمه عبور باید حداقل یک حرف بزرگ داشته باشد." };
        public override IdentityError PasswordTooShort(int length) => new() { Code = nameof(PasswordTooShort), Description = $"کلمه عبور باید حداقل {length} کاراکتر باشد." };
        public override IdentityError RecoveryCodeRedemptionFailed() => new() { Code = nameof(RecoveryCodeRedemptionFailed), Description = "بازیابی ناموفق بود." };
        public override IdentityError UserAlreadyHasPassword() => new() { Code = nameof(UserAlreadyHasPassword), Description = "کلمه‌ی عبور کاربر قبلأ تنظیم شده‌است." };
        public override IdentityError UserAlreadyInRole(string role) => new() { Code = nameof(UserAlreadyInRole), Description = $"این نقش '{role}' قبلأ به این کاربر اختصاص یافته است." };
        public override IdentityError UserLockoutNotEnabled() => new() { Code = nameof(UserLockoutNotEnabled), Description = "این کاربر فعال است." };
        public override IdentityError UserNotInRole(string role) => new() { Code = nameof(UserNotInRole), Description = $"این نقش '{role}' قبلأ به این کاربر اختصاص نیافته است." };
    }
}
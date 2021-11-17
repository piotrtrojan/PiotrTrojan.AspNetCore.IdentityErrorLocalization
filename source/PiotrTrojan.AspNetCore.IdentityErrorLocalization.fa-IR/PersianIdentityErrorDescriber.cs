using Microsoft.AspNetCore.Identity;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization.fa_IR
{
    public class PersianIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DefaultError() { return new IdentityError { Code = nameof(DefaultError), Description = $"یک خطای ناشناخته رخ داده است." }; }
        public override IdentityError ConcurrencyFailure() { return new IdentityError { Code = nameof(ConcurrencyFailure), Description = "رکورد جاری پیشتر ویرایش شده‌است و تغییرات شما آن‌را بازنویسی خواهد کرد." }; }
        public override IdentityError PasswordMismatch() { return new IdentityError { Code = nameof(PasswordMismatch), Description = "کلمه عبور نادرست است." }; }
        public override IdentityError InvalidToken() { return new IdentityError { Code = nameof(InvalidToken), Description = "کلمه عبور نامعتبر است." }; }
        public override IdentityError LoginAlreadyAssociated() { return new IdentityError { Code = nameof(LoginAlreadyAssociated), Description = "این کاربر قبلأ اضافه شده‌است." }; }
        public override IdentityError InvalidUserName(string userName) { return new IdentityError { Code = nameof(InvalidUserName), Description = $"نام کاربری '{userName}' نامعتبر است، فقط می تواند حاوی حروف ویا اعداد باشد." }; }
        public override IdentityError InvalidEmail(string email) { return new IdentityError { Code = nameof(InvalidEmail), Description = $"ایمیل '{email}' نامعتبر است." }; }
        public override IdentityError DuplicateUserName(string userName) { return new IdentityError { Code = nameof(DuplicateUserName), Description = $"این نام کاربری '{userName}' به کاربر دیگری اختصاص یافته است." }; }
        public override IdentityError DuplicateEmail(string email) { return new IdentityError { Code = nameof(DuplicateEmail), Description = $"ایمیل '{email}' به کاربر دیگری اختصاص یافته است." }; }
        public override IdentityError InvalidRoleName(string role) { return new IdentityError { Code = nameof(InvalidRoleName), Description = $"نام نقش '{role}' نامعتبر است." }; }
        public override IdentityError DuplicateRoleName(string role) { return new IdentityError { Code = nameof(DuplicateRoleName), Description = $"این نام نقش '{role}' به کاربر دیگری اختصاص یافته است." }; }
        public override IdentityError UserAlreadyHasPassword() { return new IdentityError { Code = nameof(UserAlreadyHasPassword), Description = "کلمه‌ی عبور کاربر قبلأ تنظیم شده‌است." }; }
        public override IdentityError UserLockoutNotEnabled() { return new IdentityError { Code = nameof(UserLockoutNotEnabled), Description = "این کاربر فعال است." }; }
        public override IdentityError UserAlreadyInRole(string role) { return new IdentityError { Code = nameof(UserAlreadyInRole), Description = $"این نقش '{role}' قبلأ به این کاربر اختصاص یافته است." }; }
        public override IdentityError UserNotInRole(string role) { return new IdentityError { Code = nameof(UserNotInRole), Description = $"این نقش '{role}' قبلأ به این کاربر اختصاص نیافته است." }; }
        public override IdentityError PasswordTooShort(int length) { return new IdentityError { Code = nameof(PasswordTooShort), Description = $"کلمه عبور باید حداقل {length} کاراکتر باشد." }; }
        public override IdentityError PasswordRequiresNonAlphanumeric() { return new IdentityError { Code = nameof(PasswordRequiresNonAlphanumeric), Description = "کلمه عبور باید حداقل یک کاراکتر غیر از حروف الفبا داشته باشد." }; }
        public override IdentityError PasswordRequiresDigit() { return new IdentityError { Code = nameof(PasswordRequiresDigit), Description = "کلمه عبور باید حداقل یک عدد داشته باشد." }; }
        public override IdentityError PasswordRequiresLower() { return new IdentityError { Code = nameof(PasswordRequiresLower), Description = "کلمه عبور باید حداقل یک حرف کوچک داشته باشد." }; }
        public override IdentityError PasswordRequiresUpper() { return new IdentityError { Code = nameof(PasswordRequiresUpper), Description = "کلمه عبور باید حداقل یک حرف بزرگ داشته باشد." }; }
        public override IdentityError RecoveryCodeRedemptionFailed() { return new IdentityError { Code = nameof(RecoveryCodeRedemptionFailed), Description = "بازیابی ناموفق بود." }; }
        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars) { return new IdentityError { Code = nameof(PasswordRequiresUniqueChars), Description = $"کلمه عبور باید حداقل داراى {uniqueChars} حرف متفاوت باشد." }; }
    }
}

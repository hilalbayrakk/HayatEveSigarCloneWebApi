
namespace HayatEveSigar.Validator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x=>x.Tc).NotNull().WithMessage("Kullanici Tc Alani Boş Geçilemez !!!")
                            .Length(11,11).WithMessage("Tc Alani 11 Rakam Karakterinden Olusmalidir !!!");
            RuleFor(x=>x.Name).NotNull().WithMessage("Kullanici Ad Alani Boş Geçilemez !!!");
            RuleFor(x=>x.Surname).NotNull().WithMessage("Kullanici Soyad Alani Boş Geçilemez !!!");
            RuleFor(x=>x.Birthday).NotNull().WithMessage("Kullanici Dogum Tarihi Alani Boş Geçilemez !!!");
            RuleFor(x=>x.Gender).NotNull().WithMessage("Kullanici Cinsiyet Alani Boş Geçilemez !!!");
            RuleFor(x=>x.Email).NotNull().WithMessage("Kullanici Email Alani Boş Geçilemez !!!");
        }
    }
}
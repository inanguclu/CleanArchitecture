using FluentValidation;

namespace CleanArchitecture.Application.Features.AuthFeatures.Commands.Register
{
    public sealed class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {

        public RegisterCommandValidator()
        {
            RuleFor(p => p.Email).NotEmpty().WithMessage("Mail bilgisi bos olamaz");
            RuleFor(p => p.Email).NotNull().WithMessage("Mail bilgisi bos olamaz");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Gecerli bir mail adresi girin");

            RuleFor(p => p.UserName).NotEmpty().WithMessage("Kullanici adi bos olamaz");
            RuleFor(p => p.UserName).NotNull().WithMessage("Kullanici adi bos olamaz");
            RuleFor(p => p.UserName).MinimumLength(3).WithMessage("Kullanici adi en az 3 karakter olmalidir! ");

            RuleFor(p => p.Password).NotEmpty().WithMessage("Sifre bos olamaz");
            RuleFor(p => p.Password).NotNull().WithMessage("Sifre bos olamaz");
            RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Sifre en az 1 adet buyuk karakter icermelidir! ");
            RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Sifre en az 1 adet kucuk karakter icermelidir! ");
            RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Sifre en az 1 adet rakam icermelidir! ");
            RuleFor(p => p.Password).Matches("[^a-zA-Z0-9]").WithMessage("Sifre en az 1 adet ozel karakter icermelidir! ");





        }
    }
}

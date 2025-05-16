using FluentValidation;

namespace YoutubeApi.Application.Features.Auth.Command.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommandRequest>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(2)
                .WithName("isim Soyisim");

            RuleFor(x => x.Email)
                .NotEmpty()
                .MaximumLength(60)
                .MinimumLength(8)
                .WithName("E-Posta Adresi");

            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(6)
                .WithName("Parola");

            RuleFor(x => x.ConfirmPassword)
                .NotEmpty()
                .MinimumLength(6)
                .Equal(x => x.Password)
                .WithName("Parola Tekrarı");
        }
    }
}

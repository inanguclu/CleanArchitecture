﻿using FluentValidation;

namespace CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;

public sealed class CreateCarCommandValidator:AbstractValidator<CreateCarCommand>
{
    public CreateCarCommandValidator()
    {
        RuleFor(p=>p.Name).NotEmpty().WithMessage("Arac adi bos olamaz!");
        RuleFor(p => p.Name).NotNull().WithMessage("Arac adi bos olamaz!");
        RuleFor(p => p.Name).MaximumLength(3).WithMessage("Arac adi en az 3 karakter olmalidir!");

        RuleFor(p => p.Model).NotEmpty().WithMessage("Arac Modeli bos olamaz!");
        RuleFor(p => p.Model).NotNull().WithMessage("Arac Modeli bos olamaz!");
        RuleFor(p => p.Model).MaximumLength(3).WithMessage("Arac Modeli en az 3 karakter olmalidir!");

        RuleFor(p => p.EnginePower).NotEmpty().WithMessage("Arac Motor gucu bos olamaz!");
        RuleFor(p => p.EnginePower).NotNull().WithMessage("Arac Motor gucu bos olamaz!");
        RuleFor(p => p.EnginePower).GreaterThan(0).WithMessage("aracin motor gucu 0'dan buyuk olmalidir!");
    }
}

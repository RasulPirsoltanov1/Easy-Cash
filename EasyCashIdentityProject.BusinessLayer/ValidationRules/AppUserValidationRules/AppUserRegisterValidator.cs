using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(u => u.Name).MinimumLength(2).MaximumLength(30).NotNull().NotEmpty();
            RuleFor(u => u.Surname).MinimumLength(2).MaximumLength(30).NotNull().NotEmpty();
            RuleFor(u => u.Email).EmailAddress().NotNull().NotEmpty();
            RuleFor(u => u.Password).MinimumLength(8).MaximumLength(30).NotNull().NotEmpty();
            RuleFor(u => u.ConfirmPassword).Equal(u => u.ConfirmPassword);
        }
    }
}

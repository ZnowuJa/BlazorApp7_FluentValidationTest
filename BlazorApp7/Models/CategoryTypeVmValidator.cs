using FluentValidation;

namespace BlazorApp7.Models;
public class CategoryTypeVmValidator : AbstractValidator<CategoryTypeVm>
{
    public CategoryTypeVmValidator()
    {

        //RuleFor(x => x.Name).MinimumLength(3).MaximumLength(11);
        RuleFor(x => x.Name).NotEqual("Hardware").WithMessage("Select Category Type, pls!");
        //RuleFor(x => x.Name).NotEmpty().MinimumLength(3).WithMessage("AV:: Name should have 3-10 characters!").MaximumLength(10).WithMessage("AV :: Name should have 3-10 characters!");
        //;

        //RuleFor(x => x.Name).Custom((value, context) =>
        //{
        //    // Your custom validation logic for the 'Name' field
        //    if (value.Length > 10 || value.Length < 3)
        //    {
        //        context.AddFailure("Name", "Name should be 3 - 10 characters...");
        //    }
        //});

    }
}
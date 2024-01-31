using FluentValidation;

namespace BlazorApp7.Models;
public class CategoryVmValidator : AbstractValidator<CategoryVm>
{
    public CategoryVmValidator()
    {

        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(10);
        RuleFor(x => x.Prefix).NotEmpty().MinimumLength(3).MaximumLength(8);
        RuleFor(x => x.CategoryTypeVm).SetValidator(new CategoryTypeVmValidator());
    }
}
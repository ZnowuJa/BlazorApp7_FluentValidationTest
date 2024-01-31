using FluentValidation;

namespace BlazorApp7.Models;

public class Address
{
    public string? Line1 { get; set; }
    public string? Line2 { get; set; }
    public string? Town { get; set; }
    public string? County { get; set; }
    public string? Postcode { get; set; }
}

public class AddressValidator : AbstractValidator<Address>
{
    public AddressValidator()
    {
        RuleFor(p => p.Line1).NotEmpty().WithMessage("You must enter Line 1");
        RuleFor(p => p.Town).MinimumLength(2).WithMessage("You must enter a town");
        RuleFor(p => p.County).MinimumLength(2).WithMessage("You must enter a county");
        RuleFor(p => p.Postcode).MinimumLength(2).WithMessage("You must enter a postcode");
    }
}

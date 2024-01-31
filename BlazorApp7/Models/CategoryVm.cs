using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlazorApp7.Models;

public class CategoryVm
{ 
    public int Id { get; set; }
    public string Name { get; set; }
    public string Prefix { get; set; }
    public int? StatusId { get; set; }
    public CategoryTypeVm? CategoryTypeVm { get; set; }

}

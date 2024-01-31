using System.ComponentModel.DataAnnotations;

namespace BlazorApp7.Models;

public class Invoice
{
    public string Id { get; set; }

    [Required]
    [StringLength(6, ErrorMessage = "Identifier too long (6 character limit).")]
    public string Name { get; set; }
    
    [Required]
    [StringLength(16, ErrorMessage = "Identifier too long (16 character limit).")]
    public string Description { get; set; }

    public string Address { get; set; }
    public int Qty { get; set; }
    public DateTime Delivery { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;


}

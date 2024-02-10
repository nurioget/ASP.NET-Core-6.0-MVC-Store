using System.ComponentModel.DataAnnotations;

namespace Entities.Models;
public class Product
{

    public int ProductId { get; set; }
    [Required(ErrorMessage ="ProductName is required")]
    public string? ProductName { get; set; } = string.Empty;
    [Required(ErrorMessage = "Price is required")]
    public decimal Price { get; set; }
}

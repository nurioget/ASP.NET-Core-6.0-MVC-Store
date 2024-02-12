using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; }

        [Required(ErrorMessage = "ProductName is required")]
        public string? ProductName { get; init; } = string.Empty;
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; init; } 
        public int? CategoryId { get; init; }   
       
    }
}

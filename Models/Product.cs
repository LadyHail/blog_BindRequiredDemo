using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace BindRequiredAttributeDemo.Models
{
    public class Product
    {
        [Required]
        public string Name { get; set; }

        [BindRequired]
        public decimal Price { get; set; }
    }
}
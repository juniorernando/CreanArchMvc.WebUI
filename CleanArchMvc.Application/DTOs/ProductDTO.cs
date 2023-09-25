using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.DTOs
{
    public class ProductDTO
    {
        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [Display(Name = "Name")]

        public string? Name { get; set; }

        [Required(ErrorMessage = "The Description is Required")]
        [MinLength(5)]
        [MaxLength(200)]
        [Display(Name = "Description")]

        public string? Description { get; set; }

        [Required(ErrorMessage = "The Price is Required")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]

        public decimal Price { get; set; }

        [Required(ErrorMessage = "The Stock is Required")]
        [Range(1, 9999)]
        [Display(Name = "Stock")]

        public string Stock { get; set;}

        [MaxLength(250)]
        [Display(Name = "Product Image")]

        public string? Image { get; set; }
        public Category? Category { get; set; }

        [Display(Name = "Categories")]

        public int CategoryId { get; set; }
    }
}

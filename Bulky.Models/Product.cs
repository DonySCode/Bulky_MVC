using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BulkyBook.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1, 1000)]
        [DisplayName("List Price")]
        public int ListPrice { get; set; }
        [Required]
        [Range(1, 1000)]
        [DisplayName("Price from 1-50")]
        public int Price { get; set; }
        [Required]
        [Range(1, 1000)]
        [DisplayName("Price from 50-100")]
        public int Price50 { get; set; }
        [Required]
        [Range(1, 1000)]
        [DisplayName("Price from 100+")]
        public int Price100 { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
    }
}

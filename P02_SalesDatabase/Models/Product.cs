using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "float")]
        public double Quantity { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [MaxLength(250)]
        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; } = "No description";
    }
}

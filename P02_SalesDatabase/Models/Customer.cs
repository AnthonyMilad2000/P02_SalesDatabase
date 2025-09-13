using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Required]
        [MaxLength(80)]
        [Column(TypeName = "varchar(80)")]
        public string Email { get; set; }

        [Required]
        public string CreditCardNumber { get; set; }
    }

    }

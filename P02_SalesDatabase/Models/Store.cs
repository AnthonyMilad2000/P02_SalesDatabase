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
    internal class Store
    {
        [Key]
        public int StoreId { get; set; }

        [Required]
        [MaxLength(80)]
        [Column(TypeName = "nvarchar(80)")]
        public string Name { get; set; }

    }
}

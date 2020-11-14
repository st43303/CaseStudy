using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CaseStudy.Data.Entities
{
    public class Product : BaseAuditing
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImgUri { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        [Column(TypeName ="decimal(18,2")]
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}

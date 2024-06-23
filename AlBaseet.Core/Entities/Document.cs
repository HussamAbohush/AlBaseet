using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBaseet.Core.Entities
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? DocPath { get; set; }

    }
}

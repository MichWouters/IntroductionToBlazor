using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoBlazor.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naam is verplicht")]
        [MinLength(3)]
        [MaxLength(10)]
        public string Name { get; set; }

        [Range(1, 1, ErrorMessage = "Geen volwassen materiaal toegestaan")]
        public bool IsSuitableForChildren { get; set; }
    }
}

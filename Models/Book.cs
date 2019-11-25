using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(13)]
        [MinLength(10)]
        public string ISBN { get; set; }
        
        [Required]
        public string  Title { get; set; }
        
        [Required]
        public string Genre { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }
        
        [Required]
        public int Owner { get; set; }

    }
}

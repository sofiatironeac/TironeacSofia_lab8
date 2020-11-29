using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TironeacSofia_lab8.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]

        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }

        [Display(Name = "Publisher")]
        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }

        [Display(Name = "Category")]
        public int CategoryID { get; set; }
        public BookCategory BookCategory { get; set; }


    }
}

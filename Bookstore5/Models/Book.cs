using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore5.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public string Class { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Pages { get; set; } //update migration and update table to make new field
    }
}

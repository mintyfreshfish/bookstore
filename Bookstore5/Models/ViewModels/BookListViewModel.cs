//viewModels are...you guessed it, models made for specific views

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore5.Models.ViewModels //this is so we can bring one model into the index page but still have everything we need
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; } //IEnumerable means we can iterate through each book to get its info
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; } //shows what category we are currently filtering
    }
}

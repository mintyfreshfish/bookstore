using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore5.Models
{
    public class BookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext _context;

        //Constructor
        public BookstoreRepository(BookstoreContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}

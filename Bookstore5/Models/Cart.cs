using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (Book book, int quantity)
        {
            CartLine line = Lines.Where(b => b.Book.BookId == book.BookId) //match the input bookId with a bookId in the cart
                .FirstOrDefault();

            if (line == null) // if there is no matching book in cart, create the book and assign quantity
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });

          
            }
            else // if there is a matching book in the cart, then add to the quantity
                {
                    line.Quantity += quantity;
                }
        }

        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        public virtual void Clear() => Lines.Clear();

        public decimal ComputeTotalSum() => (decimal)(Lines.Sum(e => e.Book.Price * e.Quantity));

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}

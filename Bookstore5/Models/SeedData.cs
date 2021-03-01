using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore5.Models
{
    public class SeedData //this is the data we put in our database
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookstoreContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookstoreContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "Les Miserables",
                        FirstName = "Victor",
                        LastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Class = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        Pages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        FirstName = "Doris Kearns",
                        LastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Class = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        Pages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        FirstName = "Alice",
                        LastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Class = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        Pages = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        FirstName = "Ronald C.",
                        LastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Class = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        Pages = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        FirstName = "Laura",
                        LastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Class = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        Pages = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        FirstName = "Michael",
                        LastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Class = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        Pages = 288
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        FirstName = "Cal",
                        LastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Class = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        Pages = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        FirstName = "Michael",
                        LastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Class = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        Pages = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        FirstName = "Richard",
                        LastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Class = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        Pages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        FirstName = "John",
                        LastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Class = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        Pages = 642
                    },

                    new Book
                    {
                        Title = "Looking at Philosophy",
                        FirstName = "Donald",
                        LastName = "Palmer",
                        Publisher = "McGraw Hill",
                        ISBN = "978-072828951",
                        Class = "Non-Fiction",
                        Category = "Philosophy",
                        Price = 25,
                        Pages = 446
                    },

                    new Book
                    {
                        Title = "The Ultimate Hitchhiker's Guide to the Galaxy",
                        FirstName = "Douglas",
                        LastName = "Adams",
                        Publisher = "Ballantine",
                        ISBN = "978-0345453743",
                        Class = "Fiction",
                        Category = "Wonderful",
                        Price = 18.95,
                        Pages = 815
                    },


                    new Book
                    {
                        Title = "Bach, Beethoven, and the Boys",
                        FirstName = "David W",
                        LastName = "Barber",
                        Publisher = "Indent Publishing",
                        ISBN = "978-0980916713",
                        Class = "Non-Fiction",
                        Category = "Music",
                        Price = 16,
                        Pages = 144
                    });

                context.SaveChanges();
            }
        }
    }
}

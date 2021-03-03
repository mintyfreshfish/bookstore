using Bookstore5.Models;
using Bookstore5.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookstoreRepository _repository;
            
        public int pageSize = 5; //how many items per page

        public HomeController(ILogger<HomeController> logger, IBookstoreRepository repository) //"please collect the dataset from the repository"
        {
            _logger = logger;
            _repository = repository;

        }

        public IActionResult Index(string category, int page = 1) // put in page number (1 at load) and category type
        {
            return View(new BookListViewModel //"please make the BookListViewModel based on the repository"
            {
                Books = _repository.Books //decides which books to show. Uses Linc as queries
                .Where(p => category == null || p.Category == category) //only show what we want filtered
                .OrderBy(b => b.BookId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),

                PagingInfo = new PagingInfo //"please make the PagingInfo model based on the repository"
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalNumItems = category == null ? _repository.Books.Count() :
                        _repository.Books.Where(x => x.Category == category).Count() //this makes it so the pagination doesn't always show the max pages like the dumbfu** it is
                },

                CurrentCategory = category // sets the category based on filter choice
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

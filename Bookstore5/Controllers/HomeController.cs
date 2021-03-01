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

        public HomeController(ILogger<HomeController> logger, IBookstoreRepository repository)
        {
            _logger = logger;
            _repository = repository;

        }

        public IActionResult Index(int page = 1) //pass in first page number for index
        {
            return View(new BookListViewModel
            {
                Books = _repository.Books //decides which books to show. Uses Link as queries
                .OrderBy(b => b.BookId)
                .Skip((page - 1) * pageSize) //uses indexes so the -1 works
                .Take(pageSize),

                PagingInfo = new PagingInfo // refers to pagingInfo class to return the correct data for the view
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalNumItems = _repository.Books.Count()
                }
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

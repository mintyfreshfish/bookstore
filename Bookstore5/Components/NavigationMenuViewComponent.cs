using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore5.Models;

namespace Bookstore5.Components
{
    public class NavigationMenuViewComponent : ViewComponent //needs to be called viewComponent unless you die.
    {
        private IBookstoreRepository repository;

        public NavigationMenuViewComponent (IBookstoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke() //make a partial view and drop it on the index page so it can spread its goodness to the world
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"]; //this is how we will dynamically highlight the buttons. The viewbag lets us pass the data as to what page we are on back and forth. It is like global variable, except...not
            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}

//let us take note, that the folder to the left that holds the appropriate view is called NavigationMenu. This may look familiar, as this file is named similarly. Please remember that computers are idiots, and it needs to look at the right folder--the folder named like this file--to bring out the correct view. Silly computer! You dumb.

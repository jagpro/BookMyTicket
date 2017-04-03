using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookMyTicket.Client.MVC.TheatreServiceWebReference;
using BookMyTicket.Client.MVC.ShowServiceReference;

namespace BookMyTicket.Client.MVC.Controllers
{
    public class BookingSystemController : Controller
    {
        public ActionResult Index()
        {
            var theatreService = new TheatreService();
            var model = theatreService.GetTheatres().ToList();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var showService = new ShowService();
            var model = showService.GetShowsByTheatre(id, true).ToList();
            return View(model);
        }
    }
}

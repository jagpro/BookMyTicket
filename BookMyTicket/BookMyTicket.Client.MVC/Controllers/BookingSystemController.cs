using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookMyTicket.Client.MVC.TheatreServiceWebReference;

namespace BookMyTicket.Client.MVC.Controllers
{
    public class BookingSystemController : Controller
    {
        //
        // GET: /BookingSystem/

        public ActionResult Index()
        {
            TheatreService theatre = new TheatreService();
            var model = theatre.GetTheatres().ToList();
            return View(model);
        }

    }
}

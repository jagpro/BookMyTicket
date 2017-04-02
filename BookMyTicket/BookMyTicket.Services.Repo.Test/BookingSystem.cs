using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookMyTicket.Services.Repo;
using BookMyTicket.Services.DAL;

namespace BookMyTicket.Services.Repo.Test
{
    [TestClass]
    public class BookingSystem
    {
        private TheatreRepository _theatreRepository = null;

        public BookingSystem()
        {
            _theatreRepository = new TheatreRepository();
        }

        [TestMethod]
        public void VerifyHasTheatres()
        {
            var theatres = _theatreRepository.GetAll();
            Assert.IsFalse(theatres.Count == 0);
        }
    }
}

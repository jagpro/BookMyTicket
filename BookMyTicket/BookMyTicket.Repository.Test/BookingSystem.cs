using System;
using BookMyTicket.DomainModel;
using BookMyTicket.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookMyTicket.Repository.Test
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

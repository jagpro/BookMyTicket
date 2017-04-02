using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookMyTicket.Services.BL;

namespace BookMyTicket.Services.BL.Test
{
    [TestClass]
    public class BookingSystemTest
    {
        private BookingSystem _bookingSystem = null;
        public BookingSystemTest()
        {
            _bookingSystem = new BookingSystem();
        }

        [TestMethod]
        public void VerifyHasTheatres()
        {
            var theatres = _bookingSystem.GetAllTheatres();
            Assert.IsFalse(theatres.Count == 0);
        }
    }
}

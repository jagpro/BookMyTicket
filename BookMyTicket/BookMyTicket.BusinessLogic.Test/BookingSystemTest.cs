using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookMyTicket.BusinessLogic;

namespace BookMyTicket.BusinessLogic.Test
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

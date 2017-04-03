using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BookMyTicket.BusinessLogic;
using BookMyTicket.Services.DTO;
using BookMyTicket.Services.API;

namespace BookMyTicket.Services.WCF
{
    public class TheatreService : ITheatreService
    {
        private readonly BookingSystem _bookingSystem = null;
        public TheatreService()
        {
            if (_bookingSystem == null)
                _bookingSystem = new BookingSystem();
        }
        public TheatreDTO[] GetTheatres()
        {
            return _bookingSystem.GetAllTheatres().ToArray();
        }
    }
}

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
            return _bookingSystem
                .GetAllTheatres()
                .ToArray();
        }

        public TheatreDTO[] GetTheatresByName(string name)
        {
            return _bookingSystem
                .GetAllTheatres()
                .Where(t => t.Name.Contains(name))
                .ToArray();
        }

        public TheatreDTO[] GetTheatresByLocation(string location)
        {
            return _bookingSystem
                .GetAllTheatres()
                .Where(t => t.Location.Contains(location))
                .ToArray();
        }

        public TheatreDTO GetTheatreById(int id)
        {
            return _bookingSystem
                .GetAllTheatres()
                .Where(t => t.ID == id)
                .FirstOrDefault();
        }
    }
}

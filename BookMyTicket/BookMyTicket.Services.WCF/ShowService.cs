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
    public class ShowService : IShowService
    {
        private readonly IBookingSystem _bookingSystem = new BookingSystem();

        public ShowService()
        { 
        }

        public ShowDTO[] GetShows()
        {
            throw new NotImplementedException();
        }

        public ShowDTO[] GetShowsByTheatre(int id)
        {
            return _bookingSystem
                .GetShowsByTheatre(id)
                .ToArray();
        }
    }
}

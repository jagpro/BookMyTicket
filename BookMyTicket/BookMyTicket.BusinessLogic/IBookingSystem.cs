using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyTicket.Services.DTO;

namespace BookMyTicket.BusinessLogic
{
    public interface IBookingSystem
    {
        IList<TheatreDTO> GetAllTheatres();
        IList<TheatreDTO> GetAllTheatresByLocation();

        IList<ShowDTO> GetAllShows();
        IList<ShowDTO> GetShowsByTheatre(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyTicket.Services.DTO;

namespace BookMyTicket.Services.BL
{
    public interface IBookingSystem
    {
        IList<TheatreDTO> GetAllTheatres();
        IList<TheatreDTO> GetAllTheatresByLocation();        
    }
}

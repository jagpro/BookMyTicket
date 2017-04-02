using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyTicket.Services.DTO;
using BookMyTicket.Services.Repo;

namespace BookMyTicket.Services.BL
{
    public class BookingSystem: IBookingSystem
    {
        private TheatreRepository _theatreRepository = null;

        public BookingSystem() //TODO: DI;
        {
            _theatreRepository = new TheatreRepository();
        }

        public IList<TheatreDTO> GetAllTheatres()
        {
            var theatres = _theatreRepository.GetAll();
            var dtos = theatres.Select(x => new TheatreDTO()
            {
                ID = x.ID,
                Location = x.Location,
                MetaData = x.MetaData,
                Name = x.Name
            }).ToArray();

            return dtos;
        }

        public IList<TheatreDTO> GetAllTheatresByLocation()
        {
            throw new NotImplementedException();
        }
    }
}

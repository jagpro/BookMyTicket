using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyTicket.Services.DTO;
using BookMyTicket.Services.Repo;
using AutoMapper;
using BookMyTicket.DomainModel;

namespace BookMyTicket.Services.BL
{
    public class BookingSystem: IBookingSystem
    {
        private TheatreRepository _theatreRepository = null;

        public BookingSystem() //TODO: DI;
        {
            _theatreRepository = new TheatreRepository();
            Mapper.CreateMap<Theatre, TheatreDTO>();
        }

        public IList<TheatreDTO> GetAllTheatres()
        {
            var theatres = _theatreRepository.GetAll();
            var dtos = theatres.Select(theatre => Mapper.Map<TheatreDTO>(theatre)).ToArray();
            return dtos;            
        }

        public IList<TheatreDTO> GetAllTheatresByLocation()
        {
            throw new NotImplementedException();
        }
    }
}

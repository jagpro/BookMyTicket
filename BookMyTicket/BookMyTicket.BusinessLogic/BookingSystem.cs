using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookMyTicket.DomainModel;
using BookMyTicket.Repository;
using BookMyTicket.Services.DTO;

namespace BookMyTicket.BusinessLogic
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

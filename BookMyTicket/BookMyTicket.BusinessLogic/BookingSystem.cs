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
    public class BookingSystem : IBookingSystem
    {
        private readonly ITheatreRepository _theatreRepository = null;
        private readonly IShowRepository _showRepository = null;

        public BookingSystem() //TODO: DI;
        {
            _theatreRepository = new TheatreRepository();
            _showRepository = new ShowRepository();

            SetMappers();
        }

        private void SetMappers()
        {
            Mapper.CreateMap<Theatre, TheatreDTO>();

            Mapper.CreateMap<Movie, MovieDTO>();

            Mapper.CreateMap<Show, ShowDTO>()
                .ForMember(dest => dest.Movie, opts => opts.MapFrom(src => src.Movie.Name))
                .ForMember(dest => dest.Theatre, opts => opts.MapFrom(src => src.Theatre.Name));
        }

        public IList<TheatreDTO> GetAllTheatres()
        {
            return _theatreRepository
                .GetAll()
                .Select(theatre => Mapper.Map<TheatreDTO>(theatre))
                .ToList();
        }

        public IList<TheatreDTO> GetAllTheatresByLocation()
        {
            throw new NotImplementedException();
        }

        public IList<ShowDTO> GetAllShows()
        {
            throw new NotImplementedException();
        }

        public IList<ShowDTO> GetShowsByTheatre(int id)
        {
            return _showRepository
                .GetAll(m => m.Theatre, m => m.Movie) //include related theatre and movie
                .Where(s => s.TheatreID == id)
                .Select(show => Mapper.Map<ShowDTO>(show))
                .ToList();
        }
    }
}

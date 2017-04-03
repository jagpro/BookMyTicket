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
    public class MovieService : IMovieService
    {
        public MovieDTO[] GetMovies()
        {
            throw new NotImplementedException();
        }

        public MovieDTO[] GetMoviesByTheatre(int id)
        {
            throw new NotImplementedException();
        }
    }
}

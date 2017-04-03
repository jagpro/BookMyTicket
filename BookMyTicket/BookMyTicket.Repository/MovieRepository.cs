using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyTicket.DomainModel;

namespace BookMyTicket.Repository
{
    public interface IMovieRepository : IGenericDataRepository<Movie>
    {
    }

    public class MovieRepository : GenericDataRepository<Movie>, IMovieRepository
    {
    }
}

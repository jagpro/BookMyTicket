using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyTicket.Services.DAL;

namespace BookMyTicket.Services.Repo
{
    public interface ITheatreRepository : IGenericDataRepository<Theatre>
    {
    }

    public class TheatreRepository : GenericDataRepository<Theatre>, ITheatreRepository
    {
    }
}

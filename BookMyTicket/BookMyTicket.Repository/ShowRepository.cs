using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyTicket.DomainModel;

namespace BookMyTicket.Repository
{
    public interface IShowRepository : IGenericDataRepository<Show>
    {
    }

    public class ShowRepository : GenericDataRepository<Show>, IShowRepository
    {
    }
}

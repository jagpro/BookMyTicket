using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using BookMyTicket.Services.DTO;

namespace BookMyTicket.Services.API
{
    [ServiceContract]
    public interface IShowService
    {
        [OperationContract]
        ShowDTO[] GetShows();

        [OperationContract]
        ShowDTO[] GetShowsByTheatre(int id);
    }
}

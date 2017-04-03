using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using BookMyTicket.Services.DTO;

namespace BookMyTicket.Services.API
{
    [ServiceContract]
    public interface ITheatreService
    {

        [OperationContract]
        TheatreDTO[] GetTheatres();

        [OperationContract]
        TheatreDTO[] GetTheatresByName(string name);

        [OperationContract]
        TheatreDTO[] GetTheatresByLocation(string location);

        [OperationContract]
        TheatreDTO GetTheatreById(int id);
    }
}

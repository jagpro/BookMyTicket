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

        //[OperationContract]
        //string GetTheatresByLocation();

        //[OperationContract]
        //TheatreDTO GetTheatreById(int id);

        //[OperationContract]
        //string GetMovies();

        //[OperationContract]
        //string GetMoviesByTheatre();

        //[OperationContract]
        //string GetShowsForAMovie();

        //[OperationContract]
        //string GetAvailableSeatsForAShow();

        //[OperationContract]
        //string BookTickets();

        ////[OperationContract]
        ////CompositeType GetDataUsingDataContract(CompositeType composite);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTicket.Services.DTO
{
    [DataContract]
    public class ShowDTO
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int TheatreID { get; set; }

        [DataMember]
        public string Movie { get; set; }

        [DataMember]
        public int MovieID { get; set; }

        [DataMember]
        public string Theatre { get; set; }

        [DataMember]
        public string ScreenDateFrom { get; set; }
        
        [DataMember]
        public string ScreenDateTo { get; set; }

        [DataMember]
        public string ShowTime { get; set; }

        [DataMember]
        public int AvailableSeats { get; set; }

        [DataMember]
        public string MetaData { get; set; }
    }

}

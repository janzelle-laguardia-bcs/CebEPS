using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ERS.Models
{
    [DataContract] 
    public class PassengerContactDetails
    {
        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string Nationality { get; set; }

        [DataMember]
        public int TotalNumberOfNationality { get; set; }

        [DataMember]
        public string PaxType { get; set; }

        [DataMember]
        public int TotalNumberADT { get; set; }

        [DataMember]
        public int TotalNumberCHD { get; set; }

        [DataMember]
        public int FlightStatus { get; set; }

    }
}
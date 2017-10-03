using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ERS.Models
{
    [DataContract] 
    public class PassengerManifest
    {
        [DataMember]
        public string EmployeeNumber { get; set; }

        [DataMember]
        public int TotalPax { get; set; }

        [DataMember]
        public int TotalMale { get; set; }

        [DataMember]
        public int TotalFemale { get; set; }

        [DataMember]
        public int TotalChild { get; set; }

        [DataMember]
        public int TotalInfant { get; set; }

        [DataMember]
        public int TotalCheckedinBags { get; set; }

        [DataMember]
        public string PassengerNameRecord { get; set; }

        [DataMember]
        public string SequenceNumber { get; set; }

        [DataMember]
        public string SeatNumber { get; set; }

        [DataMember]
        public int NoShowGuest { get; set; }

        [DataMember]
        public string PassengerContactNumber { get; set; }

        [DataMember]
        public DateTime Birthday { get; set; }

        [DataMember]
        public bool isSpecialHandling { get; set; }        

        [DataMember]
        public string Nationality { get; set; }

    }
}
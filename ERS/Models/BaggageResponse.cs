using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ERS.Models
{
    [DataContract] 
    public class CheckedBaggageDetail
    {
        [DataMember]
        public int NumberofCheckedBaggage { get; set; }

        [DataMember]
        public string PassengerName { get; set; }

        [DataMember]
        public string BagTagNumber { get; set; }

    }
}
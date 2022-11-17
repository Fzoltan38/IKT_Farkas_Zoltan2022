using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf_LoginRegistration
{
    public class User
    {
        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string uname { get; set; }

        [DataMember]
        public string email { get; set; }

        [DataMember]
        public string pwd { get; set; }

        [DataMember]
        public string fullname { get; set; }

        [DataMember]
        public int active { get; set; }

        [DataMember]
        public int rank { get; set; }

        [DataMember]
        public int ban { get; set; }

        [DataMember]
        public string reg_time { get; set; }

        [DataMember]
        public string log_time { get; set; }

    }
}
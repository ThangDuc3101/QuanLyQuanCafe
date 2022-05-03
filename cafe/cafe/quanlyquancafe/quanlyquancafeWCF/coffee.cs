using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace quanlyquancafeWCF
{
   [DataContract]
    public class coffee
    {
        [DataMember]
        public int id { set; get; }
        [DataMember]
        public string name { set; get; }
        [DataMember]
        public string tinhTrang { set; get; }
        [DataMember]
        public decimal price { set; get; }
        [DataMember]
        public int numberOrder { set; get; }
    }
}

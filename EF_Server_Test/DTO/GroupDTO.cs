using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EF_Server_Test.DTO
{
    [DataContract]
    public class GroupDTO
    {
        [DataMember]
        public int Id { get; protected set; }

        [DataMember]
        public string Name { get; set; }
    }
}

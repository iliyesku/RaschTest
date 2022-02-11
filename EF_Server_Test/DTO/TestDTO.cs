using System.Runtime.Serialization;

namespace EF_Server_Test.DTO
{
    [DataContract]
    public class TestDTO
    {
        [DataMember]
        public int Id { get; protected set; }
        
        [DataMember]
        public string Name { get; set; }
    }
}

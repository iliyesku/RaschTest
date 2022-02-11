using System.Runtime.Serialization;

namespace EF_Server_Test.DTO
{
    [DataContract]
    public class StudentSkillDTO
    {
        [DataMember]
        public int Id { get; protected set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public double Skill { get; set; }
    }
}
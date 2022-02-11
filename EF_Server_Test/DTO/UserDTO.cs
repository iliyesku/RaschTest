using System.Runtime.Serialization;

namespace EF_Server_Test.DTO
{
    public enum UserRole
    { 
        Student, 
        Admin 
    }

    [DataContract]
    public class UserDTO
    {
        [DataMember]
        public int Id { get; protected set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public UserRole Role { get; set; }
    }
}
using System.Runtime.Serialization;

namespace EF_Server_Test.DTO
{
    [DataContract]
    public class QuestionDTO
    {
        [DataMember]
        public int Id { get; protected set; }

        [DataMember]
        public string Text { get; set; }
       
        [DataMember]
        public string CorrectAnswer { get; set; }
    }
}
using System.Runtime.Serialization;

namespace EF_Server_Test.DTO
{
    [DataContract]
    public class AnswerDTO
    {
        [DataMember]
        public int AnswerId { get; set; }

        [DataMember]
        public int QuestionId { get; set; }

        [DataMember]
        public bool IsCorrect { get; set; }
    }
}
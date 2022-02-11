using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EF_Server_Test.DTO
{
    public enum AnswerState
    {
        Unanswered,
        Correct,
        Incorrect
    }

    [DataContract]
    public class StudentQuestionDTO
    {
        [DataMember]
        public int Id { get; protected set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public AnswerState State { get; set; }

        public AnswerState AnswerState
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Server_Test.Model
{
    public class Question
    {
        protected Question()
        {
        }

        public Question(Test test)
        {
            this.Test = test;
        }

        public virtual int Id { get; protected set; }

        public virtual string Text { get; set; }

        public virtual string CorrectAnswer { get; set; }

        public virtual Test Test { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Server_Test.Model
{
    public class Answer
    {
        public virtual int Id { get; protected set; }

        public virtual User Student { get; set; }

        public virtual Question Question { get; set; }

        public virtual bool IsCorrect { get; set; }
    }
}

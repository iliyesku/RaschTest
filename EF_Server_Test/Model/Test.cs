using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Iesi.Collections.Generic;

namespace EF_Server_Test.Model
{
    public class Test
    {
        #region C-tor
        public Test()
        {
            this.Questions = new HashedSet<Question>();
        }
        #endregion

        public virtual int Id { get; protected set; }

        public virtual string Name { get; set; }

        public virtual ISet<Question> Questions { get; protected set; }
    }
}

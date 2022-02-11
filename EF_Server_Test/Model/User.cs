using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Server_Test.DTO;

namespace EF_Server_Test.Model
{
    public class User
    {
        public virtual int Id { get; protected set; }

        public virtual string Username { get; set; }

        public virtual string Password { get; set; }

        public virtual UserRole Role { get; set; }

        public virtual EF_Server_Test.DTO.UserRole UserRole
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

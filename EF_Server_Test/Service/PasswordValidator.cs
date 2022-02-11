using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using NHibernate;
using EF_Server_Test.Model;
using EF_Server_Test.Infrastructure;
using System.ServiceModel;

namespace EF_Server_Test.Service
{
    class PasswordValidator :  UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            //

            Console.WriteLine("Trying to auth user [" + userName + "]");

            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    User u = session.QueryOver<User>().Where(x => x.Username == userName).SingleOrDefault();

                    if (u == null || u.Password != password)
                    {
                        throw new FaultException("Unknown Username or Incorrect Password");
                    }

                    tx.Commit();
                }
            }
        }
    }
}

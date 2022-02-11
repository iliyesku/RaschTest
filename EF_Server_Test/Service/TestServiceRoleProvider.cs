using System;
using System.Linq;
using System.Web.Security;
using EF_Server_Test.Infrastructure;
using EF_Server_Test.Model;
using NHibernate;

namespace EF_Server_Test.Service
{
    class TestServiceRoleProvider : RoleProvider
    {
        public override string[] GetRolesForUser(string username)
        {
            try
            {
                User u = null;

                using (ISession session = Bootstrapper.Factory.OpenSession())
                {
                    using (ITransaction tx = session.BeginTransaction())
                    {
                        u = session.QueryOver<User>().Where(x => x.Username == username).SingleOrDefault();
                        tx.Commit();
                    }
                }

                if (u.Role == DTO.UserRole.Admin)
                {
                    return new string[] { "administrator", "student" };
                }
                else
                {
                    return new string[] { "student" };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return new string[] { };
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            return GetRolesForUser(username).Contains(roleName);
        }

        #region Not Implemented
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

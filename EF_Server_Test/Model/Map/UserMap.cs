using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace EF_Server_Test.Model.Map
{
    class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Username);
            Map(x => x.Password);
            Map(x => x.Role).CustomType<DTO.UserRole>();
        }
    }
}

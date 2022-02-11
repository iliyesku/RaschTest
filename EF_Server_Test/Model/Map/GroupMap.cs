using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace EF_Server_Test.Model.Map
{
    class GroupMap : ClassMap<Group>
    {
        public GroupMap()
        {
            Table("Groups");
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Name);
        }
    }
}

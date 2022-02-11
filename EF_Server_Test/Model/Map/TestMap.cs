using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace EF_Server_Test.Model.Map
{
    class TestMap : ClassMap<Test>
    {
        public TestMap()
        {
            Table("Tests");
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Name);
            HasMany(x => x.Questions)
                //.Inverse()
                .AsSet()
                .KeyColumn("TestId");
        }
    }
}

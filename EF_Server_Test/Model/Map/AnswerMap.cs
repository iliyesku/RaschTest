using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace EF_Server_Test.Model.Map
{
    class AnswerMap : ClassMap<Answer>
    {
        public AnswerMap()
        {
            Table("Answers");
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.IsCorrect);
            References(x => x.Question);
            References(x => x.Student);
        }
    }
}

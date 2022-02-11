using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace EF_Server_Test.Model.Map
{
    class QuestionMap : ClassMap<Question>
    {
        public QuestionMap()
        {
            Table("Questions");
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Text);
            Map(x => x.CorrectAnswer);
            References(x => x.Test);
        }
    }
}

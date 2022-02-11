using AutoMapper;
using EF_Server_Test.DTO;
using EF_Server_Test.Model;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace EF_Server_Test.Infrastructure
{
    public static class Bootstrapper
    {
        public static ISessionFactory Factory { get; private set; }

        public static void Initialize()
        {
            Mapper.CreateMap<User, UserDTO>();
            Mapper.CreateMap<UserDTO, User>();

            Mapper.CreateMap<Test, TestDTO>();
            Mapper.CreateMap<TestDTO, Test>();

            Mapper.CreateMap<Question, QuestionDTO>();
            Mapper.CreateMap<QuestionDTO, Question>();

            Mapper.CreateMap<Question, StudentQuestionDTO>();
            Mapper.CreateMap<StudentQuestionDTO, Question>();

            Mapper.CreateMap<User, StudentSkillDTO>();
            Mapper.CreateMap<StudentSkillDTO, User>();

            //Mapper.CreateMap<Answer, AnswerDTO>();
            //Mapper.CreateMap<AnswerDTO, Answer>();

            Factory = ConfigureNHibernate(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=Test3;Integrated Security=True;Pooling=False");
        }

        private static ISessionFactory ConfigureNHibernate(string connectionString)
        {
            return Fluently.Configure()
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<User>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Test>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Answer>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Question>())
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connectionString))
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                .BuildSessionFactory();
        }
    }
            
}

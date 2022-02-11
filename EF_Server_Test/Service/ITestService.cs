using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Server_Test.DTO;
using System.ServiceModel;

namespace EF_Server_Test.Service
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        UserRole GetRole();

        // Пользователи.
        [OperationContract]
        bool AddUser(UserDTO user);

        [OperationContract]
        void DeleteUser(int userId);

        [OperationContract]
        void UpdateUser(UserDTO user);

        [OperationContract]
        List<UserDTO> GetUsers();

        [OperationContract]
        List<StudentSkillDTO> GetStudents();

        // Тесты.
        [OperationContract]
        bool AddTest(TestDTO test);

        [OperationContract]
        void DeleteTest(int testId);

        [OperationContract]
        void UpdateTest(TestDTO test);

        [OperationContract]
        List<TestDTO> GetTests();

        // Вопросы.
        [OperationContract]
        void AddQuestion(int testId, QuestionDTO question);

        [OperationContract]
        void DeleteQuestion(int questionId);

        [OperationContract]
        void UpdateQuestion(QuestionDTO question);

        [OperationContract]
        List<QuestionDTO> GetQuestions(int testId);

        [OperationContract]
        List<StudentQuestionDTO> StudentGetQuestions(int testId);

        [OperationContract]
        AnswerState AnswerQuestion(int questionId, string answer);

        [OperationContract]
        bool CalculateResults(IList<int> testIdList, out List<StudentSkillDTO> studentSkillList);

        [OperationContract]
        List<AnswerDTO> getAnswers(int studentId, int testId);
    }
}

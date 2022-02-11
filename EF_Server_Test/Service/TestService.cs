using AutoMapper;
using EF_Server_Test.DTO;
using EF_Server_Test.Infrastructure;
using EF_Server_Test.Model;
using NHibernate;
using NLog;
using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.ServiceModel;
using System.Threading;
using System.Linq;

namespace EF_Server_Test.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] 
    public class TestService : ITestService
    {
        #region Static fields
        private Logger log = LogManager.GetCurrentClassLogger();
        #endregion

        #region ITestService
        public UserRole GetRole()
        {
            log.Debug("Getting role for user " + Thread.CurrentPrincipal.Identity.Name);

            if (Thread.CurrentPrincipal.IsInRole("administrator"))
            {
                return UserRole.Admin;
            }
            else
            {
                return UserRole.Student;
            }      
        }

        // Пользователи
        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public bool AddUser(UserDTO user)
        {
            User u = Mapper.Map<User>(user);

            // Validate.
            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        User tmp = session.QueryOver<User>()
                            .Where(x => x.Username == user.Username)
                            .SingleOrDefault();

                        if (tmp == null)
                        {
                            session.Save(u);
                            tx.Commit();
                        }
                        else
                        {
                            tx.Commit();
                            return false;
                        }                      
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in AddUser. " + ex);
                        throw new FaultException("AddUser failed.");
                    }
                }
            }

            return true;
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public void DeleteUser(int userId)
        {
            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(session.Load<User>(userId));
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in DeleteUser. " + ex);
                        throw new FaultException("DeleteUser failed.");
                    }
                }
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public void UpdateUser(UserDTO user)
        {
            User u = Mapper.Map<User>(user);

            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        session.SaveOrUpdate(u);
                        tx.Commit();
                    }

                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in UpdateUser. " + ex);
                        throw new FaultException("UpdateUser failed.");
                    }
                }
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public List<UserDTO> GetUsers()
        {      
            List<UserDTO> result = new List<UserDTO>();

            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        foreach (var user in session.QueryOver<User>().List())
                        {
                            result.Add(Mapper.Map<UserDTO>(user));
                        }

                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in GetUsers. " + ex);
                        throw new FaultException("GetUsers failed.");
                    }
                }
            }    

            return result;
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public List<StudentSkillDTO> GetStudents()
        {
            List<StudentSkillDTO> result = new List<StudentSkillDTO>();

            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        foreach (var user in session.QueryOver<User>()
                            .Where(x => x.Role == UserRole.Student)
                            .List())
                        result.Add(Mapper.Map<StudentSkillDTO>(user));

                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in GetStudents. " + ex);
                        throw new FaultException("GetStudents failed.");
                    }
                }
            }
            return result;
        }

        // Тесты
        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public bool AddTest(TestDTO test)
        {
            //throw new NotImplementedException();
            Test t = Mapper.Map<Test>(test);

            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        Test tmp = session.QueryOver<Test>()
                            .Where(x => x.Name == test.Name)
                            .SingleOrDefault();

                        if (tmp == null)
                        {
                            session.Save(t);
                            tx.Commit();
                        }
                        else
                        {
                            tx.Commit();
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in AddTest. " + ex);
                        throw new FaultException("AddTest failed.");
                    }
                }
            }

            return true;
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public void DeleteTest(int testId)
        {
            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(session.Load<Test>(testId));
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in DeleteTest. " + ex);
                        throw new FaultException("DeleteTest failed.");
                    }
                }
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public void UpdateTest(TestDTO test)
        {
            Test t = Mapper.Map<Test>(test);

            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        session.SaveOrUpdate(t);
                        tx.Commit();
                    }

                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in UpdateTest. " + ex);
                        throw new FaultException("UpdateTest failed.");
                    }
                }
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "student")]
        public List<TestDTO> GetTests()
        {
            List<TestDTO> result = new List<TestDTO>();

            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        foreach (var test in session.QueryOver<Test>().List())
                        {
                            result.Add(Mapper.Map<TestDTO>(test));
                        }
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in GetTests. " + ex);
                        throw new FaultException("GetTests failed.");
                    }
                }
            }     
            return result;
        }

        // Вопросы
        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public void AddQuestion(int testId, QuestionDTO question)
        {
            Question q = Mapper.Map<Question>(question);

            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        q.Test = session.Load<Test>(testId);
                        Test t = session.Load<Test>(testId);
                        t.Questions.Add(q);
                        session.Save(q);
                        session.Save(t);
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in AddQuestion. " + ex);
                        throw new FaultException("AddQuestion failed.");
                    }
                }
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public void DeleteQuestion(int questionId)
        {
            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(session.Load<Question>(questionId));
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in DeleteQuestion. " + ex);
                        throw new FaultException("DeleteQuestion failed.");
                    }
                }
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public void UpdateQuestion(QuestionDTO question)
        {
            //Question q = Mapper.Map<Question>(question);

            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        Question q = session.Load<Question>(question.Id);
                        q.Text = question.Text;
                        q.CorrectAnswer = question.CorrectAnswer;
                        session.Update(q);
                        tx.Commit();
                    }

                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in UpdateQuestion. " + ex);
                        throw new FaultException("UpdateQuestion failed.");
                    }
                }
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "student")]
        public List<StudentQuestionDTO> StudentGetQuestions(int testId)
        {
            List<StudentQuestionDTO> result = new List<StudentQuestionDTO>();

            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        foreach (var question in session.Load<Test>(testId).Questions)
                        {
                            StudentQuestionDTO sqdto = Mapper.Map<StudentQuestionDTO>(question);

                            Answer a = session.QueryOver<Answer>()
                                .Where(x => x.Question.Id == sqdto.Id)
                                .JoinQueryOver(x => x.Student)
                                .Where(x => x.Username == Thread.CurrentPrincipal.Identity.Name)
                                .SingleOrDefault();

                            if (a == null)
                                sqdto.State = AnswerState.Unanswered;
                            else if (a.IsCorrect)
                                sqdto.State = AnswerState.Correct;
                            else
                                sqdto.State = AnswerState.Incorrect;

                            result.Add(sqdto);
                        }

                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in StudentGetQuestions. " + ex);
                        throw new FaultException("StudentGetQuestions failed.");
                    }
                }
            }
                
            return result;
        }

        // Студент
        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public List<QuestionDTO> GetQuestions(int testId)
        {
            List<QuestionDTO> result = new List<QuestionDTO>();

            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        foreach (var question in session.Load<Test>(testId).Questions)
                        {
                            QuestionDTO qdto = Mapper.Map<QuestionDTO>(question);
                            result.Add(qdto);
                        }

                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in GetQuestions. " + ex);
                        throw new FaultException("GetQuestions failed.");
                    }
                }
            }
            return result;
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "student")]
        public AnswerState AnswerQuestion(int questionId, string answer)
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            Answer a = null;

            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        a = session.QueryOver<Answer>()
                            .Where(x => x.Question.Id == questionId)
                            .JoinQueryOver(x => x.Student)
                            .Where(x => x.Username == username)
                            .SingleOrDefault();

                        if (a != null)
                            log.Info(username + " попытался читерить!");
                        else
                        {
                            Question q = session.QueryOver<Question>()
                                .Where(x => x.Id == questionId)
                                .SingleOrDefault();

                            User s = session.QueryOver<User>()
                                .Where(x => x.Username == username)
                                .SingleOrDefault();

                            a = new Answer();
                            a.Student = s;
                            a.Question = q;
                            a.IsCorrect = (q.CorrectAnswer == answer);
                            session.Save(a);
                        }

                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in AnswerQuestion. " + ex);
                        throw new FaultException("AnswerQuestion failed.");
                    }
                }
            }
            return a.IsCorrect ? AnswerState.Correct : AnswerState.Incorrect;
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public bool CalculateResults(IList<int> testIdList, out List<StudentSkillDTO> studentSkillList)
        {
            studentSkillList = new List<StudentSkillDTO>();
            
            try
            {
                Dictionary<int, User> studentMap = new Dictionary<int, User>();
                //Dictionary<StudentSkillDTO, double> intermediate = new Dictionary<StudentSkillDTO, double>();
                IList<User> students;
                
                using (ISession session = Bootstrapper.Factory.OpenSession())
                {
                    using (ITransaction tx = session.BeginTransaction())
                    {
                        students = session.QueryOver<User>()
                            .Where(x => x.Role == UserRole.Student)
                            .List();

                        int sNo = 0;
                        foreach (User s in students)
                        {
                            studentMap.Add(sNo, s);
                            sNo++;
                        }
                        tx.Commit();
                    }
                }

                double[] studentSkills = new double[students.Count];

                foreach (int testNo in testIdList)
                {
                    IList<Question> questions;
                    IList<Answer> answers;

                    using (ISession session = Bootstrapper.Factory.OpenSession())
                    {
                        using (ITransaction tx = session.BeginTransaction())
                        {
                            questions = session.QueryOver<Question>()
                                .Where(x => x.Test.Id == testNo)
                                .List();

                            answers = session.QueryOver<Answer>()
                                .JoinQueryOver(x => x.Question)
                                .Where(x => x.Test.Id == testNo)
                                .List();

                            if (answers.Count != questions.Count * students.Count)
                            {
                                tx.Commit();
                                return false;
                            }

                            tx.Commit();
                        }
                    }

                    //Dictionary<int, Question> questionMap = new Dictionary<int, Question>();

                    int NPeople = students.Count;
                    int MQuestions = questions.Count;

                    double[] QuestionPts = new double[MQuestions];
                    double[] PeoplePts = new double[NPeople];

                    int l = 0;
                    foreach (var question in questions)
                    {
                        //questionMap.Add(l, question);

                        QuestionPts[l] = answers
                           .Where(x => x.Question.Id == question.Id && x.IsCorrect)
                           .Count();
                        l++;
                    }

                    l = 0;
                    foreach (var student in students)
                    {
                        PeoplePts[l] = answers
                           .Where(x => x.IsCorrect && x.Student.Id == student.Id && x.Question.Test.Id == testNo)
                           .Count();
                        l++;
                    }

                    double[] CSkills = new double[NPeople]; //studentSkills<studen\tId, studentSkill>
                    double[] CDifficulties = new double[MQuestions]; //questionDifficulties<questionId, questionDiff>
                    double[] CPeoplePts = new double[NPeople]; //
                    double[] CQuestionPts = new double[MQuestions]; //

                    for (double specifier = 2; specifier > 0.001; specifier /= 2)
                    {
                        for (int IMan = 0; IMan < NPeople; IMan++)
                        {
                            for (int JQuest = 0; JQuest < MQuestions; JQuest++)
                            {
                                CQuestionPts[JQuest] = 0;
                                for (int i = 0; i < NPeople; i++)
                                    CQuestionPts[JQuest] += 1 / (1 + Math.Exp(CDifficulties[JQuest] - CSkills[i]));

                                CPeoplePts[IMan] = 0;

                                for (int j = 0; j < MQuestions; j++)
                                    CPeoplePts[IMan] += 1 / (1 + Math.Exp(CDifficulties[j] - CSkills[IMan]));

                                if (CQuestionPts[JQuest] > QuestionPts[JQuest])
                                    CDifficulties[JQuest] += specifier;
                                else
                                    CDifficulties[JQuest] -= specifier;

                                if (CPeoplePts[IMan] > PeoplePts[IMan])
                                    CSkills[IMan] -= specifier;
                                else
                                    CSkills[IMan] += specifier;
                            }
                        }
                    }

                    double CAverageSkill = 0;
                    for (int i = 0; i < NPeople; i++)
                        CAverageSkill += CSkills[i] / NPeople;

                    for (int i = 0; i < NPeople; i++)
                    {
                        studentSkills[i] += CSkills[i] - CAverageSkill;
                    }
                }

                for (int i = 0; i < students.Count; i++)
                {
                    StudentSkillDTO ss = Mapper.Map<StudentSkillDTO>(studentMap[i]);
                    ss.Skill = studentSkills[i];
                    studentSkillList.Add(ss);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return true;
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "administrator")]
        public List<AnswerDTO> getAnswers(int studentId, int testId)
        {
            List<AnswerDTO> answerList = new List<AnswerDTO>();
            using (ISession session = Bootstrapper.Factory.OpenSession())
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        foreach (Answer a in session.QueryOver<Answer>()
                            .Where(x => x.Student.Id == studentId)
                            .JoinQueryOver(x => x.Question)//.Test)
                            .JoinQueryOver(x => x.Test)
                            .Where(x => x.Id == testId)
                            .List())
                        {
                            AnswerDTO aMapped = new AnswerDTO();
                            aMapped.AnswerId = a.Id;
                            aMapped.QuestionId = a.Question.Id;
                            aMapped.IsCorrect = a.IsCorrect;
                            answerList.Add(aMapped);
                        }
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        log.Error("Exception in GetAnswers. " + ex);
                        throw new FaultException("GetAnswers failed.");
                    }
                }
            }
            //AnswerDTO answer = new AnswerDTO;
            //AnswerDTO b = new AnswerDTO();
            return answerList;
        }

        #endregion
    }
}
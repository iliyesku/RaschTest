using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference1;

namespace Client
{
    public partial class AdminForm : Form
    {
        TestServiceClient client;

        public AdminForm(TestServiceClient client)
        {
            InitializeComponent();

            this.client = client;
            this.userDtoBindingSource.DataSource = client.GetUsers();
            this.testDtoBindingSource.DataSource = client.GetTests();
            TestDTO t = testsLb.SelectedItem as TestDTO;
            if (t != null)
                this.questionDtoBindingSource.DataSource = client.GetQuestions(t.Id);
            ((ListBox)checkedListBox1).DataSource = testDtoBindingSource;
            ((ListBox)checkedListBox1).DisplayMember = "Name";
            studentDtoBindingSource1.DataSource = client.GetStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dictionary<UserDTO, double> q;

            //if (client.CalculateResults( out q, 1))
            //{
            //    StringBuilder sb = new StringBuilder();

            //    foreach (var kvp in q)
            //    {
            //        sb.Append(kvp.Key.Username + " " + kvp.Value.ToString());
            //    }

            //    MessageBox.Show(sb.ToString());
            //}
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            using (AddUserForm f = new AddUserForm(this.client))
            {
                f.ShowDialog();
            }
            userDtoBindingSource.DataSource = client.GetUsers();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserDTO user = userDtoBindingSource.Current as UserDTO;
                this.client.DeleteUser(user.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Переделать!
            userDtoBindingSource.DataSource = this.client.GetUsers();
            //!!!
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            UserDTO user = userDtoBindingSource.Current as UserDTO;
            using (UpdateUserForm f = new UpdateUserForm(this.client, user))
            {
                f.ShowDialog();
            }
            //??
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            using (AddTestForm f = new AddTestForm(this.client))
            {
                f.ShowDialog();
            }
            testDtoBindingSource.DataSource = client.GetTests();
        }

        private void deleteTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                TestDTO test = testDtoBindingSource.Current as TestDTO;
                this.client.DeleteTest(test.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Переделать!
            testDtoBindingSource.DataSource = this.client.GetTests();
            //!!!
        }

        private void editTestButton_Click(object sender, EventArgs e)
        {
            TestDTO test = testDtoBindingSource.Current as TestDTO;
            using (UpdateTestForm f = new UpdateTestForm(this.client, test))
            {
                f.ShowDialog();
            }
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            QuestionDTO q = new QuestionDTO();
            q.Text = questionTextTb.Text;
            q.CorrectAnswer = rightAnswerTb.Text;
            TestDTO t = testDtoBindingSource.Current as TestDTO;
            client.AddQuestion(t.Id, q);
            questionDtoBindingSource.DataSource = this.client.GetQuestions(t.Id);
        }

        private void testsLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestDTO t = testsLb.SelectedItem as TestDTO;
            if (t != null)
                this.questionDtoBindingSource.DataSource = client.GetQuestions(t.Id);
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                QuestionDTO question = questionDtoBindingSource.Current as QuestionDTO;
                this.client.DeleteQuestion(question.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //Переделать!
            TestDTO t = testsLb.SelectedItem as TestDTO;
            if (t != null)
                this.questionDtoBindingSource.DataSource = client.GetQuestions(t.Id);
            //!!!
        }

        private void acceptQuestionChangeButton_Click(object sender, EventArgs e)
        {
            QuestionDTO q = questionDtoBindingSource.Current as QuestionDTO;
            q.Text = questionTextTb.Text;
            q.CorrectAnswer = rightAnswerTb.Text;
            client.UpdateQuestion(q);
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            QuestionDTO q = questionDtoBindingSource.Current as QuestionDTO;
            if (q != null)
            {
                questionTextTb.Text = q.Text;
                rightAnswerTb.Text = q.CorrectAnswer;
            }
            else
            {
                questionTextTb.ResetText();
                rightAnswerTb.ResetText();
            }
        }

        private void markAllLl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, true);
        }

        private void unmarkAllLl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
        }

        private void calculateLl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int[] testIdList = new int[checkedListBox1.CheckedItems.Count];

            //Dictionary<UserDTO, double> skillList = new Dictionary<UserDTO,double>();
            //foreach (UserDTO student in client.GetStudents())
            //    skillList.Add(student, 0);
            
            StudentSkillDTO[] temp = new StudentSkillDTO[studentDtoBindingSource1.Count];

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                testIdList[i] = (checkedListBox1.CheckedItems[i] as TestDTO).Id;
            }
                if (client.CalculateResults(out temp, testIdList))
                {

                    Array.Sort(temp, delegate(StudentSkillDTO x, StudentSkillDTO y) { return y.Skill.CompareTo(x.Skill); });
                    studentDtoBindingSource1.DataSource = temp;
                    //MessageBox.Show(temp.Length.ToString());
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при сложении баллов, проверьте, что все тесты пройдены полностью");
                }
        }

        private void clearQuestionLl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            questionTextTb.Clear();
            rightAnswerTb.Clear();
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                answerDtoBindingSource.DataSource = client.getAnswers((studentDtoBindingSource1.Current as StudentSkillDTO).Id, (testDtoBindingSource.Current as TestDTO).Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

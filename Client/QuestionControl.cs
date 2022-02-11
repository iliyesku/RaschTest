using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference1;

namespace Client
{
    public partial class QuestionControl : UserControl
    {
        #region Private fields
        private TestServiceClient client;
        private StudentQuestionDTO question;
        #endregion

        #region C-tor
        public QuestionControl(StudentQuestionDTO question, TestServiceClient client)
        {
            InitializeComponent();

            this.client = client;
            this.question = question;
            this.lQuestion.Text = question.Text;
            this.UpdateState(question.State);
        }
        #endregion

        #region Methods
        private void UpdateState(AnswerState state)
        {
            switch (state)
            {
                case AnswerState.Correct:
                    this.pictureBoxQuestionState.Image = Properties.Resources.CorrectAnswer;
                    this.llAnswer.Enabled = false;
                    break;
                case AnswerState.Incorrect:
                    this.pictureBoxQuestionState.Image = Properties.Resources.IncorrectAnswer;
                    this.llAnswer.Enabled = false;
                    break;
                case AnswerState.Unanswered:
                    this.llAnswer.Enabled = true;
                    break;
            }
        }

        private void AnswerClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbAnswer.Text))
                return;

            this.UpdateState(this.client.AnswerQuestion(this.question.Id, this.tbAnswer.Text));
        }
        #endregion
    }
}

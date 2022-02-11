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
    public partial class TestForm : Form
    {
        #region Private fields
        private TestServiceClient client;
        #endregion

        #region C-tor
        public TestForm(TestServiceClient client, TestDTO test)
        {
            InitializeComponent();

            this.Text = "Открыт тест: " + test.Name;
            this.client = client;
            //this.studentQuestionDTOBindingSource.DataSource = client.StudentGetQuestions(test.Id);

            foreach (var question in this.client.StudentGetQuestions(test.Id))
            {
               
                QuestionControl c = new QuestionControl(question, this.client);
                c.Dock = DockStyle.Top;
                this.panelQuestions.Controls.Add(c);
            }
        }
        #endregion
    }
}

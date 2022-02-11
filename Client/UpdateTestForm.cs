using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Client.ServiceReference1;

namespace Client
{
    public partial class UpdateTestForm : Form
    {
        private TestDTO test;
        private TestServiceClient client;

        public UpdateTestForm(TestServiceClient client, TestDTO test)
        {
            InitializeComponent();
            this.client = client;
            this.test = test;
        }

        private void updateTestButton_Click(object sender, EventArgs e)
        {

            if (testNameTb.Text == string.Empty)
            {
                MessageBox.Show("Введите название теста!");
                return;
            }
            this.test.Name = testNameTb.Text;
            this.client.UpdateTest(test);
            this.Close();
        }

        private void UpdateTestForm_Load(object sender, EventArgs e)
        {
            testNameTb.Text = this.test.Name;
        }
    }
}

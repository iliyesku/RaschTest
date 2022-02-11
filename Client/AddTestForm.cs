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
    public partial class AddTestForm : Form
    {
        private TestServiceClient client;
        private int testCount = 0;

        public AddTestForm(TestServiceClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            if (testNameTB.Text == string.Empty)
            {
                MessageBox.Show("Введите название теста!");
                return;
            }

            TestDTO t = new TestDTO();
            t.Name = testNameTB.Text;
            if (this.client.AddTest(t))
                testCount++;
            else
            {
                MessageBox.Show("Тест с таким названием уже существует!");
                return;
            }
            testCountLabel.Text = "Добавлено тестов: " + testCount.ToString();

            testNameTB.ResetText();
        }
    }
}

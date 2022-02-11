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
    public partial class StudentForm : Form
    {
        #region Private fields
        private TestServiceClient client;
        #endregion

        #region C-tor
        public StudentForm(TestServiceClient client)
        {
            InitializeComponent();

            this.client = client;
            this.testDTOBindingSource.DataSource = client.GetTests();
        }
        #endregion

        #region Methods
        private void OpenTestClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TestDTO test = this.testDTOBindingSource.Current as TestDTO;
            if (test == null)
                return;

            using (TestForm f = new TestForm(this.client, test))
            {
                f.ShowDialog();
            }
        }
        #endregion

        private void StudentFormClosed(object sender, FormClosedEventArgs e)
        {
            this.client.Close();
        }
    }
}

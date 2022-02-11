using Client.ServiceReference1;
using System;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
        #region Fields
        private TestServiceClient client;
        #endregion

        #region C-tor
        public LoginForm()
        {
            InitializeComponent();  
        }
        #endregion

        #region Methods
        private void LoginClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Login();
        }

        // Нормальное сообщение ошибки, нажатие ENTER = вход.
        private void Login()
        {
            if (string.IsNullOrEmpty(this.tbUserName.Text) || string.IsNullOrEmpty(this.tbPassword.Text))
                ;

            this.client = new TestServiceClient();
            this.client.ClientCredentials.UserName.UserName = this.tbUserName.Text;
            this.client.ClientCredentials.UserName.Password = this.tbPassword.Text;

            try
            {
                this.Visible = false;

                if (this.client.GetRole() == UserRole.Admin)
                {
                    using (AdminForm f = new AdminForm(this.client))
                    {
                        f.ShowDialog();
                    }
                }
                else
                {
                    using (StudentForm f = new StudentForm(this.client))
                    {
                        f.ShowDialog();
                    }
                }

                this.Visible = true;
            }
                finally{}
           // catch (Exception ex)
           // {
            //    MessageBox.Show(ex.Message);
           // }   
        }

        private void PasswordTbKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.Login();
        }
        #endregion 
    }
}

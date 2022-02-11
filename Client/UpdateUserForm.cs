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
    public partial class UpdateUserForm : Form
    {
        private UserDTO user;
        private TestServiceClient client;

        public UpdateUserForm(TestServiceClient client, UserDTO user)
        {
            InitializeComponent();
            this.client = client;
            this.user = user;
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            UserNameTb.Text = this.user.Username;
            if (this.user.Role == UserRole.Admin)
                UserGroupCb.SelectedIndex = 1;
            else
                UserGroupCb.SelectedIndex = 0;
            UserPassTb.Text = this.user.Password;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (UserNameTb.Text == string.Empty || UserGroupCb.SelectedItem == null || UserPassTb.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            this.user.Username = UserNameTb.Text;
            switch (UserGroupCb.SelectedIndex)
            {
                case 0:
                    user.Role = UserRole.Student;
                    break;
                case 1:
                    user.Role = UserRole.Admin;
                    break;
                default:
                    return;
            }
            this.user.Password = UserPassTb.Text;
            this.client.UpdateUser(user);
            this.Close();
        }
    }
}

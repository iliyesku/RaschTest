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
    public partial class AddUserForm : Form
    {
        private TestServiceClient client;
        private int userCount = 0;

        public AddUserForm(TestServiceClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (userNameTb.Text == string.Empty || userGroupCb.SelectedItem == null || userPassTb.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            
            UserDTO u = new UserDTO();
            u.Username = userNameTb.Text;
            switch (userGroupCb.SelectedItem.ToString())
            {
                case "Администраторы":
                    u.Role = UserRole.Admin;
                    break;
                case "Студенты":
                    u.Role = UserRole.Student;
                    break;
                default:
                    return;
            }
            u.Password = userPassTb.Text;
            if (this.client.AddUser(u))
                userCount++;
            else
            {
                MessageBox.Show("Пользователь с таким именем уже существует!");
                return;
            }
            userCountLbl.Text = "Добавлено пользователей: " + userCount.ToString();

            userNameTb.ResetText();
            userGroupCb.ResetText();
            userPassTb.ResetText();
        }
    }
}

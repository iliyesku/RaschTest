namespace Client
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.userNameTb = new System.Windows.Forms.TextBox();
            this.userPassTb = new System.Windows.Forms.TextBox();
            this.userGroupCb = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.userCountLbl = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 13);
            label1.TabIndex = 1;
            label1.Text = "Пользователь";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(41, 51);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 13);
            label2.TabIndex = 2;
            label2.Text = "Группа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(38, 87);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 13);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            // 
            // userNameTb
            // 
            this.userNameTb.Location = new System.Drawing.Point(89, 12);
            this.userNameTb.Name = "userNameTb";
            this.userNameTb.Size = new System.Drawing.Size(191, 20);
            this.userNameTb.TabIndex = 0;
            // 
            // userPassTb
            // 
            this.userPassTb.Location = new System.Drawing.Point(89, 84);
            this.userPassTb.Name = "userPassTb";
            this.userPassTb.Size = new System.Drawing.Size(191, 20);
            this.userPassTb.TabIndex = 5;
            // 
            // userGroupCb
            // 
            this.userGroupCb.FormattingEnabled = true;
            this.userGroupCb.Items.AddRange(new object[] {
            "Администраторы",
            "Студенты"});
            this.userGroupCb.Location = new System.Drawing.Point(89, 48);
            this.userGroupCb.Name = "userGroupCb";
            this.userGroupCb.Size = new System.Drawing.Size(191, 21);
            this.userGroupCb.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(109, 142);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // userCountLbl
            // 
            this.userCountLbl.AutoSize = true;
            this.userCountLbl.Location = new System.Drawing.Point(68, 117);
            this.userCountLbl.Name = "userCountLbl";
            this.userCountLbl.Size = new System.Drawing.Size(156, 13);
            this.userCountLbl.TabIndex = 8;
            this.userCountLbl.Text = "Добавлено пользователей: 0";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 177);
            this.Controls.Add(this.userCountLbl);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.userGroupCb);
            this.Controls.Add(this.userPassTb);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.userNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUserForm";
            this.Text = "Новый пользователь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTb;
        private System.Windows.Forms.TextBox userPassTb;
        private System.Windows.Forms.ComboBox userGroupCb;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label userCountLbl;
    }
}
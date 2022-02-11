namespace Client
{
    partial class UpdateUserForm
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
            this.UserNameTb = new System.Windows.Forms.TextBox();
            this.UserPassTb = new System.Windows.Forms.TextBox();
            this.UserGroupCb = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 13);
            label1.TabIndex = 3;
            label1.Text = "Пользователь";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(65, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 13);
            label2.TabIndex = 4;
            label2.Text = "Группа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(62, 87);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 13);
            label3.TabIndex = 5;
            label3.Text = "Пароль";
            // 
            // UserNameTb
            // 
            this.UserNameTb.Location = new System.Drawing.Point(113, 12);
            this.UserNameTb.Name = "UserNameTb";
            this.UserNameTb.Size = new System.Drawing.Size(167, 20);
            this.UserNameTb.TabIndex = 0;
            // 
            // UserPassTb
            // 
            this.UserPassTb.Location = new System.Drawing.Point(113, 84);
            this.UserPassTb.Name = "UserPassTb";
            this.UserPassTb.Size = new System.Drawing.Size(167, 20);
            this.UserPassTb.TabIndex = 1;
            // 
            // UserGroupCb
            // 
            this.UserGroupCb.FormattingEnabled = true;
            this.UserGroupCb.Items.AddRange(new object[] {
            "Студенты",
            "Администраторы"});
            this.UserGroupCb.Location = new System.Drawing.Point(113, 47);
            this.UserGroupCb.Name = "UserGroupCb";
            this.UserGroupCb.Size = new System.Drawing.Size(167, 21);
            this.UserGroupCb.TabIndex = 2;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(113, 133);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 177);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.UserGroupCb);
            this.Controls.Add(this.UserPassTb);
            this.Controls.Add(this.UserNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateUserForm";
            this.Text = "Редактирование записи";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTb;
        private System.Windows.Forms.TextBox UserPassTb;
        private System.Windows.Forms.ComboBox UserGroupCb;
        private System.Windows.Forms.Button UpdateButton;
    }
}
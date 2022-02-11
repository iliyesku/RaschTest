namespace Client
{
    partial class UpdateTestForm
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
            this.testNameTb = new System.Windows.Forms.TextBox();
            this.updateTestButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testNameTb
            // 
            this.testNameTb.Location = new System.Drawing.Point(106, 12);
            this.testNameTb.Name = "testNameTb";
            this.testNameTb.Size = new System.Drawing.Size(174, 20);
            this.testNameTb.TabIndex = 0;
            // 
            // updateTestButton
            // 
            this.updateTestButton.Location = new System.Drawing.Point(109, 55);
            this.updateTestButton.Name = "updateTestButton";
            this.updateTestButton.Size = new System.Drawing.Size(75, 23);
            this.updateTestButton.TabIndex = 1;
            this.updateTestButton.Text = "Обновить";
            this.updateTestButton.UseVisualStyleBackColor = true;
            this.updateTestButton.Click += new System.EventHandler(this.updateTestButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название теста";
            // 
            // UpdateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateTestButton);
            this.Controls.Add(this.testNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateTestForm";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.UpdateTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testNameTb;
        private System.Windows.Forms.Button updateTestButton;
        private System.Windows.Forms.Label label1;
    }
}
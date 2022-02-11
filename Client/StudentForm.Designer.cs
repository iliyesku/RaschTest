namespace Client
{
    partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            this.listBoxTests = new System.Windows.Forms.ListBox();
            this.testDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.llOpenTest = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 13);
            label1.TabIndex = 1;
            label1.Text = "Доступные тесты:";
            // 
            // listBoxTests
            // 
            this.listBoxTests.DataSource = this.testDTOBindingSource;
            this.listBoxTests.DisplayMember = "Name";
            this.listBoxTests.FormattingEnabled = true;
            this.listBoxTests.Location = new System.Drawing.Point(17, 25);
            this.listBoxTests.Name = "listBoxTests";
            this.listBoxTests.Size = new System.Drawing.Size(408, 368);
            this.listBoxTests.TabIndex = 0;
            // 
            // testDTOBindingSource
            // 
            this.testDTOBindingSource.DataSource = typeof(Client.ServiceReference1.TestDTO);
            // 
            // llOpenTest
            // 
            this.llOpenTest.AutoSize = true;
            this.llOpenTest.Location = new System.Drawing.Point(295, 415);
            this.llOpenTest.Name = "llOpenTest";
            this.llOpenTest.Size = new System.Drawing.Size(130, 13);
            this.llOpenTest.TabIndex = 2;
            this.llOpenTest.TabStop = true;
            this.llOpenTest.Text = "Пройти выбранный тест";
            this.llOpenTest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenTestClicked);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 437);
            this.Controls.Add(this.llOpenTest);
            this.Controls.Add(label1);
            this.Controls.Add(this.listBoxTests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.Text = "Тесты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.testDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTests;
        private System.Windows.Forms.BindingSource testDTOBindingSource;
        private System.Windows.Forms.LinkLabel llOpenTest;
    }
}
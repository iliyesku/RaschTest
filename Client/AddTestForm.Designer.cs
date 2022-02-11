namespace Client
{
    partial class AddTestForm
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
            this.testNameTB = new System.Windows.Forms.TextBox();
            this.addTestButton = new System.Windows.Forms.Button();
            this.testCountLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 13);
            label1.TabIndex = 1;
            label1.Text = "Название теста";
            // 
            // testNameTB
            // 
            this.testNameTB.Location = new System.Drawing.Point(106, 13);
            this.testNameTB.Name = "testNameTB";
            this.testNameTB.Size = new System.Drawing.Size(174, 20);
            this.testNameTB.TabIndex = 0;
            // 
            // addTestButton
            // 
            this.addTestButton.Location = new System.Drawing.Point(112, 83);
            this.addTestButton.Name = "addTestButton";
            this.addTestButton.Size = new System.Drawing.Size(75, 23);
            this.addTestButton.TabIndex = 2;
            this.addTestButton.Text = "Добавить";
            this.addTestButton.UseVisualStyleBackColor = true;
            this.addTestButton.Click += new System.EventHandler(this.addTestButton_Click);
            // 
            // testCountLabel
            // 
            this.testCountLabel.AutoSize = true;
            this.testCountLabel.Location = new System.Drawing.Point(90, 53);
            this.testCountLabel.Name = "testCountLabel";
            this.testCountLabel.Size = new System.Drawing.Size(113, 13);
            this.testCountLabel.TabIndex = 3;
            this.testCountLabel.Text = "Добавлено тестов: 0";
            // 
            // AddTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 128);
            this.Controls.Add(this.testCountLabel);
            this.Controls.Add(this.addTestButton);
            this.Controls.Add(label1);
            this.Controls.Add(this.testNameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTestForm";
            this.Text = "Новый тест";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testNameTB;
        private System.Windows.Forms.Button addTestButton;
        private System.Windows.Forms.Label testCountLabel;
    }
}
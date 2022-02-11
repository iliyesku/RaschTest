namespace Client
{
    partial class TestForm
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
            this.studentQuestionDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelQuestions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.studentQuestionDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentQuestionDTOBindingSource
            // 
            this.studentQuestionDTOBindingSource.DataSource = typeof(Client.ServiceReference1.StudentQuestionDTO);
            // 
            // panelQuestions
            // 
            this.panelQuestions.AutoScroll = true;
            this.panelQuestions.AutoSize = true;
            this.panelQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestions.Location = new System.Drawing.Point(0, 0);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(609, 587);
            this.panelQuestions.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 587);
            this.Controls.Add(this.panelQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TestForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.studentQuestionDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentQuestionDTOBindingSource;
        private System.Windows.Forms.Panel panelQuestions;
    }
}
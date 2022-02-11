namespace Client
{
    partial class QuestionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.tableLayoutPanelQuestion = new System.Windows.Forms.TableLayoutPanel();
            this.lQuestion = new System.Windows.Forms.Label();
            this.llAnswer = new System.Windows.Forms.LinkLabel();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.pictureBoxQuestionState = new System.Windows.Forms.PictureBox();
            this.panelQuestion.SuspendLayout();
            this.tableLayoutPanelQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionState)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuestion
            // 
            this.panelQuestion.AutoSize = true;
            this.panelQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.panelQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuestion.Controls.Add(this.tableLayoutPanelQuestion);
            this.panelQuestion.Location = new System.Drawing.Point(15, 16);
            this.panelQuestion.Margin = new System.Windows.Forms.Padding(15, 15, 35, 15);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(556, 68);
            this.panelQuestion.TabIndex = 0;
            // 
            // tableLayoutPanelQuestion
            // 
            this.tableLayoutPanelQuestion.AutoSize = true;
            this.tableLayoutPanelQuestion.ColumnCount = 2;
            this.tableLayoutPanelQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelQuestion.Controls.Add(this.lQuestion, 0, 0);
            this.tableLayoutPanelQuestion.Controls.Add(this.llAnswer, 1, 1);
            this.tableLayoutPanelQuestion.Controls.Add(this.tbAnswer, 0, 1);
            this.tableLayoutPanelQuestion.Controls.Add(this.pictureBoxQuestionState, 1, 0);
            this.tableLayoutPanelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelQuestion.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelQuestion.Name = "tableLayoutPanelQuestion";
            this.tableLayoutPanelQuestion.RowCount = 2;
            this.tableLayoutPanelQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQuestion.Size = new System.Drawing.Size(554, 66);
            this.tableLayoutPanelQuestion.TabIndex = 15;
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Location = new System.Drawing.Point(5, 10);
            this.lQuestion.Margin = new System.Windows.Forms.Padding(5, 10, 3, 15);
            this.lQuestion.MaximumSize = new System.Drawing.Size(489, 0);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(0, 13);
            this.lQuestion.TabIndex = 14;
            // 
            // llAnswer
            // 
            this.llAnswer.AutoSize = true;
            this.llAnswer.Location = new System.Drawing.Point(497, 38);
            this.llAnswer.Name = "llAnswer";
            this.llAnswer.Size = new System.Drawing.Size(54, 13);
            this.llAnswer.TabIndex = 16;
            this.llAnswer.TabStop = true;
            this.llAnswer.Text = "Ответить";
            this.llAnswer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AnswerClicked);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAnswer.Location = new System.Drawing.Point(5, 41);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(5, 3, 3, 5);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(486, 20);
            this.tbAnswer.TabIndex = 18;
            // 
            // pictureBoxQuestionState
            // 
            this.pictureBoxQuestionState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxQuestionState.Location = new System.Drawing.Point(511, 6);
            this.pictureBoxQuestionState.Name = "pictureBoxQuestionState";
            this.pictureBoxQuestionState.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxQuestionState.TabIndex = 19;
            this.pictureBoxQuestionState.TabStop = false;
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panelQuestion);
            this.MaximumSize = new System.Drawing.Size(609, 0);
            this.MinimumSize = new System.Drawing.Size(609, 0);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(609, 99);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.tableLayoutPanelQuestion.ResumeLayout(false);
            this.tableLayoutPanelQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuestion;
        private System.Windows.Forms.PictureBox pictureBoxQuestionState;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.LinkLabel llAnswer;
        private System.Windows.Forms.Label lQuestion;
    }
}

namespace Client
{
    partial class AdminForm
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clearQuestionLl = new System.Windows.Forms.LinkLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rightAnswerTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.questionTextTb = new System.Windows.Forms.TextBox();
            this.testsLb = new System.Windows.Forms.ListBox();
            this.testDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.addTestButton = new System.Windows.Forms.ToolStripButton();
            this.editTestButton = new System.Windows.Forms.ToolStripButton();
            this.deleteTestButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addQuestionButton = new System.Windows.Forms.ToolStripButton();
            this.acceptQuestionChangeButton = new System.Windows.Forms.ToolStripButton();
            this.deleteQuestionButton = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addUserButton = new System.Windows.Forms.ToolStripButton();
            this.editUserButton = new System.Windows.Forms.ToolStripButton();
            this.deleteUserButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.QueryButton = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.answerDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studentDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.calculateLl = new System.Windows.Forms.LinkLabel();
            this.unmarkAllLl = new System.Windows.Forms.LinkLabel();
            this.markAllLl = new System.Windows.Forms.LinkLabel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCorrectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            label3 = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDtoBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDtoBindingSource1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(239, 16);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(145, 13);
            label3.TabIndex = 4;
            label3.Text = "Суммарный тестовый балл";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.clearQuestionLl);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.rightAnswerTb);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.questionTextTb);
            this.tabPage3.Controls.Add(this.testsLb);
            this.tabPage3.Controls.Add(this.toolStrip2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(933, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Тесты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // clearQuestionLl
            // 
            this.clearQuestionLl.AutoSize = true;
            this.clearQuestionLl.Location = new System.Drawing.Point(870, 235);
            this.clearQuestionLl.Name = "clearQuestionLl";
            this.clearQuestionLl.Size = new System.Drawing.Size(54, 13);
            this.clearQuestionLl.TabIndex = 10;
            this.clearQuestionLl.TabStop = true;
            this.clearQuestionLl.Text = "Очистить";
            this.clearQuestionLl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clearQuestionLl_LinkClicked);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.textDataGridViewTextBoxColumn,
            this.correctAnswerDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.questionDtoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(279, 31);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(651, 190);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Текст вопроса";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correctAnswerDataGridViewTextBoxColumn
            // 
            this.correctAnswerDataGridViewTextBoxColumn.DataPropertyName = "CorrectAnswer";
            this.correctAnswerDataGridViewTextBoxColumn.HeaderText = "Верный ответ";
            this.correctAnswerDataGridViewTextBoxColumn.Name = "correctAnswerDataGridViewTextBoxColumn";
            this.correctAnswerDataGridViewTextBoxColumn.ReadOnly = true;
            this.correctAnswerDataGridViewTextBoxColumn.Width = 150;
            // 
            // questionDtoBindingSource
            // 
            this.questionDtoBindingSource.DataSource = typeof(Client.ServiceReference1.QuestionDTO);
            // 
            // rightAnswerTb
            // 
            this.rightAnswerTb.Location = new System.Drawing.Point(279, 366);
            this.rightAnswerTb.Name = "rightAnswerTb";
            this.rightAnswerTb.Size = new System.Drawing.Size(646, 20);
            this.rightAnswerTb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Правильный ответ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текст вопроса";
            // 
            // questionTextTb
            // 
            this.questionTextTb.Location = new System.Drawing.Point(279, 251);
            this.questionTextTb.Multiline = true;
            this.questionTextTb.Name = "questionTextTb";
            this.questionTextTb.Size = new System.Drawing.Size(646, 85);
            this.questionTextTb.TabIndex = 4;
            // 
            // testsLb
            // 
            this.testsLb.DataSource = this.testDtoBindingSource;
            this.testsLb.DisplayMember = "Name";
            this.testsLb.FormattingEnabled = true;
            this.testsLb.Location = new System.Drawing.Point(8, 31);
            this.testsLb.Name = "testsLb";
            this.testsLb.Size = new System.Drawing.Size(265, 355);
            this.testsLb.TabIndex = 3;
            this.testsLb.ValueMember = "Name";
            this.testsLb.SelectedIndexChanged += new System.EventHandler(this.testsLb_SelectedIndexChanged);
            // 
            // testDtoBindingSource
            // 
            this.testDtoBindingSource.DataSource = typeof(Client.ServiceReference1.TestDTO);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTestButton,
            this.editTestButton,
            this.deleteTestButton,
            this.toolStripSeparator2,
            this.addQuestionButton,
            this.acceptQuestionChangeButton,
            this.deleteQuestionButton});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(927, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // addTestButton
            // 
            this.addTestButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTestButton.Image = global::Client.Properties.Resources.add;
            this.addTestButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTestButton.Name = "addTestButton";
            this.addTestButton.Size = new System.Drawing.Size(23, 22);
            this.addTestButton.Text = "Добавить тест";
            this.addTestButton.Click += new System.EventHandler(this.addTestButton_Click);
            // 
            // editTestButton
            // 
            this.editTestButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editTestButton.Image = global::Client.Properties.Resources.edit;
            this.editTestButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editTestButton.Name = "editTestButton";
            this.editTestButton.Size = new System.Drawing.Size(23, 22);
            this.editTestButton.Text = "Изменить название теста";
            this.editTestButton.Click += new System.EventHandler(this.editTestButton_Click);
            // 
            // deleteTestButton
            // 
            this.deleteTestButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTestButton.Image = global::Client.Properties.Resources.del;
            this.deleteTestButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTestButton.Name = "deleteTestButton";
            this.deleteTestButton.Size = new System.Drawing.Size(23, 22);
            this.deleteTestButton.Text = "Удалить тест";
            this.deleteTestButton.Click += new System.EventHandler(this.deleteTestButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(193, 0, 0, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addQuestionButton.Image = global::Client.Properties.Resources.add;
            this.addQuestionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(23, 22);
            this.addQuestionButton.Text = "Добавить вопрос";
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // acceptQuestionChangeButton
            // 
            this.acceptQuestionChangeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.acceptQuestionChangeButton.Image = global::Client.Properties.Resources.accept;
            this.acceptQuestionChangeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.acceptQuestionChangeButton.Name = "acceptQuestionChangeButton";
            this.acceptQuestionChangeButton.Size = new System.Drawing.Size(23, 22);
            this.acceptQuestionChangeButton.Text = "Применить исправления";
            this.acceptQuestionChangeButton.Click += new System.EventHandler(this.acceptQuestionChangeButton_Click);
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteQuestionButton.Image = global::Client.Properties.Resources.del;
            this.deleteQuestionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(23, 22);
            this.deleteQuestionButton.Text = "Удалить вопрос";
            this.deleteQuestionButton.Click += new System.EventHandler(this.deleteQuestionButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserButton,
            this.editUserButton,
            this.deleteUserButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(927, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addUserButton
            // 
            this.addUserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addUserButton.Image = global::Client.Properties.Resources.add;
            this.addUserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(23, 22);
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editUserButton.Image = global::Client.Properties.Resources.edit;
            this.editUserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(23, 22);
            this.editUserButton.Text = "Изменить данные о пользователе";
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteUserButton.Image = global::Client.Properties.Resources.del;
            this.deleteUserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(23, 22);
            this.deleteUserButton.Text = "Удалить";
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userDtoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(922, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Имя пользователя";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userDtoBindingSource
            // 
            this.userDtoBindingSource.DataSource = typeof(Client.ServiceReference1.UserDTO);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.QueryButton);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(933, 389);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Запросы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // QueryButton
            // 
            this.QueryButton.Location = new System.Drawing.Point(569, 6);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(75, 23);
            this.QueryButton.TabIndex = 5;
            this.QueryButton.Text = "Запрос";
            this.QueryButton.UseVisualStyleBackColor = true;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.answerIdDataGridViewTextBoxColumn,
            this.questionIdDataGridViewTextBoxColumn,
            this.isCorrectDataGridViewCheckBoxColumn});
            this.dataGridView3.DataSource = this.answerDtoBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(8, 35);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(917, 346);
            this.dataGridView3.TabIndex = 4;
            // 
            // answerDtoBindingSource
            // 
            this.answerDtoBindingSource.DataSource = typeof(Client.ServiceReference1.AnswerDTO);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.testDtoBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(353, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Тест";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Пользователь";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.studentDtoBindingSource1;
            this.comboBox1.DisplayMember = "Username";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Username";
            // 
            // studentDtoBindingSource1
            // 
            this.studentDtoBindingSource1.DataSource = typeof(Client.ServiceReference1.StudentSkillDTO);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.calculateLl);
            this.tabPage4.Controls.Add(label3);
            this.tabPage4.Controls.Add(this.unmarkAllLl);
            this.tabPage4.Controls.Add(this.markAllLl);
            this.tabPage4.Controls.Add(this.checkedListBox1);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(933, 389);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Результаты";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // calculateLl
            // 
            this.calculateLl.AutoSize = true;
            this.calculateLl.Location = new System.Drawing.Point(161, 16);
            this.calculateLl.Name = "calculateLl";
            this.calculateLl.Size = new System.Drawing.Size(72, 13);
            this.calculateLl.TabIndex = 5;
            this.calculateLl.TabStop = true;
            this.calculateLl.Text = "Пересчитать";
            this.calculateLl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.calculateLl_LinkClicked);
            // 
            // unmarkAllLl
            // 
            this.unmarkAllLl.AutoSize = true;
            this.unmarkAllLl.Location = new System.Drawing.Point(77, 16);
            this.unmarkAllLl.Name = "unmarkAllLl";
            this.unmarkAllLl.Size = new System.Drawing.Size(58, 13);
            this.unmarkAllLl.TabIndex = 3;
            this.unmarkAllLl.TabStop = true;
            this.unmarkAllLl.Text = "Снять все";
            this.unmarkAllLl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.unmarkAllLl_LinkClicked);
            // 
            // markAllLl
            // 
            this.markAllLl.AutoSize = true;
            this.markAllLl.Location = new System.Drawing.Point(5, 16);
            this.markAllLl.Name = "markAllLl";
            this.markAllLl.Size = new System.Drawing.Size(72, 13);
            this.markAllLl.TabIndex = 2;
            this.markAllLl.TabStop = true;
            this.markAllLl.Text = "Выбрать все";
            this.markAllLl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.markAllLl_LinkClicked);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(8, 32);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(228, 349);
            this.checkedListBox1.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.usernameDataGridViewTextBoxColumn1,
            this.skillDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.studentDtoBindingSource1;
            this.dataGridView4.Location = new System.Drawing.Point(242, 32);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(688, 349);
            this.dataGridView4.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "Имя пользователя";
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            this.usernameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // skillDataGridViewTextBoxColumn
            // 
            this.skillDataGridViewTextBoxColumn.DataPropertyName = "Skill";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.skillDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.skillDataGridViewTextBoxColumn.HeaderText = "Набранный балл";
            this.skillDataGridViewTextBoxColumn.Name = "skillDataGridViewTextBoxColumn";
            this.skillDataGridViewTextBoxColumn.ReadOnly = true;
            this.skillDataGridViewTextBoxColumn.Width = 150;
            // 
            // answerIdDataGridViewTextBoxColumn
            // 
            this.answerIdDataGridViewTextBoxColumn.DataPropertyName = "AnswerId";
            this.answerIdDataGridViewTextBoxColumn.HeaderText = "Номер записи";
            this.answerIdDataGridViewTextBoxColumn.Name = "answerIdDataGridViewTextBoxColumn";
            this.answerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.answerIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // questionIdDataGridViewTextBoxColumn
            // 
            this.questionIdDataGridViewTextBoxColumn.DataPropertyName = "QuestionId";
            this.questionIdDataGridViewTextBoxColumn.HeaderText = "Номер вопроса";
            this.questionIdDataGridViewTextBoxColumn.Name = "questionIdDataGridViewTextBoxColumn";
            this.questionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // isCorrectDataGridViewCheckBoxColumn
            // 
            this.isCorrectDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isCorrectDataGridViewCheckBoxColumn.DataPropertyName = "IsCorrect";
            this.isCorrectDataGridViewCheckBoxColumn.HeaderText = "Ответ";
            this.isCorrectDataGridViewCheckBoxColumn.Name = "isCorrectDataGridViewCheckBoxColumn";
            this.isCorrectDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 415);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Администратор";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDtoBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDtoBindingSource1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton addTestButton;
        private System.Windows.Forms.ToolStripButton editTestButton;
        private System.Windows.Forms.ToolStripButton deleteTestButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton addQuestionButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addUserButton;
        private System.Windows.Forms.ToolStripButton editUserButton;
        private System.Windows.Forms.ToolStripButton deleteUserButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource userDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox rightAnswerTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox questionTextTb;
        private System.Windows.Forms.ListBox testsLb;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripButton deleteQuestionButton;
        private System.Windows.Forms.BindingSource questionDtoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource testDtoBindingSource;
        private System.Windows.Forms.ToolStripButton acceptQuestionChangeButton;
        private System.Windows.Forms.LinkLabel unmarkAllLl;
        private System.Windows.Forms.LinkLabel markAllLl;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.LinkLabel calculateLl;
        private System.Windows.Forms.BindingSource studentDtoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel clearQuestionLl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource answerDtoBindingSource;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCorrectDataGridViewCheckBoxColumn;



    }
}
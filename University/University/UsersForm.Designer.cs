namespace University
{
    partial class UsersForm
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
            dataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            TokenAvailable = new DataGridViewTextBoxColumn();
            openButton = new Button();
            revokeButton = new Button();
            nextButton = new Button();
            prevButton = new Button();
            menuStrip = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            войтиToolStripMenuItem = new ToolStripMenuItem();
            информацияToolStripMenuItem = new ToolStripMenuItem();
            refreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Username, FullName, Role, TokenAvailable });
            dataGridView.Location = new Point(12, 56);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(776, 397);
            dataGridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Имя пользователя";
            Username.Name = "Username";
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "ФИО";
            FullName.Name = "FullName";
            // 
            // Role
            // 
            Role.DataPropertyName = "Role";
            Role.HeaderText = "Роль";
            Role.Name = "Role";
            // 
            // TokenAvailable
            // 
            TokenAvailable.DataPropertyName = "TokenAvailable";
            TokenAvailable.HeaderText = "Токен активен";
            TokenAvailable.Name = "TokenAvailable";
            // 
            // openButton
            // 
            openButton.Location = new Point(93, 27);
            openButton.Name = "openButton";
            openButton.Size = new Size(75, 23);
            openButton.TabIndex = 1;
            openButton.Text = "Открыть";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // revokeButton
            // 
            revokeButton.Location = new Point(174, 27);
            revokeButton.Name = "revokeButton";
            revokeButton.Size = new Size(134, 23);
            revokeButton.TabIndex = 2;
            revokeButton.Text = "Отозвать токен";
            revokeButton.UseVisualStyleBackColor = true;
            revokeButton.Click += revokeButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(120, 459);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(107, 23);
            nextButton.TabIndex = 3;
            nextButton.Text = "Следующие";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // prevButton
            // 
            prevButton.Location = new Point(12, 459);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(102, 23);
            prevButton.TabIndex = 4;
            prevButton.Text = "Предыдущие";
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += prevButton_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 5;
            menuStrip.Text = "Меню";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { войтиToolStripMenuItem, информацияToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // войтиToolStripMenuItem
            // 
            войтиToolStripMenuItem.Name = "войтиToolStripMenuItem";
            войтиToolStripMenuItem.Size = new Size(148, 22);
            войтиToolStripMenuItem.Text = "Войти";
            войтиToolStripMenuItem.Click += войтиToolStripMenuItem_Click;
            // 
            // информацияToolStripMenuItem
            // 
            информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            информацияToolStripMenuItem.Size = new Size(148, 22);
            информацияToolStripMenuItem.Text = "Информация";
            информацияToolStripMenuItem.Click += информацияToolStripMenuItem_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(12, 27);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 6;
            refreshButton.Text = "Обновить";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(refreshButton);
            Controls.Add(prevButton);
            Controls.Add(nextButton);
            Controls.Add(revokeButton);
            Controls.Add(openButton);
            Controls.Add(dataGridView);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пользователи";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button openButton;
        private Button revokeButton;
        private Button nextButton;
        private Button prevButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem менюToolStripMenuItem;
        private Button refreshButton;
        private ToolStripMenuItem войтиToolStripMenuItem;
        private ToolStripMenuItem информацияToolStripMenuItem;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn TokenAvailable;
    }
}
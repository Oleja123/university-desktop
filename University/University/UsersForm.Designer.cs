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
            dataGridView1 = new DataGridView();
            openButton = new Button();
            revokeButton = new Button();
            nextButton = new Button();
            prevButton = new Button();
            menuStrip = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 397);
            dataGridView1.TabIndex = 0;
            // 
            // openButton
            // 
            openButton.Location = new Point(12, 27);
            openButton.Name = "openButton";
            openButton.Size = new Size(75, 23);
            openButton.TabIndex = 1;
            openButton.Text = "Открыть";
            openButton.UseVisualStyleBackColor = true;
            // 
            // revokeButton
            // 
            revokeButton.Location = new Point(93, 27);
            revokeButton.Name = "revokeButton";
            revokeButton.Size = new Size(134, 23);
            revokeButton.TabIndex = 2;
            revokeButton.Text = "Отозвать токен";
            revokeButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(120, 459);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(107, 23);
            nextButton.TabIndex = 3;
            nextButton.Text = "Следующие";
            nextButton.UseVisualStyleBackColor = true;
            // 
            // prevButton
            // 
            prevButton.Location = new Point(12, 459);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(102, 23);
            prevButton.TabIndex = 4;
            prevButton.Text = "Предыдущие";
            prevButton.UseVisualStyleBackColor = true;
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
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выйтиToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(109, 22);
            выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(prevButton);
            Controls.Add(nextButton);
            Controls.Add(revokeButton);
            Controls.Add(openButton);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button openButton;
        private Button revokeButton;
        private Button nextButton;
        private Button prevButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
    }
}
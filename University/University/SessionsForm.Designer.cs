namespace University
{
    partial class SessionsForm
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
            closeSessionButton = new Button();
            usernameTextBox = new TextBox();
            refreshButton = new Button();
            closeSessionsButton = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // closeSessionButton
            // 
            closeSessionButton.Location = new Point(292, 13);
            closeSessionButton.Name = "closeSessionButton";
            closeSessionButton.Size = new Size(146, 23);
            closeSessionButton.TabIndex = 1;
            closeSessionButton.Text = "Закрыть сессию";
            closeSessionButton.UseVisualStyleBackColor = true;
            closeSessionButton.Click += closeSessionButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Enabled = false;
            usernameTextBox.Location = new Point(12, 13);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(157, 23);
            usernameTextBox.TabIndex = 2;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(175, 13);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(111, 23);
            refreshButton.TabIndex = 3;
            refreshButton.Text = "Обновить";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // closeSessionsButton
            // 
            closeSessionsButton.Location = new Point(444, 13);
            closeSessionsButton.Name = "closeSessionsButton";
            closeSessionsButton.Size = new Size(147, 23);
            closeSessionsButton.TabIndex = 4;
            closeSessionsButton.Text = "Закрыть все сессии";
            closeSessionsButton.UseVisualStyleBackColor = true;
            closeSessionsButton.Click += closeSessionsButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 42);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(776, 396);
            dataGridView.TabIndex = 5;
            // 
            // SessionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(closeSessionsButton);
            Controls.Add(refreshButton);
            Controls.Add(usernameTextBox);
            Controls.Add(closeSessionButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SessionsForm";
            Text = "SessionsForm";
            Load += SessionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button closeSessionButton;
        private TextBox usernameTextBox;
        private Button refreshButton;
        private Button closeSessionsButton;
        private DataGridView dataGridView;
    }
}
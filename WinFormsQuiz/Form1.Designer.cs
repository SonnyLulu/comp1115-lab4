namespace WinFormsQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnRestart;
            btnSubmit = new Button();
            lblMessage = new Label();
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            btnToggleTheme = new Button();
            lblTimeLimit = new Label();
            btnSetTimeLimit = new Button();
            txtTimeLimit = new TextBox();
            lblQuestionCount = new Label();
            txtQuestionCount = new TextBox();
            btnStartQuiz = new Button();
            btnRestart = new Button();
            SuspendLayout();
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(697, 520);
            btnRestart.Margin = new Padding(4);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(129, 35);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(534, 520);
            btnSubmit.Margin = new Padding(4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(129, 35);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 16F);
            lblMessage.Location = new Point(382, 269);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(368, 45);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Enter your answer below";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(79, 378);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(251, 24);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "What's the capital of Japan?";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(695, 378);
            txtAnswer.Margin = new Padding(4);
            txtAnswer.MaxLength = 11;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(606, 30);
            txtAnswer.TabIndex = 3;
            // 
            // btnToggleTheme
            // 
            btnToggleTheme.Location = new Point(858, 520);
            btnToggleTheme.Margin = new Padding(4);
            btnToggleTheme.Name = "btnToggleTheme";
            btnToggleTheme.Size = new Size(160, 35);
            btnToggleTheme.TabIndex = 5;
            btnToggleTheme.Text = "Toggle Theme";
            btnToggleTheme.UseVisualStyleBackColor = true;
            btnToggleTheme.Click += btnToggleTheme_Click;
            // 
            // lblTimeLimit
            // 
            lblTimeLimit.AutoSize = true;
            lblTimeLimit.Location = new Point(192, 54);
            lblTimeLimit.Name = "lblTimeLimit";
            lblTimeLimit.Size = new Size(100, 24);
            lblTimeLimit.TabIndex = 6;
            lblTimeLimit.Text = "Time Limit";
            // 
            // btnSetTimeLimit
            // 
            btnSetTimeLimit.Location = new Point(697, 55);
            btnSetTimeLimit.Name = "btnSetTimeLimit";
            btnSetTimeLimit.Size = new Size(112, 34);
            btnSetTimeLimit.TabIndex = 8;
            btnSetTimeLimit.Text = "set";
            btnSetTimeLimit.UseVisualStyleBackColor = true;
            btnSetTimeLimit.Click += btnSetTimeLimit_Click;
            // 
            // txtTimeLimit
            // 
            txtTimeLimit.Location = new Point(407, 55);
            txtTimeLimit.Name = "txtTimeLimit";
            txtTimeLimit.Size = new Size(150, 30);
            txtTimeLimit.TabIndex = 7;
            // 
            // lblQuestionCount
            // 
            lblQuestionCount.AutoSize = true;
            lblQuestionCount.Location = new Point(134, 123);
            lblQuestionCount.Name = "lblQuestionCount";
            lblQuestionCount.Size = new Size(196, 24);
            lblQuestionCount.TabIndex = 9;
            lblQuestionCount.Text = "Number of questions:";
            // 
            // txtQuestionCount
            // 
            txtQuestionCount.Location = new Point(407, 120);
            txtQuestionCount.Name = "txtQuestionCount";
            txtQuestionCount.Size = new Size(150, 30);
            txtQuestionCount.TabIndex = 10;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new Point(697, 120);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(112, 34);
            btnStartQuiz.TabIndex = 11;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 743);
            Controls.Add(btnStartQuiz);
            Controls.Add(txtQuestionCount);
            Controls.Add(lblQuestionCount);
            Controls.Add(txtTimeLimit);
            Controls.Add(btnSetTimeLimit);
            Controls.Add(lblTimeLimit);
            Controls.Add(btnToggleTheme);
            Controls.Add(btnRestart);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(lblMessage);
            Controls.Add(btnSubmit);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblMessage;
        private Label lblQuestion;
        private TextBox txtAnswer;
        private Button btnToggleTheme;
        private Button btnRestart;
        private Label lblTimeLimit;
        private Button btnSetTimeLimit;
        private TextBox txtTimeLimit;
        private Label lblQuestionCount;
        private TextBox txtQuestionCount;
        private Button btnStartQuiz;
    }
}

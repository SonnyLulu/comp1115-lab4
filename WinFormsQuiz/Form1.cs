namespace WinFormsQuiz
{
    public partial class Form1 : Form
    {
        // array of questions and answers
        string[,] questions = new string[6, 2];

        // track current question
        int currentQuestion = 0;

        // track correct answers
        int correct = 0;
        int questionCount = 0;
        bool isDark = false;

        // startup method that runs automatically when this form loads
        public Form1()
        {
            InitializeComponent();

            // call new LoadQuestions() method to populate quiz data
            LoadQuestions();
            ResetToStart();
        }

        /// <summary>
        /// populate question / answer array
        /// </summary>
        /// <author>Rich</author>
        private void LoadQuestions()
        {
            // populate array
            questions[0, 0] = "What's 5 times 3?";
            questions[0, 1] = "15";
            questions[1, 0] = "What colour is the sky?";
            questions[1, 1] = "Blue";
            questions[2, 0] = "Which came first, the chicken or the egg?";
            questions[2, 1] = "Chicken";
            questions[3, 0] = "What day is our class?";
            questions[3, 1] = "Monday";
            questions[4, 0] = "What language are we learning?";
            questions[4, 1] = "C#";
            questions[5, 0] = "What does UI stand for?";
            questions[5, 1] = "User Interface";

            // show 1st question on question label
            lblQuestion.Text = questions[0, 0];
        }

        /// <summary>
        /// give feedback on answer
        /// </summary>
        /// <param name="text">feedback to show on label</param>
        /// <param name="colour">text color for feedback label</param>
        private void ResetToStart()
        {
            currentQuestion = 0;
            correct = 0;
            questionCount = 0;
            btnSubmit.Enabled = false;
            txtAnswer.Enabled = false;
            txtAnswer.Text = "";
            txtQuestionCount.Text = "";
            lblQuestion.Text = $"Choose 1 to {questions.GetLength(0)} questions, then press the Start quiz";
            ShowFeedback("", Color.Black);

        }
      
        private void ShowFeedback(string text, Color colour)
        {
            lblMessage.Text = text;
            lblMessage.ForeColor = colour;
        }

        /// <summary>
        ///  calculate the percentage of correct answers
        /// </summary>
        /// <param name="correct">number of correct answers</param>
        /// <param name="total">total number of questions</param>
        /// <returns>percentage as a whole number</returns>
        private int GetPercentScore(int correct, int total)
        {
            if (total == 0)
            {
                return 0;
            }
            else
            {
                return correct * 100 / total;
            }
        }
        /// <summary>
        /// turn a percentage into a letter grade
        /// </summary>
        /// <param name="percent">percentage score</param>
        /// <returns>A, B, C , D or F</returns>
        private string GetGrade(int percent)
        {
            if (percent >= 90)
            {
                return "A";
            }
            else if (percent >= 80)
            {
                return "B";
            }
            else if (percent >= 70)
            {
                return "C";
            }
            else if (percent >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        /// <summary>
        /// user has finished
        /// </summary>
        private void FinishQuiz()
        {
            int percent = GetPercentScore(correct, questionCount);
            string grade = GetGrade(percent);

            btnSubmit.Enabled = false;
            lblQuestion.Text = $"Score: {correct}/{questions.GetLength(0)} ({percent}%) - Grade: {grade}";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // testing 1st question only - convert answer to an int
                //int answer = int.Parse(txtAnswer.Text);

                // if user has entered correct answer in the textbox
                if (txtAnswer.Text == questions[currentQuestion, 1])
                {
                    ShowFeedback("Correct", Color.Green);

                    // add 1 to correct answer count
                    correct++;
                }
                else
                {
                    // wrong answer
                    ShowFeedback("Incorrect", Color.Red);
                }

                // increment current question.
                currentQuestion++;

                // are there more questions?
                if (currentQuestion < questionCount)
                {
                    //  move to next question                
                    lblQuestion.Text = questions[currentQuestion, 0];
                }
                else
                {
                    // user is done - no more questions
                    FinishQuiz();
                }
                // clear last answer
                txtAnswer.Text = "";

            }
            catch (FormatException)
            {
                ShowFeedback("Enter a whole number", Color.Red);
                txtAnswer.Focus();
            }
            catch (OverflowException)
            {
                ShowFeedback("That number is too large", Color.Red);
                txtAnswer.Focus();

            }

            return; //stop here

            // MessageBox.Show("You clicked me");


        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            currentQuestion = 0;
            correct = 0;
            lblMessage.Text = "Restarting the Quiz";
            lblMessage.ForeColor = Color.Black;
            lblQuestion.Text = questions[0, 0];
            btnSubmit.Enabled = true;
            ResetToStart();
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            if (isDark == true)
            {
                this.BackColor = Color.Black;
                lblMessage.ForeColor = Color.White;
                lblQuestion.ForeColor = Color.White;
                txtAnswer.ForeColor = Color.White;
                //btnSubmit.ForeColor = Color.Black;
                //btnRestart.ForeColor = Color.Black;
                //btnToggleTheme.ForeColor = Color.Black;
                txtAnswer.BackColor = Color.Gray;
                isDark = false;
            }
            else
            {
                {
                    this.BackColor = Color.White;
                    lblMessage.ForeColor = Color.Black;
                    lblQuestion.ForeColor = Color.Black;
                    txtAnswer.ForeColor = Color.Black;
                    //btnSubmit.ForeColor = Color.White;
                    //btnRestart.ForeColor = Color.White;
                    //btnToggleTheme.ForeColor = Color.White;
                    txtAnswer.BackColor = Color.DimGray;
                    isDark = true;
                }
            }
        }

        private void btnSetTimeLimit_Click(object sender, EventArgs e)
        {
            // use int.TryParse to TRY converting value to an int without crashing
            // if text input is a valid number, store it in timeLimit var
            // TryParse returns true if value is a number, false if it is not a number
            if (int.TryParse(txtTimeLimit.Text, out int timeLimit) == true)
            {
                lblTimeLimit.Text = $"Time Limit: {timeLimit}";
                // remove any error message
                ShowFeedback("", Color.Black);
            }
            else
            {
                ShowFeedback("Invalid Time Limit", Color.Red);
                txtTimeLimit.Focus();
            }
        }
        /// <summary>
        /// validate the requested question count and start the quiz
        /// </summary>
        
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuestionCount.Text, out int count) == false)
            {
                ShowFeedback("Enter a whole number", Color.Red);
                txtQuestionCount.Focus();
            }
            if(count <1 || count > questions.GetLength(0)) 
            {
                ShowFeedback($"Enter a number between 1 and{questions.GetLength(0)}" , Color.Red);
                txtTimeLimit.Focus();
                return;
            }
            questionCount = count;
            currentQuestion = 0;
            correct = 0;
            btnSubmit.Enabled = true;
            txtAnswer.Enabled = true;
            txtAnswer.Text = "";
            lblQuestion.Text = questions[0, 0];
            ShowFeedback("", Color.Black);
            txtAnswer.Focus();
        }
    }   
}

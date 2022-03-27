using System;
using System.Windows.Forms;

namespace math
{
    public partial class Form1 : Form
    {
        MathQuestion MQ;
        private int CorrectAnswers;
        private int TotalQuestions;

        private enum ErrorCode
        {
            Error,
            Wrong,
            Correct
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void New_Question()
        {
            int difficulty = (cbDifficultySelection.SelectedIndex + 1) * 10;
            MQ = new MathQuestion();
            string qTest = MQ.NewMathQuestion(difficulty, 1);

            
            tbQuestionText.Text = qTest;
            tbAnswer.ReadOnly = false;
            tbAnswer.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New_Question();
            btnNew.Visible = false;
        }

        private void PlaySound(string soundFile, ErrorCode condition) 
        {
            if(System.IO.File.Exists(soundFile) == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundFile);
                player.Play();
            }
            else
            {
                if(condition == ErrorCode.Correct)
                {
                    MessageBox.Show("Correct!");
                }
                else
                {
                    if (condition == ErrorCode.Wrong)
                    {
                        MessageBox.Show("Wrong!");
                    }
                    else
                    {
                        MessageBox.Show("Check your answer for extra symbols.");
                    }    
                }
            }
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int providedAnswer;
            bool tryParseSuccess = int.TryParse(tbAnswer.Text, out providedAnswer);
            if (tryParseSuccess == false)
            {
                PlaySound(@"Resources\soundError.wav", ErrorCode.Error);
                tbAnswer.Text = "";
                tbAnswer.Focus();
                return;
            }

            MQ.CheckProvidedAnswer(providedAnswer);

            TotalQuestions++;
            if (MQ.Correctness == true)
            {
                CorrectAnswers++;
                tbQuestionsCorrectDisplay.Text = CorrectAnswers.ToString();
                tbTotalQuestionsDisplay.Text = TotalQuestions.ToString();

                string[] questionItems = new string[] { MQ.DifficultyLevel.ToString(), MQ.QuestionText, MQ.CorrectAnswer.ToString()};
                lvCorrect.Items.Add(new ListViewItem(questionItems));
                PlaySound(@"Resources\soundCorrect.wav", ErrorCode.Correct);
            }
            else
            {
                tbTotalQuestionsDisplay.Text = TotalQuestions.ToString();

                string[] questionItems = new string[] { MQ.DifficultyLevel.ToString(), MQ.QuestionText, MQ.CorrectAnswer.ToString(), MQ.ProvidedAnswer.ToString() };
                lvWrong.Items.Add(new ListViewItem(questionItems));
                PlaySound(@"soundWrong.wav", ErrorCode.Wrong);
            }

            tbAnswer.Text = "";

            New_Question();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDifficultySelection.SelectedIndex = 0;
            tbAnswer.ReadOnly = true;
            btnCheck.Visible = true;
        }

        private void tbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheck_Click(null, null);
            }
        }

        private void cbDifficultySelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            New_Question();
        }
    }
}
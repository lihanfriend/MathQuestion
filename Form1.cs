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
            tbAnswer.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New_Question();
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

                string[] questionItems = new string[] { MQ.DifficultyLevel.ToString(), MQ.QuestionText, MQ.ProvidedAnswer.ToString(), MQ.CorrectAnswer.ToString() };
                lvWrong.Items.Add(new ListViewItem(questionItems));
                PlaySound(@"soundWrong.wav", ErrorCode.Wrong);
            }

            tbAnswer.Text = "";
            tbPercentage.Text = ((int)((double)CorrectAnswers / TotalQuestions * 100)).ToString() + "%";

            New_Question();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDifficultySelection.SelectedIndex = 0;
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

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int newWidthForCorrectList = (this.Width - 500 -30) / 11 * 4;
            lvCorrect.Height = this.Height - 100;
            if (newWidthForCorrectList > 200)
            {
                lvCorrect.Width = newWidthForCorrectList;
                lvCorrect.Columns[0].Width = newWidthForCorrectList / 4 * 1;
                lvCorrect.Columns[1].Width = newWidthForCorrectList / 4 * 2;
                lvCorrect.Columns[2].Width = newWidthForCorrectList / 4 * 1;
            }

            int newWidthForWrongList = (this.Width - 500 -30) / 11 * 7;
            lvWrong.Height = this.Height - 100;
            if (newWidthForWrongList > 200)
            {
                lvWrong.Width = newWidthForWrongList;
                lvWrong.Location = new System.Drawing.Point(500 + lvCorrect.Width + 10, 0);

                lvWrong.Columns[0].Width = newWidthForWrongList / 7 * 1;
                lvWrong.Columns[1].Width = newWidthForWrongList / 7 * 2;
                lvWrong.Columns[2].Width = newWidthForWrongList / 7 * 2;
                lvWrong.Columns[3].Width = newWidthForWrongList / 7 * 2;
            }
        }
    }
}
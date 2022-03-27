using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    internal class MathQuestion
    {
        int num1;
        int num2;
        int sign; //only support 1 ("+")
        char signChar; //only support 1 ("+")
        public int DifficultyLevel; // 1 to 100
        public int CorrectAnswer;
        public string QuestionText = "";

        public int ProvidedAnswer;
        public bool Correctness;

        public string NewMathQuestion(int qDL, int qSign)
        {
            if (qSign != 1)
            {
                return "Error: Only support \"+\" math questions.";
            }
            if (qSign == 1)
            {
                signChar = '+';
            }

            sign = qSign;
            DifficultyLevel = qDL / 10;

            Random r = new Random();
            num1 = r.Next(qDL);
            num2 = r.Next(qDL);
            CorrectAnswer = num1 + num2;

            QuestionText = string.Format("{0} {1} {2} = ", num1, signChar, num2);

            return QuestionText;
        }

        public void CheckProvidedAnswer(int pAnswer)
        {
            ProvidedAnswer = pAnswer;
            if (ProvidedAnswer == CorrectAnswer)
            {
                Correctness = true;
            }
            else
            {
                Correctness = false;
            }
        }
    }
}

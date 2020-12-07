using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data
{
    [Serializable]
    public class SelfIntroductionQuestion
    {
        private string question;
        private string answer;

        public SelfIntroductionQuestion()
        {
            SetQuestion("");
            SetAnswer("");
        }
        public SelfIntroductionQuestion(SelfIntroductionQuestion question)
        {
            SetQuestion(question.GetQuestion());
            SetAnswer(question.GetAnswer());
        }


        public string GetQuestion()
        {
            return question;
        }

        public void SetQuestion(string value)
        {
            question = value;
        }


        public string GetAnswer()
        {
            return answer;
        }

        public void SetAnswer(string value)
        {
            answer = value;
        }

        public int GetLength() { return GetAnswer().Length; }
    }
    [Serializable]
    public class SelfIntroduction
    {
        public SelfIntroduction()
        {
            Questions = new List<SelfIntroductionQuestion>();
        }
        public List<SelfIntroductionQuestion> Questions { get; set; }
    }
}

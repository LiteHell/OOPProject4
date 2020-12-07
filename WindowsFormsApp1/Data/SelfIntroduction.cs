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
        public SelfIntroductionQuestion()
        {
            Question = "";
            Answer = "";
        }
        public SelfIntroductionQuestion(SelfIntroductionQuestion question)
        {
            Question = question.Question;
            Answer = question.Answer;
        }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int GetLength() { return Answer.Length; }
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

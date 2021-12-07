using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TrafficRulesTrainer
{
    public class QuestionForm
    {
        public ImageSource Image;
        public string QuestionText;
        public List<string> AnswerVariants;
        public int RightAnswerId;
        public string AnswerExplanation;

        public int SelectedVariant;

        public QuestionForm(ImageSource image, string questionText, List<string> answerVariants, int rightAnswerId, string answerExplanation, int selectedVariant)
        {
            Image = image;
            QuestionText = questionText;
            AnswerVariants = answerVariants;
            RightAnswerId = rightAnswerId;
            AnswerExplanation = answerExplanation;

            SelectedVariant = selectedVariant;
        }
    }
}

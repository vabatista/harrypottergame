using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterGame
{
    class Question
    {
        public enum QuestionTypeEnum { OPEN, CHARACTER, SCENE};

        private String id;
        private QuestionTypeEnum questionType;
        private String questionText;
        private String answer;
        private String imagePath;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public QuestionTypeEnum QuestionType
        {
            get
            {
                return questionType;
            }

            set
            {
                questionType = value;
            }
        }

        public string QuestionText
        {
            get
            {
                return questionText;
            }

            set
            {
                questionText = value;
            }
        }

        public string Answer
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }

        public string ImagePath
        {
            get
            {
                return imagePath;
            }

            set
            {
                imagePath = value;
            }
        }

    }
}

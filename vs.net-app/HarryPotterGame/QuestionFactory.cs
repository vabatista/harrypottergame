using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterGame
{
    class QuestionFactory
    {
        private String questionsFilePath;
        private String questionsFolder;
        private List<Question> questions;
        private static Random rnd = new Random();

        public QuestionFactory(String questionsFilePath)
        {
            this.questionsFilePath = questionsFilePath;
            this.questionsFolder = Path.GetDirectoryName(questionsFilePath);
        }

        
        public void LoadQuestions()
        {
            questions = new List<Question>();
            using (var reader = new StreamReader(questionsFilePath, Encoding.Default, true))
            {
                
                reader.ReadLine(); //skips header
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    Question q = new Question();
                    q.Id = values[0];
                    String type = values[1];
                    if (type == "Aberta") {
                        q.QuestionType = Question.QuestionTypeEnum.OPEN;
                    } else if (type == "Personagem") {
                        q.QuestionType = Question.QuestionTypeEnum.CHARACTER;
                        q.ImagePath = Path.Combine(this.questionsFolder, "characters", values[4]);
                    } else if (type == "Cena") {
                        q.QuestionType = Question.QuestionTypeEnum.SCENE;
                        q.ImagePath = Path.Combine(this.questionsFolder, "scenes", values[4]);
                    } else
                    {
                        throw new System.ArgumentException("Invalid question type {0} in questions file!", values[1]);
                    }
                    q.QuestionText = values[2];
                    q.Answer = values[3];
                    questions.Add(q);
                }
            }
        }

        public Question ChooseNextQuestion()
        {
            Question choosenQuestion = null;
            if (questions.Count > 0)
            {
                int idx = rnd.Next(questions.Count);
                choosenQuestion = questions[idx];
                questions.RemoveAt(idx);
            }
            return choosenQuestion;
        }

    }
}

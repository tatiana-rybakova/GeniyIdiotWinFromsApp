using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class QuestionsRepository
    {
        public static string Path = "questions.json";
        public static List<Question> GetAll()
        {
            var questions = new List<Question>();

            if (FileOperation.Exists(Path))
            {
                var value = FileOperation.Get(Path);
                questions = JsonConvert.DeserializeObject<List<Question>>(value);
            }
            else
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
                SaveQuestions(questions);                
            }
            return questions;
        }

        private static void SaveQuestions(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileOperation.Replace(Path, jsonData);
        }

        public static void Add(Question question)
        {
            var allQuestions = GetAll();
            allQuestions.Add(question);
            SaveQuestions(allQuestions);
        }

        public static void Remove(Question question)
        {
            var questions = GetAll();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Text == question.Text)
                {
                    questions.Remove(questions[i]);
                    break;
                }
            }           
            FileOperation.Clear(Path);
            SaveQuestions(questions);
        }
    }
}

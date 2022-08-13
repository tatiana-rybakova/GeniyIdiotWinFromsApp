namespace GeniyIdiot.Common
{
    public class Game
    {
        User user;
        List<Question> questions;
        Question currentQuestion;
        public int countQuestions;
        int questionNumber = 0;

        public Game(User user)
        {
            this.user = user;
            questions = QuestionsRepository.GetAll();
            countQuestions = questions.Count;
        }

        public Question GetNextQuestion()
        {
            Random random = new Random();
            var index = random.Next(0, questions.Count);
            currentQuestion = questions[index];            

            return currentQuestion;
        }
        public string GetQuestionNumber()
        {
            questionNumber++;
            return "Вопрос № " + questionNumber;
        }

        public void AcceptAnswer(string userAnswer)
        {
            if (int.Parse(userAnswer) == currentQuestion.Answer)
            {
                user.CountCorrectAnswers++;
            }
            questions.Remove(currentQuestion);
        }

        public bool End()
        {
            return questions.Count == 0;            
        }

        public string CalculateDiagnosis()
        {             
            user.Diagnosis = DiagnosisCalculate.GetDiagnosis(countQuestions, user);
            UserResultRepository.SaveResults(user);
            return user.Name + ", ваш диагноз - " + user.Diagnosis;
        }



    }
}

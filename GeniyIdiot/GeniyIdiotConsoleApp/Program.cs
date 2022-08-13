using System;
using GeniyIdiot.Common;


namespace GeniyIdiotConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Здравствуйте. Введите имя");
                string name = Console.ReadLine();

                Game game = new Game(new User(name));

                while (!game.End())
                {
                    var currentQuestion = game.GetNextQuestion();

                    Console.WriteLine(game.GetQuestionNumber());
                    Console.WriteLine(currentQuestion.Text);

                    var userAnswer = GetNumber();

                    game.AcceptAnswer(userAnswer);
                }

                Console.WriteLine(game.CalculateDiagnosis());

                var userChoice = GetUserChoice("Хотите посмотреть таблицу результатов?");
                if (userChoice) ShowResults();

                userChoice = GetUserChoice("Хотите добавить вопрос?");
                if (userChoice) AddQuestion();

                userChoice = GetUserChoice("Хотите удалить вопрос?");
                if (userChoice) RemoveQuestion();

                userChoice = GetUserChoice("Хотите пройти тест еще раз?");
                if (!userChoice) break;
            }
        }

        private static string GetNumber()
        {
            var input = Console.ReadLine();
            while (!InputValidator.TryParseToNumber(input, out string errorMessage))
            {
                Console.WriteLine(errorMessage);
            }
            return input;
        }
        private static void RemoveQuestion()
        {
            var questions = QuestionsRepository.GetAll();
            Console.WriteLine("Введите номер вопроса, который хотите удалить");
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {questions[i].Text}");
            }
            var deletingIndex = int.Parse(CheckUserAnswer());
            while (deletingIndex < 1 || deletingIndex > questions.Count)
            {
                Console.WriteLine("Введите правильный номер");
                deletingIndex = int.Parse(CheckUserAnswer());
            }
            var deletingQuestion = questions[deletingIndex - 1];
            QuestionsRepository.Remove(deletingQuestion);
            Console.WriteLine("Вопрос успешно удален");
        }

        private static void AddQuestion()
        {
            Console.WriteLine("Введите вопрос");
            string newText = Console.ReadLine();

            Console.WriteLine("Введите ответ");
            var newAnswer = CheckUserAnswer();
            Question newQuestion = new Question(newText, int.Parse(newAnswer));
            QuestionsRepository.Add(newQuestion);
            Console.WriteLine("Вопрос успешно добавлен");
        }

        private static bool GetUserChoice(string message)
        {
            Console.WriteLine(message + "Введите да или нет");
            var agreement = Console.ReadLine();
            if (agreement.ToLower() == "да") return true;
            return false;
        }

        public static void ShowResults()
        {
            var users = UserResultRepository.GetAll();
            Console.WriteLine("{0, 15} {1, 15} {2, 10}", "Имя", "Результат", "Диагноз");
            foreach (var user in users)
            {
                Console.WriteLine("{0, 15} {1, 10} {2, 15}", user.Name, user.CountCorrectAnswers, user.Diagnosis);
            }
        }

        static string CheckUserAnswer()
        {
            while (true)
            {
                var userAnswer = Console.ReadLine();
                int countNumbers = 0;
                for (int i = 0; i < userAnswer.Length; i++)
                {
                    if (char.IsDigit(userAnswer[i])) countNumbers++;
                }

                if (countNumbers == userAnswer.Length)
                {
                    return userAnswer;
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите число!");
                }
            }
        }
    }
}

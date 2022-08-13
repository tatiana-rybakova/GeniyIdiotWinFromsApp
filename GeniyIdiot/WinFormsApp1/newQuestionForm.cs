using GeniyIdiot.Common;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class NewQuestionForm : Form
    {
        public NewQuestionForm()
        {
            InitializeComponent();
        }
        private void NewQuestionForm_Load(object sender, EventArgs e)
        {
            GetAllQuestions();
        }

        private void GetAllQuestions()
        {
            var questions = QuestionsRepository.GetAll();
            var questionNumber = 0;
            foreach (var question in questions)
            {
                questionNumber++;
                allQuestionsDataGridView.Rows.Add(questionNumber, question.Text, question.Answer);
            }
        }
        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            var answerExists = InputValidator.CheckFiling(newAnswerTextBox.Text, out string errorNumber);
            var questionExists = InputValidator.CheckFiling(newQuestionTextBox.Text, out string errorText);
            if (!answerExists && !questionExists)
            {
                MessageBox.Show("Заполните поля!");
            }
            else if (!answerExists || !questionExists)
            {
                MessageBox.Show(errorNumber + " " + errorText);                
            }            
            else
            {
                var parsed = InputValidator.TryParseToNumber(newAnswerTextBox.Text, out string errorMessage);
                if (!parsed)
                {
                    MessageBox.Show(errorMessage);
                    allQuestionsDataGridView.Rows.Clear();
                }
                else
                {
                    var newAnswer = int.Parse(newAnswerTextBox.Text);
                    var newQuestion = new Question(newQuestionTextBox.Text, newAnswer);
                    QuestionsRepository.Add(newQuestion);
                    allQuestionsDataGridView.Rows.Clear();
                }
                GetAllQuestions();
            }
        }
    }
}

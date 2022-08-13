using GeniyIdiot.Common;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class DeleteQuestionForm : Form
    {
        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
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

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            var textExists = InputValidator.CheckFiling(deletingQuestionTextBox.Text, out string errorText);
            if (!textExists)
            {
                MessageBox.Show(errorText);
                allQuestionsDataGridView.Rows.Clear();
            }
            else
            {
                var parsed = InputValidator.TryParseToNumber(deletingQuestionTextBox.Text, out string errorMessage);
                if (!parsed)
                {
                    MessageBox.Show(errorMessage);
                    allQuestionsDataGridView.Rows.Clear();
                }
                else
                {
                    var index = int.Parse(deletingQuestionTextBox.Text) - 1;
                    var allQuestions = QuestionsRepository.GetAll();
                    if (index > 0 && index < allQuestions.Count)
                    {
                        var deletingQuestion = QuestionsRepository.GetAll()[index];
                        QuestionsRepository.Remove(deletingQuestion);
                        allQuestionsDataGridView.Rows.Clear();
                    }
                    else MessageBox.Show("Введены неверные данные");
                    allQuestionsDataGridView.Rows.Clear();
                }
            }
            GetAllQuestions();
        }
    }
}

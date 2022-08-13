using GeniyIdiot.Common;
using GeniyIdiotWindowsFormsApp;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        Game game;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();            
            welcomeForm.ShowDialog();

            if (welcomeForm.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }           

            game = new Game(new User(welcomeForm.nameTextBox.Text));

            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            questionNumberLabel.Text = game.GetQuestionNumber();

            questionTextLabel.Text = game.GetNextQuestion().Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParseToNumber(answerTextBox.Text, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {                
                game.AcceptAnswer(answerTextBox.Text);

                if (game.End())
                {
                    MessageBox.Show(game.CalculateDiagnosis());                    
                    return;
                }
                ShowNextQuestion();
            }
        }

        private void игратьЕщеРазToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void таблицаРезультатовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultsForm resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewQuestionForm newQuestionForm = new NewQuestionForm();
            newQuestionForm.ShowDialog();            
        }

        private void списокВопросовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllQuestionsForm allQuestionsForm = new AllQuestionsForm();
            allQuestionsForm.ShowDialog();
        }

        private void удалитьВопросToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteQuestionForm deleteQuestionForm = new DeleteQuestionForm();
            deleteQuestionForm.ShowDialog();
        }
    }
}

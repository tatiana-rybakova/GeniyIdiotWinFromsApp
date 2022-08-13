using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class AllQuestionsForm : Form
    {
        public AllQuestionsForm()
        {
            InitializeComponent();
        }

        private void AllQuestionsForm_Load(object sender, EventArgs e)
        {
            var questions = QuestionsRepository.GetAll();
            var questionNumber = 0;
            foreach (var question in questions)
            {
                questionNumber++;                
                questionsDataGridView.Rows.Add(questionNumber, question.Text, question.Answer);
            }
        }
    }
}

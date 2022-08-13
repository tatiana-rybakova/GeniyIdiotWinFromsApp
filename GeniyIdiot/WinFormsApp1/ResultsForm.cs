﻿using GeniyIdiot.Common;
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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var results = UserResultRepository.GetAll();
            foreach (var result in results)
            {
                resultsDataGridView.Rows.Add(result.Name, result.CountCorrectAnswers, result.Diagnosis);
            }
        }
    }
}

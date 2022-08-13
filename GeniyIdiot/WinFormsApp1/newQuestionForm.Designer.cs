namespace GeniyIdiotWindowsFormsApp
{
    partial class NewQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allQuestionsDataGridView = new System.Windows.Forms.DataGridView();
            this.addingQuestionTextLabel = new System.Windows.Forms.Label();
            this.newQuestionTextBox = new System.Windows.Forms.TextBox();
            this.addingQuestionAnswerLabel = new System.Windows.Forms.Label();
            this.newAnswerTextBox = new System.Windows.Forms.TextBox();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.allQuestionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // allQuestionsDataGridView
            // 
            this.allQuestionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allQuestionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberColumn,
            this.questionColumn,
            this.answerColumn});
            this.allQuestionsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.allQuestionsDataGridView.Name = "allQuestionsDataGridView";
            this.allQuestionsDataGridView.RowHeadersWidth = 51;
            this.allQuestionsDataGridView.RowTemplate.Height = 29;
            this.allQuestionsDataGridView.Size = new System.Drawing.Size(1070, 301);
            this.allQuestionsDataGridView.TabIndex = 0;
            // 
            // addingQuestionTextLabel
            // 
            this.addingQuestionTextLabel.AutoSize = true;
            this.addingQuestionTextLabel.Location = new System.Drawing.Point(460, 332);
            this.addingQuestionTextLabel.Name = "addingQuestionTextLabel";
            this.addingQuestionTextLabel.Size = new System.Drawing.Size(166, 20);
            this.addingQuestionTextLabel.TabIndex = 1;
            this.addingQuestionTextLabel.Text = "Введите текст вопроса";
            // 
            // newQuestionTextBox
            // 
            this.newQuestionTextBox.Location = new System.Drawing.Point(12, 372);
            this.newQuestionTextBox.Name = "newQuestionTextBox";
            this.newQuestionTextBox.Size = new System.Drawing.Size(1064, 27);
            this.newQuestionTextBox.TabIndex = 2;
            // 
            // addingQuestionAnswerLabel
            // 
            this.addingQuestionAnswerLabel.AutoSize = true;
            this.addingQuestionAnswerLabel.Location = new System.Drawing.Point(474, 415);
            this.addingQuestionAnswerLabel.Name = "addingQuestionAnswerLabel";
            this.addingQuestionAnswerLabel.Size = new System.Drawing.Size(152, 20);
            this.addingQuestionAnswerLabel.TabIndex = 3;
            this.addingQuestionAnswerLabel.Text = "Введите текст ответа";
            // 
            // newAnswerTextBox
            // 
            this.newAnswerTextBox.Location = new System.Drawing.Point(12, 438);
            this.newAnswerTextBox.Name = "newAnswerTextBox";
            this.newAnswerTextBox.Size = new System.Drawing.Size(1064, 27);
            this.newAnswerTextBox.TabIndex = 4;
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Location = new System.Drawing.Point(425, 478);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(261, 46);
            this.addQuestionButton.TabIndex = 5;
            this.addQuestionButton.Text = "Добавить";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // numberColumn
            // 
            this.numberColumn.HeaderText = "№";
            this.numberColumn.MinimumWidth = 6;
            this.numberColumn.Name = "numberColumn";
            this.numberColumn.Width = 125;
            // 
            // questionColumn
            // 
            this.questionColumn.HeaderText = "Вопрос";
            this.questionColumn.MinimumWidth = 6;
            this.questionColumn.Name = "questionColumn";
            this.questionColumn.Width = 125;
            // 
            // answerColumn
            // 
            this.answerColumn.HeaderText = "Ответ";
            this.answerColumn.MinimumWidth = 6;
            this.answerColumn.Name = "answerColumn";
            this.answerColumn.Width = 125;
            // 
            // NewQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 536);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.newAnswerTextBox);
            this.Controls.Add(this.addingQuestionAnswerLabel);
            this.Controls.Add(this.newQuestionTextBox);
            this.Controls.Add(this.addingQuestionTextLabel);
            this.Controls.Add(this.allQuestionsDataGridView);
            this.Name = "NewQuestionForm";
            this.Text = "NewQuestionForm";
            this.Load += new System.EventHandler(this.NewQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allQuestionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView allQuestionsDataGridView;
        private Label addingQuestionTextLabel;
        private TextBox newQuestionTextBox;
        private Label addingQuestionAnswerLabel;
        private TextBox newAnswerTextBox;
        private Button addQuestionButton;
        private DataGridViewTextBoxColumn numberColumn;
        private DataGridViewTextBoxColumn questionColumn;
        private DataGridViewTextBoxColumn answerColumn;
    }
}
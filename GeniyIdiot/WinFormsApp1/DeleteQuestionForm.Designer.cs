namespace GeniyIdiotWindowsFormsApp
{
    partial class DeleteQuestionForm
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
            this.numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletingLabel = new System.Windows.Forms.Label();
            this.deletingQuestionTextBox = new System.Windows.Forms.TextBox();
            this.deleteQuestionButton = new System.Windows.Forms.Button();
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
            this.allQuestionsDataGridView.Location = new System.Drawing.Point(12, 2);
            this.allQuestionsDataGridView.Name = "allQuestionsDataGridView";
            this.allQuestionsDataGridView.RowHeadersWidth = 51;
            this.allQuestionsDataGridView.RowTemplate.Height = 29;
            this.allQuestionsDataGridView.Size = new System.Drawing.Size(1058, 301);
            this.allQuestionsDataGridView.TabIndex = 1;
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
            // deletingLabel
            // 
            this.deletingLabel.AutoSize = true;
            this.deletingLabel.Location = new System.Drawing.Point(260, 338);
            this.deletingLabel.Name = "deletingLabel";
            this.deletingLabel.Size = new System.Drawing.Size(352, 20);
            this.deletingLabel.TabIndex = 2;
            this.deletingLabel.Text = "Введите номер вопроса, который хотите удалить";
            // 
            // deletingQuestionTextBox
            // 
            this.deletingQuestionTextBox.Location = new System.Drawing.Point(618, 335);
            this.deletingQuestionTextBox.Name = "deletingQuestionTextBox";
            this.deletingQuestionTextBox.Size = new System.Drawing.Size(113, 27);
            this.deletingQuestionTextBox.TabIndex = 3;
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.Location = new System.Drawing.Point(439, 379);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(205, 48);
            this.deleteQuestionButton.TabIndex = 4;
            this.deleteQuestionButton.Text = "Удалить";
            this.deleteQuestionButton.UseVisualStyleBackColor = true;
            this.deleteQuestionButton.Click += new System.EventHandler(this.deleteQuestionButton_Click);
            // 
            // DeleteQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.deleteQuestionButton);
            this.Controls.Add(this.deletingQuestionTextBox);
            this.Controls.Add(this.deletingLabel);
            this.Controls.Add(this.allQuestionsDataGridView);
            this.Name = "DeleteQuestionForm";
            this.Text = "DeleteQuestionForm";
            this.Load += new System.EventHandler(this.DeleteQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allQuestionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView allQuestionsDataGridView;
        private DataGridViewTextBoxColumn numberColumn;
        private DataGridViewTextBoxColumn questionColumn;
        private DataGridViewTextBoxColumn answerColumn;
        private Label deletingLabel;
        private TextBox deletingQuestionTextBox;
        private Button deleteQuestionButton;
    }
}
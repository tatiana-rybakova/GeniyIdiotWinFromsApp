namespace GeniyIdiotWindowsFormsApp
{
    partial class AllQuestionsForm
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
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAnswerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberColumn,
            this.questionTextColumn,
            this.questionAnswerColumn});
            this.questionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.RowHeadersWidth = 51;
            this.questionsDataGridView.RowTemplate.Height = 29;
            this.questionsDataGridView.Size = new System.Drawing.Size(960, 450);
            this.questionsDataGridView.TabIndex = 0;
            // 
            // numberColumn
            // 
            this.numberColumn.HeaderText = "№";
            this.numberColumn.MinimumWidth = 6;
            this.numberColumn.Name = "numberColumn";
            this.numberColumn.Width = 125;
            // 
            // questionTextColumn
            // 
            this.questionTextColumn.HeaderText = "Вопрос";
            this.questionTextColumn.MinimumWidth = 6;
            this.questionTextColumn.Name = "questionTextColumn";
            this.questionTextColumn.Width = 125;
            // 
            // questionAnswerColumn
            // 
            this.questionAnswerColumn.HeaderText = "Ответ";
            this.questionAnswerColumn.MinimumWidth = 6;
            this.questionAnswerColumn.Name = "questionAnswerColumn";
            this.questionAnswerColumn.Width = 125;
            // 
            // AllQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.questionsDataGridView);
            this.Name = "AllQuestionsForm";
            this.Text = "AllQuestionsForm";
            this.Load += new System.EventHandler(this.AllQuestionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView questionsDataGridView;
        private DataGridViewTextBoxColumn numberColumn;
        private DataGridViewTextBoxColumn questionTextColumn;
        private DataGridViewTextBoxColumn questionAnswerColumn;
    }
}
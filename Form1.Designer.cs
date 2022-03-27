namespace math
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbQuestionText = new System.Windows.Forms.TextBox();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbQuestionsCorrect = new System.Windows.Forms.TextBox();
            this.tbQuestionsCorrectDisplay = new System.Windows.Forms.TextBox();
            this.tbTotalQuestions = new System.Windows.Forms.TextBox();
            this.tbTotalQuestionsDisplay = new System.Windows.Forms.TextBox();
            this.cbDifficultySelection = new System.Windows.Forms.ComboBox();
            this.tbDifficulty = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPercentage = new System.Windows.Forms.TextBox();
            this.lvCorrect = new System.Windows.Forms.ListView();
            this.chCorrectDifficultLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCorrectQuestion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCorrectAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvWrong = new System.Windows.Forms.ListView();
            this.chWrongDifficultLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWrongQuestion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWrongProvidedAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWrongCorrectAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuestionText
            // 
            resources.ApplyResources(this.tbQuestionText, "tbQuestionText");
            this.tbQuestionText.Name = "tbQuestionText";
            this.tbQuestionText.ReadOnly = true;
            // 
            // tbAnswer
            // 
            resources.ApplyResources(this.tbAnswer, "tbAnswer");
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAnswer_KeyDown);
            // 
            // btnNew
            // 
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Name = "btnNew";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCheck
            // 
            resources.ApplyResources(this.btnCheck, "btnCheck");
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbQuestionsCorrect
            // 
            resources.ApplyResources(this.tbQuestionsCorrect, "tbQuestionsCorrect");
            this.tbQuestionsCorrect.Name = "tbQuestionsCorrect";
            this.tbQuestionsCorrect.ReadOnly = true;
            // 
            // tbQuestionsCorrectDisplay
            // 
            resources.ApplyResources(this.tbQuestionsCorrectDisplay, "tbQuestionsCorrectDisplay");
            this.tbQuestionsCorrectDisplay.Name = "tbQuestionsCorrectDisplay";
            this.tbQuestionsCorrectDisplay.ReadOnly = true;
            // 
            // tbTotalQuestions
            // 
            resources.ApplyResources(this.tbTotalQuestions, "tbTotalQuestions");
            this.tbTotalQuestions.Name = "tbTotalQuestions";
            this.tbTotalQuestions.ReadOnly = true;
            // 
            // tbTotalQuestionsDisplay
            // 
            resources.ApplyResources(this.tbTotalQuestionsDisplay, "tbTotalQuestionsDisplay");
            this.tbTotalQuestionsDisplay.Name = "tbTotalQuestionsDisplay";
            this.tbTotalQuestionsDisplay.ReadOnly = true;
            // 
            // cbDifficultySelection
            // 
            this.cbDifficultySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbDifficultySelection, "cbDifficultySelection");
            this.cbDifficultySelection.FormattingEnabled = true;
            this.cbDifficultySelection.Items.AddRange(new object[] {
            resources.GetString("cbDifficultySelection.Items"),
            resources.GetString("cbDifficultySelection.Items1"),
            resources.GetString("cbDifficultySelection.Items2"),
            resources.GetString("cbDifficultySelection.Items3"),
            resources.GetString("cbDifficultySelection.Items4"),
            resources.GetString("cbDifficultySelection.Items5"),
            resources.GetString("cbDifficultySelection.Items6"),
            resources.GetString("cbDifficultySelection.Items7"),
            resources.GetString("cbDifficultySelection.Items8"),
            resources.GetString("cbDifficultySelection.Items9")});
            this.cbDifficultySelection.Name = "cbDifficultySelection";
            this.cbDifficultySelection.SelectedIndexChanged += new System.EventHandler(this.cbDifficultySelection_SelectedIndexChanged);
            this.cbDifficultySelection.TextUpdate += new System.EventHandler(this.btnNew_Click);
            // 
            // tbDifficulty
            // 
            resources.ApplyResources(this.tbDifficulty, "tbDifficulty");
            this.tbDifficulty.Name = "tbDifficulty";
            this.tbDifficulty.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPercentage);
            this.groupBox1.Controls.Add(this.tbTotalQuestionsDisplay);
            this.groupBox1.Controls.Add(this.tbTotalQuestions);
            this.groupBox1.Controls.Add(this.tbQuestionsCorrectDisplay);
            this.groupBox1.Controls.Add(this.tbQuestionsCorrect);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tbPercentage
            // 
            resources.ApplyResources(this.tbPercentage, "tbPercentage");
            this.tbPercentage.Name = "tbPercentage";
            // 
            // lvCorrect
            // 
            this.lvCorrect.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCorrectDifficultLevel,
            this.chCorrectQuestion,
            this.chCorrectAnswer});
            this.lvCorrect.FullRowSelect = true;
            this.lvCorrect.GridLines = true;
            this.lvCorrect.HideSelection = false;
            resources.ApplyResources(this.lvCorrect, "lvCorrect");
            this.lvCorrect.Name = "lvCorrect";
            this.lvCorrect.UseCompatibleStateImageBehavior = false;
            this.lvCorrect.View = System.Windows.Forms.View.Details;
            // 
            // lvWrong
            // 
            this.lvWrong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chWrongDifficultLevel,
            this.chWrongQuestion,
            this.chWrongProvidedAnswer,
            this.chWrongCorrectAnswer});
            this.lvWrong.FullRowSelect = true;
            this.lvWrong.GridLines = true;
            this.lvWrong.HideSelection = false;
            resources.ApplyResources(this.lvWrong, "lvWrong");
            this.lvWrong.Name = "lvWrong";
            this.lvWrong.UseCompatibleStateImageBehavior = false;
            this.lvWrong.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lvWrong);
            this.Controls.Add(this.lvCorrect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDifficulty);
            this.Controls.Add(this.cbDifficultySelection);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.tbQuestionText);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuestionText;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox tbQuestionsCorrect;
        private System.Windows.Forms.TextBox tbQuestionsCorrectDisplay;
        private System.Windows.Forms.TextBox tbTotalQuestions;
        private System.Windows.Forms.TextBox tbTotalQuestionsDisplay;
        private System.Windows.Forms.ComboBox cbDifficultySelection;
        private System.Windows.Forms.TextBox tbDifficulty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvCorrect;
        private System.Windows.Forms.ColumnHeader chCorrectDifficultLevel;
        private System.Windows.Forms.ColumnHeader chCorrectQuestion;
        private System.Windows.Forms.ColumnHeader chCorrectAnswer;
        private System.Windows.Forms.ListView lvWrong;
        private System.Windows.Forms.ColumnHeader chWrongDifficultLevel;
        private System.Windows.Forms.ColumnHeader chWrongQuestion;
        private System.Windows.Forms.ColumnHeader chWrongProvidedAnswer;
        private System.Windows.Forms.ColumnHeader chWrongCorrectAnswer;
        private System.Windows.Forms.TextBox tbPercentage;
    }
}


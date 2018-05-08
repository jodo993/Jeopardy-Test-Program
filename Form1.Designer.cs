namespace JeopardyTestCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.topicListBox = new System.Windows.Forms.ListBox();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.topicAddButton = new System.Windows.Forms.Button();
            this.topicChangeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.moneyListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name";
            // 
            // tableNameTextBox
            // 
            this.tableNameTextBox.Location = new System.Drawing.Point(129, 53);
            this.tableNameTextBox.Name = "tableNameTextBox";
            this.tableNameTextBox.Size = new System.Drawing.Size(269, 20);
            this.tableNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Topic (Need 5)";
            // 
            // topicListBox
            // 
            this.topicListBox.FormattingEnabled = true;
            this.topicListBox.Location = new System.Drawing.Point(61, 154);
            this.topicListBox.Name = "topicListBox";
            this.topicListBox.Size = new System.Drawing.Size(181, 69);
            this.topicListBox.TabIndex = 3;
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(61, 128);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(181, 20);
            this.topicTextBox.TabIndex = 4;
            // 
            // topicAddButton
            // 
            this.topicAddButton.Location = new System.Drawing.Point(248, 126);
            this.topicAddButton.Name = "topicAddButton";
            this.topicAddButton.Size = new System.Drawing.Size(75, 23);
            this.topicAddButton.TabIndex = 5;
            this.topicAddButton.Text = "Add";
            this.topicAddButton.UseVisualStyleBackColor = true;
            this.topicAddButton.Click += new System.EventHandler(this.topicAddButton_Click);
            // 
            // topicChangeButton
            // 
            this.topicChangeButton.Location = new System.Drawing.Point(248, 154);
            this.topicChangeButton.Name = "topicChangeButton";
            this.topicChangeButton.Size = new System.Drawing.Size(75, 23);
            this.topicChangeButton.TabIndex = 6;
            this.topicChangeButton.Text = "Change";
            this.topicChangeButton.UseVisualStyleBackColor = true;
            this.topicChangeButton.Click += new System.EventHandler(this.topicChangeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Individual Topic Category";
            // 
            // moneyListBox
            // 
            this.moneyListBox.FormattingEnabled = true;
            this.moneyListBox.Items.AddRange(new object[] {
            "200",
            "400",
            "600",
            "800",
            "1000"});
            this.moneyListBox.Location = new System.Drawing.Point(363, 154);
            this.moneyListBox.Name = "moneyListBox";
            this.moneyListBox.Size = new System.Drawing.Size(120, 69);
            this.moneyListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = ">";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = ">";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(524, 154);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(124, 69);
            this.questionTextBox.TabIndex = 11;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(654, 154);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(124, 69);
            this.answerTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Question";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Answer";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(784, 152);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(784, 181);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 16;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 449);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.moneyListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topicChangeButton);
            this.Controls.Add(this.topicAddButton);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.topicListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tableNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox topicListBox;
        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.Button topicAddButton;
        private System.Windows.Forms.Button topicChangeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox moneyListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
    }
}


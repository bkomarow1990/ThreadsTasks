namespace Task1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberPriority = new System.Windows.Forms.ComboBox();
            this.lettersPriority = new System.Windows.Forms.ComboBox();
            this.symbolsPriority = new System.Windows.Forms.ComboBox();
            this.countGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.numbersTxtBox = new System.Windows.Forms.TextBox();
            this.lettersTxtBox = new System.Windows.Forms.TextBox();
            this.symbolsTxtBox = new System.Windows.Forms.TextBox();
            this.numbersCount = new System.Windows.Forms.TextBox();
            this.lettersCount = new System.Windows.Forms.TextBox();
            this.symbolsCount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.countGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.symbolsPriority);
            this.groupBox1.Controls.Add(this.lettersPriority);
            this.groupBox1.Controls.Add(this.numberPriority);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Priority";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Letters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Symbols";
            // 
            // numberPriority
            // 
            this.numberPriority.FormattingEnabled = true;
            this.numberPriority.Location = new System.Drawing.Point(62, 17);
            this.numberPriority.Name = "numberPriority";
            this.numberPriority.Size = new System.Drawing.Size(121, 21);
            this.numberPriority.TabIndex = 2;
            this.numberPriority.SelectedIndexChanged += new System.EventHandler(this.numberPriority_SelectedIndexChanged);
            // 
            // lettersPriority
            // 
            this.lettersPriority.FormattingEnabled = true;
            this.lettersPriority.Location = new System.Drawing.Point(62, 46);
            this.lettersPriority.Name = "lettersPriority";
            this.lettersPriority.Size = new System.Drawing.Size(121, 21);
            this.lettersPriority.TabIndex = 3;
            this.lettersPriority.SelectedIndexChanged += new System.EventHandler(this.lettersPriority_SelectedIndexChanged);
            // 
            // symbolsPriority
            // 
            this.symbolsPriority.FormattingEnabled = true;
            this.symbolsPriority.Location = new System.Drawing.Point(62, 73);
            this.symbolsPriority.Name = "symbolsPriority";
            this.symbolsPriority.Size = new System.Drawing.Size(121, 21);
            this.symbolsPriority.TabIndex = 4;
            this.symbolsPriority.SelectedIndexChanged += new System.EventHandler(this.symbolsPriority_SelectedIndexChanged);
            // 
            // countGroupBox
            // 
            this.countGroupBox.Controls.Add(this.symbolsCount);
            this.countGroupBox.Controls.Add(this.lettersCount);
            this.countGroupBox.Controls.Add(this.numbersCount);
            this.countGroupBox.Controls.Add(this.label4);
            this.countGroupBox.Controls.Add(this.label5);
            this.countGroupBox.Controls.Add(this.label6);
            this.countGroupBox.Location = new System.Drawing.Point(12, 137);
            this.countGroupBox.Name = "countGroupBox";
            this.countGroupBox.Size = new System.Drawing.Size(203, 110);
            this.countGroupBox.TabIndex = 5;
            this.countGroupBox.TabStop = false;
            this.countGroupBox.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Symbols";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Letters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numbers";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(12, 267);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(203, 41);
            this.generateBtn.TabIndex = 6;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // numbersTxtBox
            // 
            this.numbersTxtBox.Location = new System.Drawing.Point(231, 39);
            this.numbersTxtBox.MaxLength = 1000000000;
            this.numbersTxtBox.Multiline = true;
            this.numbersTxtBox.Name = "numbersTxtBox";
            this.numbersTxtBox.Size = new System.Drawing.Size(557, 123);
            this.numbersTxtBox.TabIndex = 7;
            // 
            // lettersTxtBox
            // 
            this.lettersTxtBox.Location = new System.Drawing.Point(231, 169);
            this.lettersTxtBox.MaxLength = 1000000000;
            this.lettersTxtBox.Multiline = true;
            this.lettersTxtBox.Name = "lettersTxtBox";
            this.lettersTxtBox.Size = new System.Drawing.Size(557, 123);
            this.lettersTxtBox.TabIndex = 8;
            // 
            // symbolsTxtBox
            // 
            this.symbolsTxtBox.Location = new System.Drawing.Point(231, 298);
            this.symbolsTxtBox.MaxLength = 1000000000;
            this.symbolsTxtBox.Multiline = true;
            this.symbolsTxtBox.Name = "symbolsTxtBox";
            this.symbolsTxtBox.Size = new System.Drawing.Size(557, 123);
            this.symbolsTxtBox.TabIndex = 9;
            // 
            // numbersCount
            // 
            this.numbersCount.Location = new System.Drawing.Point(62, 17);
            this.numbersCount.Multiline = true;
            this.numbersCount.Name = "numbersCount";
            this.numbersCount.Size = new System.Drawing.Size(121, 22);
            this.numbersCount.TabIndex = 10;
            // 
            // lettersCount
            // 
            this.lettersCount.Location = new System.Drawing.Point(62, 46);
            this.lettersCount.Multiline = true;
            this.lettersCount.Name = "lettersCount";
            this.lettersCount.Size = new System.Drawing.Size(121, 22);
            this.lettersCount.TabIndex = 11;
            // 
            // symbolsCount
            // 
            this.symbolsCount.Location = new System.Drawing.Point(62, 74);
            this.symbolsCount.Multiline = true;
            this.symbolsCount.Name = "symbolsCount";
            this.symbolsCount.Size = new System.Drawing.Size(121, 22);
            this.symbolsCount.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.symbolsTxtBox);
            this.Controls.Add(this.lettersTxtBox);
            this.Controls.Add(this.numbersTxtBox);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.countGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.countGroupBox.ResumeLayout(false);
            this.countGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox symbolsPriority;
        private System.Windows.Forms.ComboBox lettersPriority;
        private System.Windows.Forms.ComboBox numberPriority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox countGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox numbersTxtBox;
        private System.Windows.Forms.TextBox lettersTxtBox;
        private System.Windows.Forms.TextBox symbolsTxtBox;
        private System.Windows.Forms.TextBox symbolsCount;
        private System.Windows.Forms.TextBox lettersCount;
        private System.Windows.Forms.TextBox numbersCount;
    }
}


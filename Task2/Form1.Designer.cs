namespace Task2
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
            this.fileBtn = new System.Windows.Forms.Button();
            this.pathTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.threadsNUP = new System.Windows.Forms.NumericUpDown();
            this.copyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.threadsNUP)).BeginInit();
            this.SuspendLayout();
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(13, 13);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(112, 38);
            this.fileBtn.TabIndex = 0;
            this.fileBtn.Text = "File path";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // pathTxtBox
            // 
            this.pathTxtBox.Location = new System.Drawing.Point(131, 23);
            this.pathTxtBox.Name = "pathTxtBox";
            this.pathTxtBox.Size = new System.Drawing.Size(629, 20);
            this.pathTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Threads";
            // 
            // threadsNUP
            // 
            this.threadsNUP.Location = new System.Drawing.Point(114, 70);
            this.threadsNUP.Name = "threadsNUP";
            this.threadsNUP.Size = new System.Drawing.Size(120, 20);
            this.threadsNUP.TabIndex = 3;
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(12, 96);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(222, 41);
            this.copyBtn.TabIndex = 4;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.threadsNUP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathTxtBox);
            this.Controls.Add(this.fileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.threadsNUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.TextBox pathTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown threadsNUP;
        private System.Windows.Forms.Button copyBtn;
    }
}


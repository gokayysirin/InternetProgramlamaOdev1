namespace InternetProgramlamaOdev1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.btnGetWord = new System.Windows.Forms.Button();
            this.gbxSayHi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxSayHi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxWord
            // 
            this.tbxWord.Location = new System.Drawing.Point(111, 79);
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.Size = new System.Drawing.Size(221, 27);
            this.tbxWord.TabIndex = 0;
            // 
            // btnGetWord
            // 
            this.btnGetWord.Location = new System.Drawing.Point(174, 112);
            this.btnGetWord.Name = "btnGetWord";
            this.btnGetWord.Size = new System.Drawing.Size(94, 29);
            this.btnGetWord.TabIndex = 1;
            this.btnGetWord.Text = "Yazı Getir";
            this.btnGetWord.UseVisualStyleBackColor = true;
            this.btnGetWord.Click += new System.EventHandler(this.btnGetWord_Click);
            // 
            // gbxSayHi
            // 
            this.gbxSayHi.Controls.Add(this.label1);
            this.gbxSayHi.Controls.Add(this.tbxWord);
            this.gbxSayHi.Controls.Add(this.btnGetWord);
            this.gbxSayHi.Location = new System.Drawing.Point(262, 164);
            this.gbxSayHi.Name = "gbxSayHi";
            this.gbxSayHi.Size = new System.Drawing.Size(435, 240);
            this.gbxSayHi.TabIndex = 2;
            this.gbxSayHi.TabStop = false;
            this.gbxSayHi.Text = "Say Hi!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "say hi to world, trust me everything starts with this.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(991, 614);
            this.Controls.Add(this.gbxSayHi);
            this.Name = "Form1";
            this.Text = "İnternet Programlama Ödev1 ";
            this.gbxSayHi.ResumeLayout(false);
            this.gbxSayHi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tbxWord;
        private Button btnGetWord;
        private GroupBox gbxSayHi;
        private Label label1;
    }
}
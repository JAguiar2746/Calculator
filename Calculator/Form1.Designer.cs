namespace Calculator
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.digit1 = new System.Windows.Forms.Button();
            this.digit0 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.asterisk = new System.Windows.Forms.Button();
            this.slash = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.openP = new System.Windows.Forms.Button();
            this.closeP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digit1
            // 
            this.digit1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.digit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit1.Location = new System.Drawing.Point(164, 430);
            this.digit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(52, 62);
            this.digit1.TabIndex = 0;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = false;
            this.digit1.Click += new System.EventHandler(this.button_Click);
            // 
            // digit0
            // 
            this.digit0.BackColor = System.Drawing.SystemColors.HighlightText;
            this.digit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit0.Location = new System.Drawing.Point(164, 502);
            this.digit0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(111, 62);
            this.digit0.TabIndex = 1;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = false;
            this.digit0.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(108, 138);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 102);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter an expression";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.HighlightText;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(381, 288);
            this.plus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(52, 62);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.button_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(441, 288);
            this.minus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(52, 62);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.button_Click);
            // 
            // asterisk
            // 
            this.asterisk.BackColor = System.Drawing.SystemColors.HighlightText;
            this.asterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asterisk.Location = new System.Drawing.Point(381, 358);
            this.asterisk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.asterisk.Name = "asterisk";
            this.asterisk.Size = new System.Drawing.Size(52, 62);
            this.asterisk.TabIndex = 5;
            this.asterisk.Text = "*";
            this.asterisk.UseVisualStyleBackColor = false;
            this.asterisk.Click += new System.EventHandler(this.button_Click);
            // 
            // slash
            // 
            this.slash.BackColor = System.Drawing.SystemColors.HighlightText;
            this.slash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.slash.Location = new System.Drawing.Point(441, 358);
            this.slash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(52, 62);
            this.slash.TabIndex = 6;
            this.slash.Text = "/";
            this.slash.UseVisualStyleBackColor = false;
            this.slash.Click += new System.EventHandler(this.button_Click);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculate.Location = new System.Drawing.Point(381, 503);
            this.calculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(112, 62);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "=>";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Display";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(164, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(381, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Operations";
            // 
            // decimalPoint
            // 
            this.decimalPoint.BackColor = System.Drawing.SystemColors.HighlightText;
            this.decimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decimalPoint.Location = new System.Drawing.Point(284, 503);
            this.decimalPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(52, 62);
            this.decimalPoint.TabIndex = 11;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = false;
            this.decimalPoint.Click += new System.EventHandler(this.button_Click);
            // 
            // openP
            // 
            this.openP.BackColor = System.Drawing.SystemColors.HighlightText;
            this.openP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openP.Location = new System.Drawing.Point(381, 429);
            this.openP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openP.Name = "openP";
            this.openP.Size = new System.Drawing.Size(52, 62);
            this.openP.TabIndex = 12;
            this.openP.Text = "(";
            this.openP.UseVisualStyleBackColor = false;
            this.openP.Click += new System.EventHandler(this.button_Click);
            // 
            // closeP
            // 
            this.closeP.BackColor = System.Drawing.SystemColors.HighlightText;
            this.closeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeP.Location = new System.Drawing.Point(441, 429);
            this.closeP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeP.Name = "closeP";
            this.closeP.Size = new System.Drawing.Size(52, 62);
            this.closeP.TabIndex = 13;
            this.closeP.Text = ")";
            this.closeP.UseVisualStyleBackColor = false;
            this.closeP.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(224, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 62);
            this.button1.TabIndex = 14;
            this.button1.Text = "2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(284, 430);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 62);
            this.button2.TabIndex = 15;
            this.button2.Text = "3";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(284, 358);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 62);
            this.button3.TabIndex = 18;
            this.button3.Text = "6";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(224, 358);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 62);
            this.button4.TabIndex = 17;
            this.button4.Text = "5";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(164, 358);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 62);
            this.button5.TabIndex = 16;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(284, 286);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 62);
            this.button6.TabIndex = 21;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(224, 286);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 62);
            this.button7.TabIndex = 20;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(164, 286);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 62);
            this.button8.TabIndex = 19;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeP);
            this.Controls.Add(this.openP);
            this.Controls.Add(this.decimalPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.slash);
            this.Controls.Add(this.asterisk);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.digit0);
            this.Controls.Add(this.digit1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.DoubleClick += new System.EventHandler(this.form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button digit1;
        private System.Windows.Forms.Button digit0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button asterisk;
        private System.Windows.Forms.Button slash;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decimalPoint;
        private System.Windows.Forms.Button openP;
        private System.Windows.Forms.Button closeP;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}


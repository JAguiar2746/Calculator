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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.digit2 = new System.Windows.Forms.Button();
            this.digit3 = new System.Windows.Forms.Button();
            this.digit6 = new System.Windows.Forms.Button();
            this.digit5 = new System.Windows.Forms.Button();
            this.digit4 = new System.Windows.Forms.Button();
            this.digit9 = new System.Windows.Forms.Button();
            this.digit8 = new System.Windows.Forms.Button();
            this.digit7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digit1
            // 
            this.digit1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.digit1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit1.Location = new System.Drawing.Point(13, 245);
            this.digit1.Margin = new System.Windows.Forms.Padding(4);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(46, 46);
            this.digit1.TabIndex = 0;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = false;
            this.digit1.Click += new System.EventHandler(this.button_Click);
            // 
            // digit0
            // 
            this.digit0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.digit0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit0.Location = new System.Drawing.Point(13, 298);
            this.digit0.Margin = new System.Windows.Forms.Padding(4);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(97, 46);
            this.digit0.TabIndex = 1;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = false;
            this.digit0.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(13, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 78);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter an expression";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.plus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(171, 137);
            this.plus.Margin = new System.Windows.Forms.Padding(4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(46, 46);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.button_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.minus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(224, 137);
            this.minus.Margin = new System.Windows.Forms.Padding(4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(46, 46);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.button_Click);
            // 
            // asterisk
            // 
            this.asterisk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.asterisk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asterisk.Location = new System.Drawing.Point(171, 191);
            this.asterisk.Margin = new System.Windows.Forms.Padding(4);
            this.asterisk.Name = "asterisk";
            this.asterisk.Size = new System.Drawing.Size(46, 46);
            this.asterisk.TabIndex = 5;
            this.asterisk.Text = "*";
            this.asterisk.UseVisualStyleBackColor = false;
            this.asterisk.Click += new System.EventHandler(this.button_Click);
            // 
            // slash
            // 
            this.slash.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.slash.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.slash.Location = new System.Drawing.Point(224, 191);
            this.slash.Margin = new System.Windows.Forms.Padding(4);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(46, 46);
            this.slash.TabIndex = 6;
            this.slash.Text = "/";
            this.slash.UseVisualStyleBackColor = false;
            this.slash.Click += new System.EventHandler(this.button_Click);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.calculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculate.Location = new System.Drawing.Point(171, 298);
            this.calculate.Margin = new System.Windows.Forms.Padding(4);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(98, 46);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "=>";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Display";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(171, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Operations";
            // 
            // decimalPoint
            // 
            this.decimalPoint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.decimalPoint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decimalPoint.Location = new System.Drawing.Point(117, 298);
            this.decimalPoint.Margin = new System.Windows.Forms.Padding(4);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(46, 46);
            this.decimalPoint.TabIndex = 11;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = false;
            this.decimalPoint.Click += new System.EventHandler(this.button_Click);
            // 
            // openP
            // 
            this.openP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openP.Location = new System.Drawing.Point(171, 245);
            this.openP.Margin = new System.Windows.Forms.Padding(4);
            this.openP.Name = "openP";
            this.openP.Size = new System.Drawing.Size(46, 46);
            this.openP.TabIndex = 12;
            this.openP.Text = "(";
            this.openP.UseVisualStyleBackColor = false;
            this.openP.Click += new System.EventHandler(this.button_Click);
            // 
            // closeP
            // 
            this.closeP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.closeP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeP.Location = new System.Drawing.Point(224, 245);
            this.closeP.Margin = new System.Windows.Forms.Padding(4);
            this.closeP.Name = "closeP";
            this.closeP.Size = new System.Drawing.Size(46, 46);
            this.closeP.TabIndex = 13;
            this.closeP.Text = ")";
            this.closeP.UseVisualStyleBackColor = false;
            this.closeP.Click += new System.EventHandler(this.button_Click);
            // 
            // digit2
            // 
            this.digit2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.digit2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit2.Location = new System.Drawing.Point(65, 245);
            this.digit2.Margin = new System.Windows.Forms.Padding(4);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(46, 46);
            this.digit2.TabIndex = 14;
            this.digit2.Text = "2";
            this.digit2.UseVisualStyleBackColor = false;
            this.digit2.Click += new System.EventHandler(this.button_Click);
            // 
            // digit3
            // 
            this.digit3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.digit3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit3.Location = new System.Drawing.Point(117, 245);
            this.digit3.Margin = new System.Windows.Forms.Padding(4);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(46, 46);
            this.digit3.TabIndex = 15;
            this.digit3.Text = "3";
            this.digit3.UseVisualStyleBackColor = false;
            this.digit3.Click += new System.EventHandler(this.button_Click);
            // 
            // digit6
            // 
            this.digit6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.digit6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit6.Location = new System.Drawing.Point(117, 191);
            this.digit6.Margin = new System.Windows.Forms.Padding(4);
            this.digit6.Name = "digit6";
            this.digit6.Size = new System.Drawing.Size(46, 46);
            this.digit6.TabIndex = 18;
            this.digit6.Text = "6";
            this.digit6.UseVisualStyleBackColor = false;
            this.digit6.Click += new System.EventHandler(this.button_Click);
            // 
            // digit5
            // 
            this.digit5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.digit5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit5.Location = new System.Drawing.Point(65, 191);
            this.digit5.Margin = new System.Windows.Forms.Padding(4);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(46, 46);
            this.digit5.TabIndex = 17;
            this.digit5.Text = "5";
            this.digit5.UseVisualStyleBackColor = false;
            this.digit5.Click += new System.EventHandler(this.button_Click);
            // 
            // digit4
            // 
            this.digit4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.digit4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit4.Location = new System.Drawing.Point(13, 191);
            this.digit4.Margin = new System.Windows.Forms.Padding(4);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(46, 46);
            this.digit4.TabIndex = 16;
            this.digit4.Text = "4";
            this.digit4.UseVisualStyleBackColor = false;
            this.digit4.Click += new System.EventHandler(this.button_Click);
            // 
            // digit9
            // 
            this.digit9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.digit9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit9.Location = new System.Drawing.Point(117, 137);
            this.digit9.Margin = new System.Windows.Forms.Padding(4);
            this.digit9.Name = "digit9";
            this.digit9.Size = new System.Drawing.Size(46, 46);
            this.digit9.TabIndex = 21;
            this.digit9.Text = "9";
            this.digit9.UseVisualStyleBackColor = false;
            this.digit9.Click += new System.EventHandler(this.button_Click);
            // 
            // digit8
            // 
            this.digit8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.digit8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit8.Location = new System.Drawing.Point(65, 137);
            this.digit8.Margin = new System.Windows.Forms.Padding(4);
            this.digit8.Name = "digit8";
            this.digit8.Size = new System.Drawing.Size(46, 46);
            this.digit8.TabIndex = 20;
            this.digit8.Text = "8";
            this.digit8.UseVisualStyleBackColor = false;
            this.digit8.Click += new System.EventHandler(this.button_Click);
            // 
            // digit7
            // 
            this.digit7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.digit7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit7.Location = new System.Drawing.Point(13, 137);
            this.digit7.Margin = new System.Windows.Forms.Padding(4);
            this.digit7.Name = "digit7";
            this.digit7.Size = new System.Drawing.Size(46, 46);
            this.digit7.TabIndex = 19;
            this.digit7.Text = "7";
            this.digit7.UseVisualStyleBackColor = false;
            this.digit7.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(285, 358);
            this.Controls.Add(this.digit9);
            this.Controls.Add(this.digit8);
            this.Controls.Add(this.digit7);
            this.Controls.Add(this.digit6);
            this.Controls.Add(this.digit5);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculator";
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
        private Button digit2;
        private Button digit3;
        private Button digit6;
        private Button digit5;
        private Button digit4;
        private Button digit9;
        private Button digit8;
        private Button digit7;
    }
}


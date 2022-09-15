using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private long result;
        public Form1()
        {
            InitializeComponent();
            result = 0;
        }

        private void form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Double click on " + sender.ToString() + "??! Calm down!");
        }

        private void button_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var res = cal(textBox1.Text);
            textBox1.Text += " = " + res.ToString();
        }

        private object cal(string text)
        {
            DataTable dt = new DataTable();
            var v = new object();
            try
            {
                v = dt.Compute(text, "");
            }
            catch (Exception e)
            {
                v = "NaN";
            }

            return v;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
        }

    }
}

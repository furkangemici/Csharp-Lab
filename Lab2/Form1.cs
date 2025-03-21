using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4
{
    public partial class Form1: Form
    {
        int[] numbers;

        public Form1()
        {
            InitializeComponent();
            checkBox1.Checked = true;
            button1.Text = "Generate and Calculate";
        }
      
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; 
                MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = checkBox1.Checked ? "Generate and Calculate" : "Generate";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int N) || N <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir pozitif tam sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int[] fibonacci = new int[N];
            fibonacci[0] = 0;
            if (N > 1)
                fibonacci[1] = 1;

            for (int i = 2; i < N; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            textBox2.Clear(); 
            foreach (int num in fibonacci)
            {
                textBox2.AppendText(num + Environment.NewLine);
            }

           
            if (checkBox2.Checked)
            {
                double first10Average = fibonacci.Take(10).Average();
                label4.Text =  first10Average.ToString("F2");
            }
            else if (checkBox1.Checked)
            {
                double overallAverage = fibonacci.Average();
                label4.Text =  overallAverage.ToString("F2");
            }
            else
            {
                label4.Text = "";
            }
        }

      

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int N) && N >= 10)
            {
                checkBox2.Enabled = true; 
            }
            else
            {
                checkBox2.Enabled = false; 
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Text = "10";
                textBox1.Enabled = false; 
            }
            else
            {
                textBox1.Enabled = true; 
            }
        }
    }
}

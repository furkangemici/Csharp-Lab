using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAdd.MouseEnter += btn_MouseEnter;
            btnSubtract.MouseEnter += btn_MouseEnter;
            btnMultiply.MouseEnter += btn_MouseEnter;
            btnDivide.MouseEnter += btn_MouseEnter;

            btnAdd.MouseLeave += btn_MouseLeave;
            btnSubtract.MouseLeave += btn_MouseLeave;
            btnMultiply.MouseLeave += btn_MouseLeave;
            btnDivide.MouseLeave += btn_MouseLeave;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double result = num1 + num2;

                lblResult.Text = "Result : " + result.ToString("0.##");
                lblResult.BackColor = (result > 0) ? Color.Green : Color.Red;
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double result = num1 - num2;

                lblResult.Text = "Result : " + result.ToString("0.##");
                lblResult.BackColor = (result > 0) ? Color.Green : Color.Red;
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double result = num1 * num2;

                lblResult.Text = "Result : " + result.ToString("0.##");
                lblResult.BackColor = (result > 0) ? Color.Green : Color.Red;
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);

                if (num2 == 0)
                {
                    MessageBox.Show("Division by zero is not allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = num1 / num2;
                lblResult.Text = "Result : " + result.ToString("0.##");
                lblResult.BackColor = (result > 0) ? Color.Green : Color.Red;
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Red;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
        }

        private void txtNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}

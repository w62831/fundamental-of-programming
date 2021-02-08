using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            double n1, n2, res;
            try
            {
                n1 = Convert.ToDouble(num1.Text);
                n2 = Convert.ToDouble(num2.Text);
                res = n1 + n2;

                result.Text = res.ToString();
            }
            catch (Exception)
            { MessageBox.Show("It is not a number"); }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            double n1, n2, res;
            try
            {
                n1 = Convert.ToDouble(num1.Text);
                n2 = Convert.ToDouble(num2.Text);
                res = n1 - n2;

                result.Text = res.ToString();
            }
            catch (Exception)
            { MessageBox.Show("It is not a number"); }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            double n1, n2, res;
            try
            {
                n1 = Convert.ToDouble(num1.Text);
                n2 = Convert.ToDouble(num2.Text);
                res = n1 / n2;

                result.Text = res.ToString();
            }
            catch (Exception)
            { MessageBox.Show("It is not a number"); }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            double n1, n2, res;
            try
            {
                n1 = Convert.ToDouble(num1.Text);
                n2 = Convert.ToDouble(num2.Text);
                res = n1 * n2;

                result.Text = res.ToString();
            }
            catch (Exception)
            { MessageBox.Show("It is not a number"); }
        }
    }
}

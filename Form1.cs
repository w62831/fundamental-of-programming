using System;
using System.Windows.Forms;

namespace prime_numb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                int num, s=0;
                num = Convert.ToInt32(textBox1.Text);
                for (int i=2; i<num; i++)
                {
                    if (num % i == 0)
                        s++;
                }
                if (s==0)
                    MessageBox.Show("It is a prime number");
                else
                    MessageBox.Show("It is not a prime number");
            } 
            catch (Exception)
            {
                MessageBox.Show("It is not the number");
            }
        }
    }
}

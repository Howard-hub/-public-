using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 求平方和
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(textBox1.Text);
            int i = 1;
            int sum1;
            int sum2=0;
            for(i=1;i<=start;i++)
            {
                sum1 = i * i;
                sum2 = sum1 + sum2;
            }
            textBox2.Text = sum2.ToString();
        }
    }
}

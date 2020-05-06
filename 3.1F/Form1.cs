using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1F
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        static int f(int x)
        {
            int a, b, c;
            a = x / 100;
            b = (x / 10) % 10;
            c = x % 10;
            int n = 100 * c + 10 * b + a;
            return (n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VVod.Text == "") V.Text = "Неккоректные введённые данные";
            else
            {
                int x = Convert.ToInt32(VVod.Text);
                if (x < 100 || x > 999) V.Text = "Неккоректные введённые данные";
                else
                {
                    V.Text = "";
                    x = f(x);
                    V.Text += x;
                }
            }
        }
    }
}

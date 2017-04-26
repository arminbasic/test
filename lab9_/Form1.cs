using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string[] A = s.Split(',');
            int temp = 0, avg = 0;
            
            for (int i=0; i<A.Length;i++)
                avg = Convert.ToInt32(A[i]);
               temp += avg;
               
            }

            label2.Text = (temp / (A.Length-1) ).ToString();
        }
    }
}

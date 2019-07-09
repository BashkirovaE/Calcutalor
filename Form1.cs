using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_plus_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble((txtA.Text));
            double b = Convert.ToDouble((txtB.Text));
            txtRes.Text = (a + b).ToString();
        }

        private void Btn_minus_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble((txtA.Text));
            double b = Convert.ToDouble((txtB.Text));
            txtRes.Text = (a - b).ToString();
        }

        private void Btn_mul_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble((txtA.Text));
            double b = Convert.ToDouble((txtB.Text));
            txtRes.Text = (a * b).ToString();
        }

        private void Btn_div_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble((txtA.Text));
            double b = Convert.ToDouble((txtB.Text));
            txtRes.Text = (a / b).ToString();
        }
    }
}

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


        private void Btn_OP_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble((txtA.Text));
            double b = Convert.ToDouble((txtB.Text));
            double result = 0;
            switch (((Button) sender).Name)
            {
                case "btn_plus":
                    result = (a + b);
                    break;
                case "btn_minus":
                    result = (a - b);
                    break;
                case "btn_mul":
                    result = (a * b);
                    break;
                case "btn_div":
                    result = (a / b);
                    break;
                default:
                    throw new Exception ("Неизвестная операция");
            }
            txtRes.Text = result.ToString();
        }
    }
}

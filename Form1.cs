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
            double firstValue = Convert.ToDouble((txtA.Text));
            double secondValue = Convert.ToDouble((txtB.Text));
            double result = 0;
            ITwoArgumentsCalculator calculator;
            calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            result = calculator.Calculate(firstValue, secondValue);
            txtRes.Text = result.ToString();
        }
    }
}

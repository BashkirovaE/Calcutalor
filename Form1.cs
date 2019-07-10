using System;
using System.Windows.Forms;
using ObjectOrientedCalculator.Factories;
using ObjectOrientedCalculator.Interfaces;
using ObjectOrientedCalculator.OneArgumentsFunctions;
using ObjectOrientedCalculator.TwoArgumentsFunctions;

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
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstValue, secondValue);
            txtRes.Text = result.ToString();
            //vf
        }

        private void OneArgumentFunc_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble((txtA.Text));
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstValue);
            txtRes.Text = result.ToString();
            //vf
        }
    }
}

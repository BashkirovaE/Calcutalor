using System;
using System.Windows.Forms;
using ObjectOrientedCalculator.Factories;
using ObjectOrientedCalculator.Interfaces;

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
            double firstValue = 0;
            double secondValue = 0;
            try
            {
                firstValue = Convert.ToDouble((txtA.Text.Replace('.', ',')));
                secondValue = Convert.ToDouble((txtB.Text.Replace('.', ',')));
            }
            catch
            {
                MessageBox.Show("Data entry error");
            }

            ITwoArgumentsCalculator calculator = null;
            try
            {
                calculator = TwoArgumentsFactory.CreateCalculator(((Button) sender).Name);
            }
            catch
            {
                MessageBox.Show("Unknown calculator type");
            }

            double result = 0;
            try
            {
                result = calculator.Calculate(firstValue, secondValue);
            }
            catch
            {
                MessageBox.Show("Wrong value. Can't calculate");
            }
            

            txtRes.Text = result.ToString();
            //vf
        }

        private void OneArgumentFunc_Click(object sender, EventArgs e)
        {
            double firstValue = 0;
            try
            {
                firstValue = Convert.ToDouble((txtA.Text).Replace('.', ','));
            }
            catch
            {
                MessageBox.Show("Data entry error");
            }

            IOneArgumentCalculator calculator = null;
            try
            {
                calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
            }
            catch
            {
                MessageBox.Show("Unknown calculator type");
            }

            double result = 0;
            try
            {
                result = calculator.Calculate(firstValue);
            }
            catch
            {
                MessageBox.Show("Wrong value. Can't calculate");
            }
            txtRes.Text = result.ToString();
        }
    }
}

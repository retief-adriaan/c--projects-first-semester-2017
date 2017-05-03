using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert
{
    public partial class frmConvert : Form
    {
        public frmConvert()
        {
            InitializeComponent();
            // subscribe the radio buttons' CheckedChanged event to the OperationString event handler
            rbAddition.CheckedChanged += OperationString;
            rbSubtraction.CheckedChanged += OperationString;
            rbMultiplication.CheckedChanged += OperationString;
            rbDivision.CheckedChanged += OperationString;
            // subscribe the temperature fields' TextChanged event to th any_tbx_TextChanged event handler
            tbxCelsius.TextChanged += any_tbx_TextChanged;
            tbxFahrenheit.TextChanged += any_tbx_TextChanged;
        }

        // exit button
        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // TEMPERATURE
        //------------------------------------------------------------------------------------------------------------------------------------
        //global variable for whether to convert from CtoF or FtoC
        bool CelsiusToFahrenheit = true;

        // validates input, allows only numbers or ,
        private void any_tbx_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, "[^-,0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ((TextBox)sender).Text = ((TextBox)sender).Text.Remove(((TextBox)sender).Text.Length - 1);
            }

            if (((TextBox)sender) == tbxCelsius)
            {
                CelsiusToFahrenheit = false;
            }
            else
            {
                CelsiusToFahrenheit = true; 
            }
        }

        // convert button click method, makes call to conversion method
        private void btnConvertTemperature_Click(object sender, EventArgs e)
        {
            tbxCelsius.ReadOnly = false;
            tbxFahrenheit.ReadOnly = false;

            if(CelsiusToFahrenheit)
            {
                tbxCelsius.Text = (convertTemperature(0, Double.Parse(tbxFahrenheit.Text))).ToString();
            }
            else
            {
                tbxFahrenheit.Text = (convertTemperature(1, Double.Parse(tbxCelsius.Text))).ToString();
            }
        }

        // converts from C to F or F to C
        private double convertTemperature(int t, double temp)
        {
            if(t == 0)
            {
                return Math.Round(((temp - 32) * 5 / 9), 2); 
            }
            else
            {
                return Math.Round((temp * 9 / 5 + 32),2);
            }
        }

        // OPERATION
        //------------------------------------------------------------------------------------------------------------------------------------
        // global variable to determine what type of operation is being performed
        // event handler that stores a value in the global variable when a radio button is checked
        string strOperation = "";
        private void OperationString(object sender, EventArgs e)
        {
            strOperation = " " + ((RadioButton)sender).Text + " ";
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            // assign values to variables
            decimal a, b, c, d, f;
            string strResult = "";
            a = nudValue1.Value;
            b = nudValue2.Value;
            c = nudValue3.Value;
            d = nudValue4.Value;
            f = nudValue5.Value;

            // validation before result method is called
            if (!(rbAddition.Checked || rbSubtraction.Checked || rbMultiplication.Checked || rbDivision.Checked))
            {
                tbxResult.Text = "Please select an operation.";
            }
            else
            {
                // any of the values are zero and division selected
                if ((a == 0 || b == 0 || c == 0 || d == 0 || f == 0) && (rbDivision.Checked))
                {
                    tbxResult.Text = "Dvision by zero.";
                }
                else
                {
                    // validation passed, call result method
                    strResult = a.ToString() + strOperation + b.ToString() + strOperation + c.ToString() + strOperation + d.ToString() + strOperation + f.ToString();
                    strResult += " = " + result(a, b, c, d, f).ToString();
                    tbxResult.Text = strResult;
                }
            }
        }

        // method that determines result depending on which radio button is checked
        public decimal result(decimal a, decimal b, decimal c, decimal d, decimal e)
        {
            decimal result = 0;

            if (rbAddition.Checked)
            {
                result = a + b + c + d + e;
            }
            else
            {
                if (rbSubtraction.Checked)
                {
                    result = a - b - c - d - e;
                }
                else
                {
                    if (rbMultiplication.Checked)
                    {
                        result = a * b * c * d * e;
                    }
                    else
                    {
                        result = a / b / c / d / e;
                    }
                }
            }
            return result;
        }
    }
}

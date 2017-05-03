// created by ADRIAAN RETIEF on 2017/03/22

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionCalculator
{
    public partial class frm_calc : Form
    {
        // variable list
        string numero_uno = "";
        string operation = "";
        string numero_dos = "";

        // main form method
        public frm_calc()
        {
            InitializeComponent();

            // prepare calc for use by cleaning everything
            btnClear.PerformClick();

            // set some attributes
            lblError.BackColor = Color.White;
            lblError.ForeColor= Color.Red;

            // subscribe all numberical buttons to numerical_button_click
            btnOne.Click += numerical_button_click;
            btnTwo.Click += numerical_button_click;
            btnThree.Click += numerical_button_click;
            btnFour.Click += numerical_button_click;
            btnFive.Click += numerical_button_click;
            btnSix.Click += numerical_button_click;
            btnSeven.Click += numerical_button_click;
            btnEight.Click += numerical_button_click;
            btnNine.Click += numerical_button_click;
            btnZero.Click += numerical_button_click;
            btnDec.Click += numerical_button_click;

            // subscribe all operational buttons to operation_button_click
            btnPlus.Click += operational_button_click;
            btnMinus.Click += operational_button_click;
            btnTimes.Click += operational_button_click;
            btnDiv.Click += operational_button_click;
        }

        // BUTTON CLICK HANDLERS
        //----------------------------------------------------------------------------------------------

        // add digits to first or second string depending on whether an operation has been provided
        private void numerical_button_click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                numero_uno += ((Button)sender).Text;
                tbxOutput.Text += ((Button)sender).Text;
            }
            else
            {
                numero_dos += ((Button)sender).Text;
                tbxOutput.Text += ((Button)sender).Text;
            }
        }

        // add operation to operation string if one has not been provided
        // display error otherwise
        private void operational_button_click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                operation = ((Button)sender).Text;
                tbxOutput.Text += ((Button)sender).Text;
            }
            else
            {
                btnClear.PerformClick();
                lblError.Text = "Syntax error.";
            }
        }

        // calculate result
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double d_uno = Convert.ToDouble(numero_uno);
            double d_dos = Convert.ToDouble(numero_dos);
            double answer = 0.0;

            if (operation != "")
            {
                switch (operation)
                {
                    case ("+"): answer = d_uno + d_dos;
                        break;
                    case ("-"): answer = d_uno - d_dos;
                        break;
                    case ("x"): answer = d_uno * d_dos;
                        break;
                    case ("÷"): 
                        if(d_dos == 0.0)
                        {
                            btnClear.PerformClick();
                            lblError.Text = "Cannot div by 0";
                        }
                        else
                        {
                            answer = d_uno / d_dos;
                        }
                        break;
                }

                // store answer for later use
                d_dos = answer;
                tbxOutput.Clear();
                tbxOutput.Text = Convert.ToString(answer);
                
            }
            else
            {
                btnClear.PerformClick();
                lblError.Text = "No operation provided.";
            }
        }


        // UTILITY FUNCTIONS
        //----------------------------------------------------------------------------------------------

        // back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_menu().Show();
        }

        // reset variables, clear output
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            numero_uno = "";
            operation = "";
            tbxOutput.Clear();
            numero_dos = ""; ;
        }
    }
}

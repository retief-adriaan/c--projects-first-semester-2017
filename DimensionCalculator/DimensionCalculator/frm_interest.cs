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
    public partial class frm_interest : Form
    {

        // determines type of interest
        bool bool_simpleInterest;

        public frm_interest()
        {
            InitializeComponent();

            // set bool_simple to true, as this is the default interface
            bool_simpleInterest = true;

            // enable simple interface, disable compound interface
            lblNumCompounded.Visible = false;
            tbxNumCompounded.Visible = false;
            tbxPeriod.Text = "1";

            // subscribe text box changes to event handler that validates for numbers only
            tbxStartAmount.TextChanged += any_tbx_textChange;
            tbxInterest.TextChanged += any_tbx_textChange;
            tbxPeriod.TextChanged += any_tbx_textChange;
            tbxNumCompounded.TextChanged += any_tbx_textChange;
        }


        // MAIN METHOD FOR CALCULATING RESULT
        //----------------------------------------------------------------------------------------------

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (tbxStartAmount.Text == "" || tbxInterest.Text == "" || tbxPeriod.Text == "")
            {
                MessageBox.Show("Please provide an initial investment, an interest rate and a period.");
                return;
            }

            // convert text entered to double / int
            double start = Convert.ToDouble(tbxStartAmount.Text);
            double interest = Convert.ToDouble(tbxInterest.Text);
            double period = Convert.ToDouble(tbxPeriod.Text);
            int numCompounded;
            if (!int.TryParse(tbxNumCompounded.Text, out numCompounded)) numCompounded = 0;

            CInterest interestCalcObject = new CInterest();

            if (bool_simpleInterest)
            {
                // calculate simple interest
                if (period == 1.0 || period == 1)
                {
                    interestCalcObject.CalculateInterestSimple(start, interest);
                }
                else
                {
                    interestCalcObject.CalculateInterestSimple(start, interest, period);
                }
            }
            else
            {
                // calculate compound interest
                interestCalcObject.CalculateInterestCompound(start, interest, numCompounded, period);

            }

            tbxEndAmount.Text = Convert.ToString(interestCalcObject.EndAmount);
        }


        // UTILITY FUNCTIONS
        //----------------------------------------------------------------------------------------------

        // back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_menu().Show();
        }

        // reset all components
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxStartAmount.Clear();
            tbxInterest.Clear();
            tbxPeriod.Clear();
            tbxEndAmount.Clear();
            tbxNumCompounded.Clear();
        }

        // switch between simple / compound
        private void btnSimpleOrCompound_Click(object sender, EventArgs e)
        {
            if(btnSimpleOrCompound.Text == "Switch to Compound")
            {
                // switch to interface for compound
                btnSimpleOrCompound.Text = "Switch to Simple";
                lblNumCompounded.Visible = true;
                tbxNumCompounded.Visible = true;
                btnReset.PerformClick();
                bool_simpleInterest = false;
            }
            else
            {
                // switch to interface for simple
                btnSimpleOrCompound.Text = "Switch to Compound";
                lblNumCompounded.Visible = false;
                tbxNumCompounded.Visible = false;
                btnReset.PerformClick();
                bool_simpleInterest = true;
            }
        }

        // prevent user from entering letters
        private void any_tbx_textChange(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, "[^,0-9]"))
            {
                MessageBox.Show("Please enter only numbers or a comma for decimal values where applicable.");
                ((TextBox)sender).Text = ((TextBox)sender).Text.Remove(((TextBox)sender).Text.Length - 1);
            }
        }
    }
}

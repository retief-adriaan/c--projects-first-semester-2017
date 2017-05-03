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
    public partial class frm_exchange : Form
    {
        // dictionary with exchange rates
        Dictionary<string, double> exchangeRates = new Dictionary<string, double>();

        public frm_exchange()
        {
            InitializeComponent();
            // clear components
            btnReset.PerformClick();

            // populate dictionary with exchange rates as of 2017/03/22
            exchangeRates.Add("South African Rand (ZAR)", 1.00);
            exchangeRates.Add("Chinese Yuan (CNY)", 0.54);
            exchangeRates.Add("American Dollar (USD)", 0.079);
            exchangeRates.Add("Euro (EUR)", 0.073);
            exchangeRates.Add("British Pound (GBP)", 0.063);

            // subscribe 
            tbxFrom.TextChanged += any_tbx_TextChanged;
            tbxCustomRate.TextAlignChanged += any_tbx_TextChanged;
        }

        // MAIN FUNCTION FOR CALCULATING RESULTS
        //----------------------------------------------------------------------------------------------

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(cmbFrom.SelectedIndex == -1 || cmbTo.SelectedIndex == -1 || tbxFrom.Text == "")
            {
                MessageBox.Show("Please select currencies and specify an amount to be converted.");
            }
            else
            {
                // new CExchange object
                CExchange exchange = new CExchange(Convert.ToDouble(tbxFrom.Text));

                // variables for cleaner code
                double rateA, rateB, amount;
                amount = Convert.ToDouble(tbxFrom.Text);
                rateA = exchangeRates[cmbFrom.Text];
                rateB = exchangeRates[cmbTo.Text];

                // check for custom rate
                if(tbxCustomRate.Text != "") rateB = Convert.ToDouble(tbxCustomRate.Text);

                // call CExchange method calcToAmount
                exchange.calcToAmount(amount, rateA, rateB);
                tbxTo.Text = Convert.ToString(exchange.ToAmount);
                
                btnReset.Enabled = true;
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

        // prevent user from entering letters
        private void any_tbx_TextChanged(object sender, EventArgs e) 
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, "[^,0-9]") )
            {
                MessageBox.Show("Please enter only numbers.");
                ((TextBox)sender).Text = ((TextBox)sender).Text.Remove(((TextBox)sender).Text.Length - 1);
            }
        }

        // reset components
        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbFrom.SelectedIndex = -1;
            cmbTo.SelectedIndex = -1;
            tbxFrom.Text = "";
            tbxTo.Text = "";
            tbxCustomRate.Text = "";
            btnCalculate.Enabled = true;
            btnReset.Enabled = false;
        }
    }
}

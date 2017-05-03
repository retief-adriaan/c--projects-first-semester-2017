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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }


        // each button navigates to a secondary form, and hides the menu form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            new frm_calc().Show();
            this.Hide();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            new frm_exchange().Show();
            this.Hide();
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            new frm_interest().Show();
            this.Hide();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            new frm_browser().Show();
            this.Hide();
        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

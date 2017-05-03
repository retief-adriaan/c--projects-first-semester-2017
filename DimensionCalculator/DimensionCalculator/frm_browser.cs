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
    public partial class frm_browser : Form
    {
        public frm_browser()
        {
            InitializeComponent();
            this.wbrFinances.Navigate("www.google.com");
        }

        private void frm_browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            new frm_menu().Show();
            this.Hide();
        }
    }
}

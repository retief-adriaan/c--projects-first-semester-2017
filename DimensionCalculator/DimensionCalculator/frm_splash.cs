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
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
            tmr_splash.Start();
            pbar_splash.Maximum = 100;
            pbar_splash.Step = 10;
        }      

        private void tmr_splash_Tick(object sender, EventArgs e)
        {
            
            pbar_splash.PerformStep();
            if(pbar_splash.Value == 100)
            {
                tmr_splash.Enabled = false;
                new frm_menu().Show();
                this.Hide();
            }
        }
    }
}

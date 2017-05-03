namespace DimensionCalculator
{
    partial class frm_browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wbrFinances = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbrFinances
            // 
            this.wbrFinances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrFinances.Location = new System.Drawing.Point(0, 0);
            this.wbrFinances.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrFinances.Name = "wbrFinances";
            this.wbrFinances.Size = new System.Drawing.Size(284, 261);
            this.wbrFinances.TabIndex = 0;
            // 
            // frm_browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.wbrFinances);
            this.Name = "frm_browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_browser_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbrFinances;
    }
}
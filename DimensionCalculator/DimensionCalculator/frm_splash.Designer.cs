namespace DimensionCalculator
{
    partial class frm_splash
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
            this.components = new System.ComponentModel.Container();
            this.tmr_splash = new System.Windows.Forms.Timer(this.components);
            this.pbar_splash = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tmr_splash
            // 
            this.tmr_splash.Tick += new System.EventHandler(this.tmr_splash_Tick);
            // 
            // pbar_splash
            // 
            this.pbar_splash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbar_splash.Location = new System.Drawing.Point(0, 427);
            this.pbar_splash.Name = "pbar_splash";
            this.pbar_splash.Size = new System.Drawing.Size(800, 23);
            this.pbar_splash.TabIndex = 0;
            // 
            // frm_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DimensionCalculator.Properties.Resources.dc_splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbar_splash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_splash;
        private System.Windows.Forms.ProgressBar pbar_splash;
    }
}


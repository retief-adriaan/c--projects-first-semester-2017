namespace DimensionCalculator
{
    partial class frm_interest
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSimpleOrCompound = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblStartAmount = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEndAmount = new System.Windows.Forms.Label();
            this.tbxStartAmount = new System.Windows.Forms.TextBox();
            this.tbxInterest = new System.Windows.Forms.TextBox();
            this.tbxPeriod = new System.Windows.Forms.TextBox();
            this.tbxEndAmount = new System.Windows.Forms.TextBox();
            this.tbxNumCompounded = new System.Windows.Forms.TextBox();
            this.lblNumCompounded = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(161, 294);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 35);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSimpleOrCompound
            // 
            this.btnSimpleOrCompound.Location = new System.Drawing.Point(12, 294);
            this.btnSimpleOrCompound.Name = "btnSimpleOrCompound";
            this.btnSimpleOrCompound.Size = new System.Drawing.Size(144, 35);
            this.btnSimpleOrCompound.TabIndex = 5;
            this.btnSimpleOrCompound.Text = "Switch to Compound";
            this.btnSimpleOrCompound.UseVisualStyleBackColor = true;
            this.btnSimpleOrCompound.Click += new System.EventHandler(this.btnSimpleOrCompound_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 253);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 35);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblStartAmount
            // 
            this.lblStartAmount.AutoSize = true;
            this.lblStartAmount.Location = new System.Drawing.Point(9, 9);
            this.lblStartAmount.Name = "lblStartAmount";
            this.lblStartAmount.Size = new System.Drawing.Size(68, 13);
            this.lblStartAmount.TabIndex = 5;
            this.lblStartAmount.Text = "Start Amount";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(9, 62);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(83, 13);
            this.lblInterest.TabIndex = 6;
            this.lblInterest.Text = "Interest per year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Years";
            // 
            // lblEndAmount
            // 
            this.lblEndAmount.AutoSize = true;
            this.lblEndAmount.Location = new System.Drawing.Point(159, 9);
            this.lblEndAmount.Name = "lblEndAmount";
            this.lblEndAmount.Size = new System.Drawing.Size(65, 13);
            this.lblEndAmount.TabIndex = 8;
            this.lblEndAmount.Text = "End Amount";
            // 
            // tbxStartAmount
            // 
            this.tbxStartAmount.Location = new System.Drawing.Point(12, 25);
            this.tbxStartAmount.Name = "tbxStartAmount";
            this.tbxStartAmount.Size = new System.Drawing.Size(144, 20);
            this.tbxStartAmount.TabIndex = 0;
            // 
            // tbxInterest
            // 
            this.tbxInterest.Location = new System.Drawing.Point(12, 78);
            this.tbxInterest.Name = "tbxInterest";
            this.tbxInterest.Size = new System.Drawing.Size(144, 20);
            this.tbxInterest.TabIndex = 1;
            // 
            // tbxPeriod
            // 
            this.tbxPeriod.Location = new System.Drawing.Point(12, 127);
            this.tbxPeriod.Name = "tbxPeriod";
            this.tbxPeriod.Size = new System.Drawing.Size(144, 20);
            this.tbxPeriod.TabIndex = 2;
            // 
            // tbxEndAmount
            // 
            this.tbxEndAmount.Location = new System.Drawing.Point(161, 25);
            this.tbxEndAmount.Name = "tbxEndAmount";
            this.tbxEndAmount.ReadOnly = true;
            this.tbxEndAmount.Size = new System.Drawing.Size(144, 20);
            this.tbxEndAmount.TabIndex = 8;
            // 
            // tbxNumCompounded
            // 
            this.tbxNumCompounded.Location = new System.Drawing.Point(11, 180);
            this.tbxNumCompounded.Name = "tbxNumCompounded";
            this.tbxNumCompounded.Size = new System.Drawing.Size(144, 20);
            this.tbxNumCompounded.TabIndex = 3;
            // 
            // lblNumCompounded
            // 
            this.lblNumCompounded.AutoSize = true;
            this.lblNumCompounded.Location = new System.Drawing.Point(8, 164);
            this.lblNumCompounded.Name = "lblNumCompounded";
            this.lblNumCompounded.Size = new System.Drawing.Size(148, 13);
            this.lblNumCompounded.TabIndex = 13;
            this.lblNumCompounded.Text = "Number of times compounded";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(162, 253);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 35);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frm_interest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 337);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbxNumCompounded);
            this.Controls.Add(this.lblNumCompounded);
            this.Controls.Add(this.tbxEndAmount);
            this.Controls.Add(this.tbxPeriod);
            this.Controls.Add(this.tbxInterest);
            this.Controls.Add(this.tbxStartAmount);
            this.Controls.Add(this.lblEndAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblStartAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSimpleOrCompound);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_interest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSimpleOrCompound;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblStartAmount;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEndAmount;
        private System.Windows.Forms.TextBox tbxStartAmount;
        private System.Windows.Forms.TextBox tbxInterest;
        private System.Windows.Forms.TextBox tbxPeriod;
        private System.Windows.Forms.TextBox tbxEndAmount;
        private System.Windows.Forms.TextBox tbxNumCompounded;
        private System.Windows.Forms.Label lblNumCompounded;
        private System.Windows.Forms.Button btnReset;
    }
}
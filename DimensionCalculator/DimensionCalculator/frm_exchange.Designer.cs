namespace DimensionCalculator
{
    partial class frm_exchange
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
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFromAmount = new System.Windows.Forms.Label();
            this.lblToAmount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbxFrom = new System.Windows.Forms.TextBox();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCustomRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(17, 233);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Items.AddRange(new object[] {
            "South African Rand (ZAR)",
            "American Dollar (USD)",
            "British Pound (GBP)",
            "Euro (EUR)",
            "Chinese Yuan (CNY)"});
            this.cmbFrom.Location = new System.Drawing.Point(17, 34);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(144, 21);
            this.cmbFrom.TabIndex = 2;
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Items.AddRange(new object[] {
            "South African Rand (ZAR)",
            "American Dollar (USD)",
            "British Pound (GBP)",
            "Euro (EUR)",
            "Chinese Yuan (CNY)"});
            this.cmbTo.Location = new System.Drawing.Point(167, 34);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(144, 21);
            this.cmbTo.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(17, 18);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(167, 18);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To";
            // 
            // lblFromAmount
            // 
            this.lblFromAmount.AutoSize = true;
            this.lblFromAmount.Location = new System.Drawing.Point(17, 68);
            this.lblFromAmount.Name = "lblFromAmount";
            this.lblFromAmount.Size = new System.Drawing.Size(43, 13);
            this.lblFromAmount.TabIndex = 8;
            this.lblFromAmount.Text = "Amount";
            // 
            // lblToAmount
            // 
            this.lblToAmount.AutoSize = true;
            this.lblToAmount.Location = new System.Drawing.Point(164, 68);
            this.lblToAmount.Name = "lblToAmount";
            this.lblToAmount.Size = new System.Drawing.Size(43, 13);
            this.lblToAmount.TabIndex = 9;
            this.lblToAmount.Text = "Amount";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(92, 192);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 35);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbxFrom
            // 
            this.tbxFrom.Location = new System.Drawing.Point(17, 84);
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.Size = new System.Drawing.Size(144, 20);
            this.tbxFrom.TabIndex = 11;
            // 
            // tbxTo
            // 
            this.tbxTo.Location = new System.Drawing.Point(167, 84);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.ReadOnly = true;
            this.tbxTo.Size = new System.Drawing.Size(144, 20);
            this.tbxTo.TabIndex = 12;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(167, 233);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 35);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Specify rate";
            // 
            // tbxCustomRate
            // 
            this.tbxCustomRate.Location = new System.Drawing.Point(17, 140);
            this.tbxCustomRate.Name = "tbxCustomRate";
            this.tbxCustomRate.Size = new System.Drawing.Size(144, 20);
            this.tbxCustomRate.TabIndex = 15;
            // 
            // frm_exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 280);
            this.Controls.Add(this.tbxCustomRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbxTo);
            this.Controls.Add(this.tbxFrom);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblToAmount);
            this.Controls.Add(this.lblFromAmount);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_exchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exchange Rate Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFromAmount;
        private System.Windows.Forms.Label lblToAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbxFrom;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCustomRate;
    }
}
namespace Convert
{
    partial class frmConvert
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
            this.gbxTemperature = new System.Windows.Forms.GroupBox();
            this.tbxFahrenheit = new System.Windows.Forms.TextBox();
            this.tbxCelsius = new System.Windows.Forms.TextBox();
            this.btnConvertTemperature = new System.Windows.Forms.Button();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.gbxSum = new System.Windows.Forms.GroupBox();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.rbMultiplication = new System.Windows.Forms.RadioButton();
            this.rbSubtraction = new System.Windows.Forms.RadioButton();
            this.rbAddition = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.lblValue5 = new System.Windows.Forms.Label();
            this.lblValue4 = new System.Windows.Forms.Label();
            this.lblValue3 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.nudValue5 = new System.Windows.Forms.NumericUpDown();
            this.nudValue4 = new System.Windows.Forms.NumericUpDown();
            this.nudValue3 = new System.Windows.Forms.NumericUpDown();
            this.nudValue2 = new System.Windows.Forms.NumericUpDown();
            this.nudValue1 = new System.Windows.Forms.NumericUpDown();
            this.btnOperation = new System.Windows.Forms.Button();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.gbxTemperature.SuspendLayout();
            this.gbxSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTemperature
            // 
            this.gbxTemperature.Controls.Add(this.tbxFahrenheit);
            this.gbxTemperature.Controls.Add(this.tbxCelsius);
            this.gbxTemperature.Controls.Add(this.btnConvertTemperature);
            this.gbxTemperature.Controls.Add(this.lblFahrenheit);
            this.gbxTemperature.Controls.Add(this.lblCelsius);
            this.gbxTemperature.Location = new System.Drawing.Point(12, 12);
            this.gbxTemperature.Name = "gbxTemperature";
            this.gbxTemperature.Size = new System.Drawing.Size(263, 146);
            this.gbxTemperature.TabIndex = 0;
            this.gbxTemperature.TabStop = false;
            this.gbxTemperature.Text = "Temperature";
            // 
            // tbxFahrenheit
            // 
            this.tbxFahrenheit.Location = new System.Drawing.Point(145, 56);
            this.tbxFahrenheit.Name = "tbxFahrenheit";
            this.tbxFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.tbxFahrenheit.TabIndex = 7;
            // 
            // tbxCelsius
            // 
            this.tbxCelsius.Location = new System.Drawing.Point(25, 56);
            this.tbxCelsius.Name = "tbxCelsius";
            this.tbxCelsius.Size = new System.Drawing.Size(100, 20);
            this.tbxCelsius.TabIndex = 6;
            // 
            // btnConvertTemperature
            // 
            this.btnConvertTemperature.Location = new System.Drawing.Point(96, 101);
            this.btnConvertTemperature.Name = "btnConvertTemperature";
            this.btnConvertTemperature.Size = new System.Drawing.Size(75, 23);
            this.btnConvertTemperature.TabIndex = 5;
            this.btnConvertTemperature.Text = "Convert";
            this.btnConvertTemperature.UseVisualStyleBackColor = true;
            this.btnConvertTemperature.Click += new System.EventHandler(this.btnConvertTemperature_Click);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(142, 28);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(64, 13);
            this.lblFahrenheit.TabIndex = 4;
            this.lblFahrenheit.Text = "° Fahrenheit";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(22, 28);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(47, 13);
            this.lblCelsius.TabIndex = 3;
            this.lblCelsius.Text = "° Celsius";
            // 
            // gbxSum
            // 
            this.gbxSum.Controls.Add(this.rbDivision);
            this.gbxSum.Controls.Add(this.rbMultiplication);
            this.gbxSum.Controls.Add(this.rbSubtraction);
            this.gbxSum.Controls.Add(this.rbAddition);
            this.gbxSum.Controls.Add(this.lblResult);
            this.gbxSum.Controls.Add(this.tbxResult);
            this.gbxSum.Controls.Add(this.lblValue5);
            this.gbxSum.Controls.Add(this.lblValue4);
            this.gbxSum.Controls.Add(this.lblValue3);
            this.gbxSum.Controls.Add(this.lblValue2);
            this.gbxSum.Controls.Add(this.lblValue1);
            this.gbxSum.Controls.Add(this.nudValue5);
            this.gbxSum.Controls.Add(this.nudValue4);
            this.gbxSum.Controls.Add(this.nudValue3);
            this.gbxSum.Controls.Add(this.nudValue2);
            this.gbxSum.Controls.Add(this.nudValue1);
            this.gbxSum.Controls.Add(this.btnOperation);
            this.gbxSum.Location = new System.Drawing.Point(12, 164);
            this.gbxSum.Name = "gbxSum";
            this.gbxSum.Size = new System.Drawing.Size(263, 218);
            this.gbxSum.TabIndex = 1;
            this.gbxSum.TabStop = false;
            this.gbxSum.Text = "Operation";
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Location = new System.Drawing.Point(220, 100);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(31, 17);
            this.rbDivision.TabIndex = 23;
            this.rbDivision.TabStop = true;
            this.rbDivision.Text = "÷";
            this.rbDivision.UseVisualStyleBackColor = true;
            // 
            // rbMultiplication
            // 
            this.rbMultiplication.AutoSize = true;
            this.rbMultiplication.Location = new System.Drawing.Point(220, 74);
            this.rbMultiplication.Name = "rbMultiplication";
            this.rbMultiplication.Size = new System.Drawing.Size(31, 17);
            this.rbMultiplication.TabIndex = 22;
            this.rbMultiplication.TabStop = true;
            this.rbMultiplication.Text = "×";
            this.rbMultiplication.UseVisualStyleBackColor = true;
            // 
            // rbSubtraction
            // 
            this.rbSubtraction.AutoSize = true;
            this.rbSubtraction.Location = new System.Drawing.Point(220, 48);
            this.rbSubtraction.Name = "rbSubtraction";
            this.rbSubtraction.Size = new System.Drawing.Size(28, 17);
            this.rbSubtraction.TabIndex = 21;
            this.rbSubtraction.TabStop = true;
            this.rbSubtraction.Text = "-";
            this.rbSubtraction.UseVisualStyleBackColor = true;
            // 
            // rbAddition
            // 
            this.rbAddition.AutoSize = true;
            this.rbAddition.Location = new System.Drawing.Point(220, 22);
            this.rbAddition.Name = "rbAddition";
            this.rbAddition.Size = new System.Drawing.Size(31, 17);
            this.rbAddition.TabIndex = 20;
            this.rbAddition.Text = "+";
            this.rbAddition.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(19, 181);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 19;
            this.lblResult.Text = "Result";
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(79, 178);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.Size = new System.Drawing.Size(166, 20);
            this.tbxResult.TabIndex = 18;
            // 
            // lblValue5
            // 
            this.lblValue5.AutoSize = true;
            this.lblValue5.Location = new System.Drawing.Point(22, 125);
            this.lblValue5.Name = "lblValue5";
            this.lblValue5.Size = new System.Drawing.Size(43, 13);
            this.lblValue5.TabIndex = 17;
            this.lblValue5.Text = "Value 5";
            // 
            // lblValue4
            // 
            this.lblValue4.AutoSize = true;
            this.lblValue4.Location = new System.Drawing.Point(22, 99);
            this.lblValue4.Name = "lblValue4";
            this.lblValue4.Size = new System.Drawing.Size(43, 13);
            this.lblValue4.TabIndex = 16;
            this.lblValue4.Text = "Value 4";
            // 
            // lblValue3
            // 
            this.lblValue3.AutoSize = true;
            this.lblValue3.Location = new System.Drawing.Point(22, 73);
            this.lblValue3.Name = "lblValue3";
            this.lblValue3.Size = new System.Drawing.Size(43, 13);
            this.lblValue3.TabIndex = 15;
            this.lblValue3.Text = "Value 3";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Location = new System.Drawing.Point(22, 47);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(43, 13);
            this.lblValue2.TabIndex = 14;
            this.lblValue2.Text = "Value 2";
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Location = new System.Drawing.Point(22, 21);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(43, 13);
            this.lblValue1.TabIndex = 8;
            this.lblValue1.Text = "Value 1";
            // 
            // nudValue5
            // 
            this.nudValue5.Location = new System.Drawing.Point(79, 123);
            this.nudValue5.Name = "nudValue5";
            this.nudValue5.Size = new System.Drawing.Size(120, 20);
            this.nudValue5.TabIndex = 13;
            // 
            // nudValue4
            // 
            this.nudValue4.Location = new System.Drawing.Point(79, 97);
            this.nudValue4.Name = "nudValue4";
            this.nudValue4.Size = new System.Drawing.Size(120, 20);
            this.nudValue4.TabIndex = 12;
            // 
            // nudValue3
            // 
            this.nudValue3.Location = new System.Drawing.Point(79, 71);
            this.nudValue3.Name = "nudValue3";
            this.nudValue3.Size = new System.Drawing.Size(120, 20);
            this.nudValue3.TabIndex = 11;
            // 
            // nudValue2
            // 
            this.nudValue2.Location = new System.Drawing.Point(79, 45);
            this.nudValue2.Name = "nudValue2";
            this.nudValue2.Size = new System.Drawing.Size(120, 20);
            this.nudValue2.TabIndex = 10;
            // 
            // nudValue1
            // 
            this.nudValue1.Location = new System.Drawing.Point(79, 19);
            this.nudValue1.Name = "nudValue1";
            this.nudValue1.Size = new System.Drawing.Size(120, 20);
            this.nudValue1.TabIndex = 9;
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(96, 149);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(75, 23);
            this.btnOperation.TabIndex = 8;
            this.btnOperation.Text = "Operation";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Location = new System.Drawing.Point(108, 388);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(75, 23);
            this.btnExitApplication.TabIndex = 2;
            this.btnExitApplication.Text = "Exit";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // frmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 423);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.gbxSum);
            this.Controls.Add(this.gbxTemperature);
            this.Name = "frmConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert";
            this.gbxTemperature.ResumeLayout(false);
            this.gbxTemperature.PerformLayout();
            this.gbxSum.ResumeLayout(false);
            this.gbxSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTemperature;
        private System.Windows.Forms.GroupBox gbxSum;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.TextBox tbxFahrenheit;
        private System.Windows.Forms.TextBox tbxCelsius;
        private System.Windows.Forms.Button btnConvertTemperature;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Label lblValue5;
        private System.Windows.Forms.Label lblValue4;
        private System.Windows.Forms.Label lblValue3;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.NumericUpDown nudValue5;
        private System.Windows.Forms.NumericUpDown nudValue4;
        private System.Windows.Forms.NumericUpDown nudValue3;
        private System.Windows.Forms.NumericUpDown nudValue2;
        private System.Windows.Forms.NumericUpDown nudValue1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.RadioButton rbMultiplication;
        private System.Windows.Forms.RadioButton rbSubtraction;
        private System.Windows.Forms.RadioButton rbAddition;
    }
}


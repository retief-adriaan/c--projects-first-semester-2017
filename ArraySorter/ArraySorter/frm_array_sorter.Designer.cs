namespace ArraySorter
{
    partial class frmArraySorter
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
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.btnGenArray = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxSortOrder = new System.Windows.Forms.GroupBox();
            this.rdbDescending = new System.Windows.Forms.RadioButton();
            this.rdbAscending = new System.Windows.Forms.RadioButton();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.nudNumElements = new System.Windows.Forms.NumericUpDown();
            this.lblElements = new System.Windows.Forms.Label();
            this.gbxSortOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumElements)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(124, 12);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(136, 300);
            this.tbxOutput.TabIndex = 0;
            // 
            // btnGenArray
            // 
            this.btnGenArray.Location = new System.Drawing.Point(12, 12);
            this.btnGenArray.Name = "btnGenArray";
            this.btnGenArray.Size = new System.Drawing.Size(106, 23);
            this.btnGenArray.TabIndex = 1;
            this.btnGenArray.Text = "Generate Array";
            this.btnGenArray.UseVisualStyleBackColor = true;
            this.btnGenArray.Click += new System.EventHandler(this.btnGenArray_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(12, 70);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(106, 23);
            this.btnQuickSort.TabIndex = 2;
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(12, 41);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(106, 23);
            this.btnBubbleSort.TabIndex = 3;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 289);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxSortOrder
            // 
            this.gbxSortOrder.Controls.Add(this.rdbDescending);
            this.gbxSortOrder.Controls.Add(this.rdbAscending);
            this.gbxSortOrder.Location = new System.Drawing.Point(12, 157);
            this.gbxSortOrder.Name = "gbxSortOrder";
            this.gbxSortOrder.Size = new System.Drawing.Size(106, 61);
            this.gbxSortOrder.TabIndex = 6;
            this.gbxSortOrder.TabStop = false;
            this.gbxSortOrder.Text = "Sort Order";
            // 
            // rdbDescending
            // 
            this.rdbDescending.AutoSize = true;
            this.rdbDescending.Location = new System.Drawing.Point(3, 39);
            this.rdbDescending.Name = "rdbDescending";
            this.rdbDescending.Size = new System.Drawing.Size(82, 17);
            this.rdbDescending.TabIndex = 1;
            this.rdbDescending.TabStop = true;
            this.rdbDescending.Text = "Descending";
            this.rdbDescending.UseVisualStyleBackColor = true;
            // 
            // rdbAscending
            // 
            this.rdbAscending.AutoSize = true;
            this.rdbAscending.Location = new System.Drawing.Point(3, 16);
            this.rdbAscending.Name = "rdbAscending";
            this.rdbAscending.Size = new System.Drawing.Size(75, 17);
            this.rdbAscending.TabIndex = 0;
            this.rdbAscending.TabStop = true;
            this.rdbAscending.Text = "Ascending";
            this.rdbAscending.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(12, 99);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(106, 23);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "Display Array";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // nudNumElements
            // 
            this.nudNumElements.Location = new System.Drawing.Point(12, 250);
            this.nudNumElements.Name = "nudNumElements";
            this.nudNumElements.Size = new System.Drawing.Size(106, 20);
            this.nudNumElements.TabIndex = 7;
            // 
            // lblElements
            // 
            this.lblElements.AutoSize = true;
            this.lblElements.Location = new System.Drawing.Point(9, 221);
            this.lblElements.Name = "lblElements";
            this.lblElements.Size = new System.Drawing.Size(101, 26);
            this.lblElements.TabIndex = 8;
            this.lblElements.Text = "Number of elements\r\n(10-100)";
            // 
            // frmArraySorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 324);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblElements);
            this.Controls.Add(this.nudNumElements);
            this.Controls.Add(this.gbxSortOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnGenArray);
            this.Controls.Add(this.tbxOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmArraySorter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array Sorter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArraySorter_FormClosing);
            this.gbxSortOrder.ResumeLayout(false);
            this.gbxSortOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumElements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Button btnGenArray;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxSortOrder;
        private System.Windows.Forms.RadioButton rdbDescending;
        private System.Windows.Forms.RadioButton rdbAscending;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.NumericUpDown nudNumElements;
        private System.Windows.Forms.Label lblElements;
    }
}


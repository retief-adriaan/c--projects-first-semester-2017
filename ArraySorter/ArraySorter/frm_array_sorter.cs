// created by ADRIAAN RETIEF on 16/03/2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySorter
{
    public partial class frmArraySorter : Form
    {
        public frmArraySorter()
        {
            // initialize form
            InitializeComponent();
            // initialize button states
            btnGenArray.Enabled = true;
            btnBubbleSort.Enabled = false;
            btnQuickSort.Enabled = false;
            btnClear.Enabled = false;
            btnExit.Enabled = true;
            // initialize radio buttons, set default
            rdbAscending.Enabled = true;
            rdbDescending.Enabled = true;
            rdbAscending.Checked = true;
            rdbDescending.Checked = false;
            // set range for nud
            nudNumElements.Minimum = 10;
            nudNumElements.Maximum = 100;
            nudNumElements.Value = 10;
            // clear output
            tbxOutput.Clear();

            // disable nud and label because the associated code deosn't work
            nudNumElements.Enabled = false;
            lblElements.Enabled = false;
        }

        // global constants 
        //const int NUM_ELEMENTS = nudNumElements.Value;
        const int NUM_ELEMENTS = 40;
        const int LOW_BOUND = 0;
        const int UPP_BOUND = 100;
        // array 
        int[] elements = new int[NUM_ELEMENTS];
        // random element
        Random rand = new Random();

        private void btnGenArray_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NUM_ELEMENTS; i++)
            {
                elements[i] = rand.Next(LOW_BOUND, UPP_BOUND);
            }
            DisplayArray("Array before sorting:");
            // enable sorting and clear buttons
            btnBubbleSort.Enabled = true;
            btnQuickSort.Enabled = true;
            btnClear.Enabled = true;
        }

        public void DisplayArray(string state)
        {
            // write contents of array to output
            tbxOutput.Clear();
            tbxOutput.Text += state;
            for (int i = 0; i < NUM_ELEMENTS; i++)
            {
                tbxOutput.Text += "\r\n" + elements[i];
            }            
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            int temp = 0;
            bool swap = true;

            // bubble sort process
            while (swap)
            {
                swap = false;
                for (int i = 0; i < NUM_ELEMENTS-1; i++)
                {
                    if (rdbAscending.Checked)
                    {
                        if (elements[i] > elements[i + 1])
                        {
                            temp = elements[i];
                            elements[i] = elements[i + 1];
                            elements[i + 1] = temp;
                            swap = true;
                        }
                    }
                    else
                    {
                        if (elements[i] < elements[i + 1])
                        {
                            temp = elements[i];
                            elements[i] = elements[i + 1];
                            elements[i + 1] = temp;
                            swap = true;
                        }
                    }
                }
            }
            btnBubbleSort.Enabled = false;
            btnQuickSort.Enabled = false;
            DisplayArray("Array after sorting:");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // resets button states, clears output, nullifies array
            tbxOutput.Clear();
            btnGenArray.Enabled = true;
            btnQuickSort.Enabled = false;
            btnBubbleSort.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            QuickSort(0, NUM_ELEMENTS-1);
            btnBubbleSort.Enabled = false;
            btnQuickSort.Enabled = false;
            DisplayArray("Array after sorting");
        }

        public void QuickSort(int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            // quick sort process
            while (i <= j)
            {
                if (rdbAscending.Checked)
                {
                    while (elements[i].CompareTo(pivot) < 0) i++;
                    while (elements[j].CompareTo(pivot) > 0) j--;
                }
                else
                {
                    while (elements[i].CompareTo(pivot) > 0) i++;
                    while (elements[j].CompareTo(pivot) < 0) j--;
                }

                if (i <= j)
                {
                    int temp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = temp;
                    i++; j--;
                }
            }
            if (left < j) QuickSort(left, j);
            if (right > i) QuickSort(i, right);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayArray("Array in its current state:");
        }

        private void frmArraySorter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

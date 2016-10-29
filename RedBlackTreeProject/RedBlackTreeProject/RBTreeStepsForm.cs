using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedBlackTreeProject
{
    public partial class RBTreeStepsForm : Form
    {
        private int stepNumber = 1;
        private int subStepNumber = 1;
        public RBTreeStepsForm()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            stepNumber = 1;
            subStepNumber = 1;
            rtbSteps.Clear();
        }

        public void AddStep(string step)
        {
            if (rtbSteps.Text.Length == 0)
            {
                rtbSteps.Text = "Koraci algoritma:";
            }
            rtbSteps.Text += string.Format("\n{0}. {1}\n", stepNumber++, step);
            subStepNumber = 1;
        }

        public void AddSubStep(string subStep)
        {
            rtbSteps.Text += "\t" + subStepNumber++ + ") " + subStep + "\n";
        }

        private void RBTreeStepsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}

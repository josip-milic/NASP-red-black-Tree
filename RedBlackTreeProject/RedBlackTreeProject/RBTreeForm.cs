using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedBlackTreeProject
{
    public partial class RBTreeForm : Form
    {
        private RBTree rbTree;
        private List<int> addIntegers;
        private List<int> removeIntegers;
        RBTreeStepsForm stepsForm;
        Boolean stepsFormShown = true;
        Boolean lastActionIsAdd = true;
        int actionValue;
        string printBorder = new string('-', 100) + "\n";

        private string btnAddDefText = "Dodaj sljedeći broj";
        private string btnRemoveDefText = "Obriši sljedeći broj";

        public RBTreeForm()
        {
            InitializeComponent();
        }

        private void RBTreeForm_Load(object sender, EventArgs e)
        {
            stepsForm = new RBTreeStepsForm();
            stepsForm.Show();
            rbTree = new RBTree(stepsForm);
            addIntegers = new List<int>();
            removeIntegers = new List<int>();
        }

        private void tbDirTextUpdate(TextBox tbDir)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Tekstualna datoteka|*.txt|Sve datoteke (*.*)|*.*";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbDir.Text = ofd.FileName;
            }
        }

        private void btnDirAdd_Click(object sender, EventArgs e)
        {
            tbDirTextUpdate(tbDirAdd);
        }

        private void btnDirRemove_Click(object sender, EventArgs e)
        {
        
            tbDirTextUpdate(tbDirRemove);
        }

        private void PrintTree()
        {
            if (cbContinous.Checked)
            {
                if (!rtbTree.Text.EndsWith("-\n"))
                {
                    rtbTree.Text += printBorder;
                }
                rtbTree.Text += string.Format("Nakon {0} vrijednosti {1}:\n", lastActionIsAdd ? "dodavanja" : "brisanja", actionValue);
                rtbTree.Text += rbTree.ToString();
                rtbTree.Text += printBorder;
            }
            else
            {
                rtbTree.Text = rbTree.ToString();
            }
        }

        private void btnAddSingle_Click(object sender, EventArgs e)
        {
            lastActionIsAdd = true;
            actionValue = addIntegers.ElementAt(0);
            rbTree.AddElement(actionValue);
            addIntegers.RemoveAt(0);
            PrintTree();
            if (addIntegers.Count == 0)
            {
                btnAddSingle.Enabled = false;
                btnAddSingle.Text = btnAddDefText;
            }
            else
            {
                btnAddSingle.Text = btnAddDefText + ": " + addIntegers.ElementAt(0);
            }
            tbAddNumbers.Text = String.Join(", ", addIntegers.Select(item => item.ToString()).ToArray());
        }

        private void btnRemoveSingle_Click(object sender, EventArgs e)
        {
            lastActionIsAdd = false;
            actionValue = removeIntegers.ElementAt(0);
            rbTree.RemoveElement(actionValue);
            removeIntegers.RemoveAt(0);
            PrintTree();
            if (removeIntegers.Count == 0)
            {
                btnRemoveSingle.Enabled = false;
                btnRemoveSingle.Text = btnRemoveDefText;
            }
            else
            {
                btnRemoveSingle.Text = btnRemoveDefText + ": " + removeIntegers.ElementAt(0);
            }
            tbRemoveNumbers.Text = String.Join(", ", removeIntegers.Select(item => item.ToString()).ToArray());
        }

        private void btnLoadAdd_Click(object sender, EventArgs e)
        {
            if (!cbAdd.Checked)
            {
                addIntegers.Clear();
            }
            try
            {
                using (StreamReader sr = new StreamReader(tbDirAdd.Text))
                {
                    string line = sr.ReadLine();
                    String[] numberStrings = line.Split(' ');
                    foreach (string numberString in numberStrings)
                    {
                        addIntegers.Add(Int32.Parse(numberString));
                    }
                    btnAddSingle.Enabled = true;
                }
            }
            catch (Exception ex) when (ex is System.ArgumentException || ex is FileNotFoundException)
            {
                if (tbDirAdd.Text.Trim().Count() == 0) return;
                MessageBox.Show("Datoteka '"+tbDirAdd.Text+"' nije pronađena!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbAddNumbers.Text = String.Join(", ", addIntegers.Select(item => item.ToString()).ToArray());
            if (addIntegers.Count != 0)
            {
                btnAddSingle.Text = btnAddDefText + ": " + addIntegers.ElementAt(0);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stepsForm.Reset();
            rbTree.Reset();
            RBTree.ResetDefaultLength();
            rtbTree.Clear();
        }

        private void btnLoadRemove_Click(object sender, EventArgs e)
        {
            if (!cbRemove.Checked)
            {
                removeIntegers.Clear();
            }

            try
            {
                using (StreamReader sr = new StreamReader(tbDirRemove.Text))
                {
                    string line = sr.ReadLine();
                    String[] numberStrings = line.Split(' ');
                    foreach (string numberString in numberStrings)
                    {
                        removeIntegers.Add(Int32.Parse(numberString));
                    }
                    btnRemoveSingle.Enabled = true;

                }
            }
            catch (Exception ex) when (ex is System.ArgumentException || ex is FileNotFoundException)
            {
                if (tbDirRemove.Text.Trim().Count() == 0) return;
                MessageBox.Show("Datoteka '" + tbDirRemove.Text + "' nije pronađena!", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (removeIntegers.Count !=0)
            {
                btnRemoveSingle.Text = btnRemoveDefText + ": " + removeIntegers.ElementAt(0);
            }

            tbRemoveNumbers.Text = String.Join(", ", removeIntegers.Select(item => item.ToString()).ToArray());
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            while (addIntegers.Count != 0)
            {
                btnAddSingle_Click(sender, e);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            while (removeIntegers.Count != 0)
            {
                btnRemoveSingle_Click(sender, e);
            }
        }

        private void btnSteps_Click(object sender, EventArgs e)
        {
            if (!stepsFormShown)
            {
                stepsForm.Show();
                stepsFormShown = true;
            }
            else
            {
                stepsForm.Hide();
                stepsFormShown = false;
            }
        }

        private void btnDeleteTree_Click(object sender, EventArgs e)
        {
            rbTree.Reset();
            RBTree.ResetDefaultLength();
            rtbTree.Text = "Obrisali su se svi čvorovi stabla.\n";
            stepsForm.AddStep("Brišu se svi čvorovi stabla.");
        }
    }
}

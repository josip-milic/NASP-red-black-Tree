namespace RedBlackTreeProject
{
    partial class RBTreeForm
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
            this.tbDirAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDirRemove = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSingle = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rtbTree = new System.Windows.Forms.RichTextBox();
            this.btnRemoveSingle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDirRemove = new System.Windows.Forms.Button();
            this.btnDirAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRemoveNumbers = new System.Windows.Forms.TextBox();
            this.tbAddNumbers = new System.Windows.Forms.TextBox();
            this.cbRemove = new System.Windows.Forms.CheckBox();
            this.cbAdd = new System.Windows.Forms.CheckBox();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnSteps = new System.Windows.Forms.Button();
            this.cbContinous = new System.Windows.Forms.CheckBox();
            this.btnDeleteTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDirAdd
            // 
            this.tbDirAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDirAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDirAdd.Location = new System.Drawing.Point(129, 9);
            this.tbDirAdd.Name = "tbDirAdd";
            this.tbDirAdd.Size = new System.Drawing.Size(401, 20);
            this.tbDirAdd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datoteka za dodavanje:";
            // 
            // tbDirRemove
            // 
            this.tbDirRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDirRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDirRemove.Location = new System.Drawing.Point(129, 44);
            this.tbDirRemove.Name = "tbDirRemove";
            this.tbDirRemove.Size = new System.Drawing.Size(401, 20);
            this.tbDirRemove.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datoteka za brisanje:";
            // 
            // btnAddSingle
            // 
            this.btnAddSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddSingle.Enabled = false;
            this.btnAddSingle.Location = new System.Drawing.Point(271, 402);
            this.btnAddSingle.Name = "btnAddSingle";
            this.btnAddSingle.Size = new System.Drawing.Size(194, 23);
            this.btnAddSingle.TabIndex = 5;
            this.btnAddSingle.Text = "Dodaj  sljedeći broj";
            this.btnAddSingle.UseVisualStyleBackColor = true;
            this.btnAddSingle.Click += new System.EventHandler(this.btnAddSingle_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Location = new System.Drawing.Point(5, 402);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Obriši sve";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rtbTree
            // 
            this.rtbTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTree.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTree.Location = new System.Drawing.Point(5, 76);
            this.rtbTree.Name = "rtbTree";
            this.rtbTree.ReadOnly = true;
            this.rtbTree.Size = new System.Drawing.Size(730, 272);
            this.rtbTree.TabIndex = 7;
            this.rtbTree.Text = "";
            this.rtbTree.WordWrap = false;
            // 
            // btnRemoveSingle
            // 
            this.btnRemoveSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveSingle.Enabled = false;
            this.btnRemoveSingle.Location = new System.Drawing.Point(471, 402);
            this.btnRemoveSingle.Name = "btnRemoveSingle";
            this.btnRemoveSingle.Size = new System.Drawing.Size(194, 23);
            this.btnRemoveSingle.TabIndex = 8;
            this.btnRemoveSingle.Text = "Obriši  sljedeći broj";
            this.btnRemoveSingle.UseVisualStyleBackColor = true;
            this.btnRemoveSingle.Click += new System.EventHandler(this.btnRemoveSingle_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::RedBlackTreeProject.Properties.Resources.load_icon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(565, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 24);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnLoadRemove_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::RedBlackTreeProject.Properties.Resources.load_icon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(565, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 24);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnLoadAdd_Click);
            // 
            // btnDirRemove
            // 
            this.btnDirRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnDirRemove.BackgroundImage = global::RedBlackTreeProject.Properties.Resources.dir_add_icon;
            this.btnDirRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirRemove.Location = new System.Drawing.Point(536, 41);
            this.btnDirRemove.Name = "btnDirRemove";
            this.btnDirRemove.Size = new System.Drawing.Size(25, 24);
            this.btnDirRemove.TabIndex = 1;
            this.btnDirRemove.UseVisualStyleBackColor = false;
            this.btnDirRemove.Click += new System.EventHandler(this.btnDirRemove_Click);
            // 
            // btnDirAdd
            // 
            this.btnDirAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnDirAdd.BackgroundImage = global::RedBlackTreeProject.Properties.Resources.dir_add_icon;
            this.btnDirAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirAdd.Location = new System.Drawing.Point(536, 6);
            this.btnDirAdd.Name = "btnDirAdd";
            this.btnDirAdd.Size = new System.Drawing.Size(25, 24);
            this.btnDirAdd.TabIndex = 1;
            this.btnDirAdd.UseVisualStyleBackColor = false;
            this.btnDirAdd.Click += new System.EventHandler(this.btnDirAdd_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sljedeći brojevi za dodavanje:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sljedeći brojevi za brisanje:";
            // 
            // tbRemoveNumbers
            // 
            this.tbRemoveNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRemoveNumbers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbRemoveNumbers.Location = new System.Drawing.Point(159, 375);
            this.tbRemoveNumbers.Name = "tbRemoveNumbers";
            this.tbRemoveNumbers.ReadOnly = true;
            this.tbRemoveNumbers.Size = new System.Drawing.Size(541, 20);
            this.tbRemoveNumbers.TabIndex = 15;
            // 
            // tbAddNumbers
            // 
            this.tbAddNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddNumbers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAddNumbers.Location = new System.Drawing.Point(159, 351);
            this.tbAddNumbers.Name = "tbAddNumbers";
            this.tbAddNumbers.ReadOnly = true;
            this.tbAddNumbers.Size = new System.Drawing.Size(541, 20);
            this.tbAddNumbers.TabIndex = 16;
            // 
            // cbRemove
            // 
            this.cbRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRemove.AutoSize = true;
            this.cbRemove.Location = new System.Drawing.Point(596, 44);
            this.cbRemove.Name = "cbRemove";
            this.cbRemove.Size = new System.Drawing.Size(104, 17);
            this.cbRemove.TabIndex = 18;
            this.cbRemove.Text = "Zadrži postojeće";
            this.cbRemove.UseVisualStyleBackColor = true;
            // 
            // cbAdd
            // 
            this.cbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAdd.AutoSize = true;
            this.cbAdd.Location = new System.Drawing.Point(596, 10);
            this.cbAdd.Name = "cbAdd";
            this.cbAdd.Size = new System.Drawing.Size(104, 17);
            this.cbAdd.TabIndex = 17;
            this.cbAdd.Text = "Zadrži postojeće";
            this.cbAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddAll
            // 
            this.btnAddAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAll.Location = new System.Drawing.Point(703, 350);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(31, 23);
            this.btnAddAll.TabIndex = 19;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAll.Location = new System.Drawing.Point(703, 374);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(31, 23);
            this.btnRemoveAll.TabIndex = 20;
            this.btnRemoveAll.Text = ">>";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnSteps
            // 
            this.btnSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSteps.BackColor = System.Drawing.Color.Transparent;
            this.btnSteps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSteps.Location = new System.Drawing.Point(703, 403);
            this.btnSteps.Name = "btnSteps";
            this.btnSteps.Size = new System.Drawing.Size(31, 24);
            this.btnSteps.TabIndex = 21;
            this.btnSteps.Text = "#";
            this.btnSteps.UseVisualStyleBackColor = false;
            this.btnSteps.Click += new System.EventHandler(this.btnSteps_Click);
            // 
            // cbContinous
            // 
            this.cbContinous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbContinous.AutoSize = true;
            this.cbContinous.Location = new System.Drawing.Point(10, 328);
            this.cbContinous.Name = "cbContinous";
            this.cbContinous.Size = new System.Drawing.Size(85, 17);
            this.cbContinous.TabIndex = 22;
            this.cbContinous.Text = "Crtaj slijedno";
            this.cbContinous.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTree
            // 
            this.btnDeleteTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteTree.Location = new System.Drawing.Point(104, 402);
            this.btnDeleteTree.Name = "btnDeleteTree";
            this.btnDeleteTree.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteTree.TabIndex = 23;
            this.btnDeleteTree.Text = "Obriši sve čvorove";
            this.btnDeleteTree.UseVisualStyleBackColor = true;
            this.btnDeleteTree.Click += new System.EventHandler(this.btnDeleteTree_Click);
            // 
            // RBTreeForm
            // 
            this.AcceptButton = this.btnAddSingle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 432);
            this.Controls.Add(this.btnDeleteTree);
            this.Controls.Add(this.cbContinous);
            this.Controls.Add(this.btnSteps);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.cbRemove);
            this.Controls.Add(this.cbAdd);
            this.Controls.Add(this.tbRemoveNumbers);
            this.Controls.Add(this.tbAddNumbers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnRemoveSingle);
            this.Controls.Add(this.rtbTree);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddSingle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDirRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDirRemove);
            this.Controls.Add(this.btnDirAdd);
            this.Controls.Add(this.tbDirAdd);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "RBTreeForm";
            this.Text = "Crveno crno stablo";
            this.Load += new System.EventHandler(this.RBTreeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDirAdd;
        private System.Windows.Forms.Button btnDirAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDirRemove;
        private System.Windows.Forms.Button btnDirRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSingle;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RichTextBox rtbTree;
        private System.Windows.Forms.Button btnRemoveSingle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRemoveNumbers;
        private System.Windows.Forms.TextBox tbAddNumbers;
        private System.Windows.Forms.CheckBox cbRemove;
        private System.Windows.Forms.CheckBox cbAdd;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnSteps;
        private System.Windows.Forms.CheckBox cbContinous;
        private System.Windows.Forms.Button btnDeleteTree;
    }
}


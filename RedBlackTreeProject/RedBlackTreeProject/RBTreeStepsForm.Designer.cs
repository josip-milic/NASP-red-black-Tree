namespace RedBlackTreeProject
{
    partial class RBTreeStepsForm
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
            this.rtbSteps = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbSteps
            // 
            this.rtbSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSteps.Location = new System.Drawing.Point(4, 2);
            this.rtbSteps.Name = "rtbSteps";
            this.rtbSteps.Size = new System.Drawing.Size(457, 256);
            this.rtbSteps.TabIndex = 0;
            this.rtbSteps.Text = "";
            this.rtbSteps.WordWrap = false;
            // 
            // RBTreeStepsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 261);
            this.Controls.Add(this.rtbSteps);
            this.Name = "RBTreeStepsForm";
            this.Text = "Koraci algoritma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RBTreeStepsForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSteps;
    }
}
namespace LabWork
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.labeltest1 = new System.Windows.Forms.Label();
            this.lblIndraj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diversity";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(86, 98);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close System";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labeltest1
            // 
            this.labeltest1.AutoSize = true;
            this.labeltest1.Location = new System.Drawing.Point(12, 9);
            this.labeltest1.Name = "labeltest1";
            this.labeltest1.Size = new System.Drawing.Size(24, 13);
            this.labeltest1.TabIndex = 2;
            this.labeltest1.Text = "test";
            // 
            // lblIndraj
            // 
            this.lblIndraj.AutoSize = true;
            this.lblIndraj.Location = new System.Drawing.Point(99, 173);
            this.lblIndraj.Name = "lblIndraj";
            this.lblIndraj.Size = new System.Drawing.Size(33, 13);
            this.lblIndraj.TabIndex = 3;
            this.lblIndraj.Text = "Indraj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblIndraj);
            this.Controls.Add(this.labeltest1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labeltest1;
        private System.Windows.Forms.Label lblIndraj;
    }
}


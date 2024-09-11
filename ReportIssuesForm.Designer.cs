namespace MunicipalServicesApp
{
    partial class ReportIssuesForm
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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ListBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(67, 57);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(117, 26);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.Text = "Enter location";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 20;
            this.cmbCategory.Items.AddRange(new object[] {
            "sanitation",
            "roads",
            "utilities"});
            this.cmbCategory.Location = new System.Drawing.Point(241, 108);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(144, 64);
            this.cmbCategory.TabIndex = 1;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(241, 194);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(144, 65);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(254, 311);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(119, 35);
            this.btnAttach.TabIndex = 3;
            this.btnAttach.Text = "Attach File";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(614, 336);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(601, 372);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 5;
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtLocation);
            this.Name = "ReportIssuesForm";
            this.Text = "ReportIssuesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ListBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}
namespace MunicipalServiceApp
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
            this.comboBoxCategory = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblAttachmentPath = new System.Windows.Forms.Button();
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
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.ItemHeight = 20;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "sanitation",
            "roads",
            "utilities"});
            this.comboBoxCategory.Location = new System.Drawing.Point(241, 108);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(144, 64);
            this.comboBoxCategory.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(241, 194);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(144, 65);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // lblAttachmentPath
            // 
            this.lblAttachmentPath.Location = new System.Drawing.Point(254, 311);
            this.lblAttachmentPath.Name = "lblAttachmentPath";
            this.lblAttachmentPath.Size = new System.Drawing.Size(119, 35);
            this.lblAttachmentPath.TabIndex = 3;
            this.lblAttachmentPath.Text = "Attach File";
            this.lblAttachmentPath.UseVisualStyleBackColor = true;
            this.lblAttachmentPath.Click += new System.EventHandler(this.btnAttach_Click);
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
            this.Controls.Add(this.lblAttachmentPath);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.txtLocation);
            this.Name = "ReportIssuesForm";
            this.Text = "ReportIssuesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ListBox comboBoxCategory;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button lblAttachmentPath;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}
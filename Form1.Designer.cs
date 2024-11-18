namespace MunicipalServicesApp
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
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.localEventsButton = new System.Windows.Forms.Button();
            this.btnServiceRequestStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Location = new System.Drawing.Point(57, 39);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(134, 72);
            this.btnReportIssues.TabIndex = 0;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // localEventsButton
            // 
            this.localEventsButton.Location = new System.Drawing.Point(57, 130);
            this.localEventsButton.Name = "localEventsButton";
            this.localEventsButton.Size = new System.Drawing.Size(134, 73);
            this.localEventsButton.TabIndex = 1;
            this.localEventsButton.Text = "Local Events and Announcements";
            this.localEventsButton.UseVisualStyleBackColor = true;
            this.localEventsButton.Click += new System.EventHandler(this.btnLocalEvents_Click);
            // 
            // btnServiceRequestStatus
            // 
            this.btnServiceRequestStatus.Location = new System.Drawing.Point(57, 222);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new System.Drawing.Size(134, 73);
            this.btnServiceRequestStatus.TabIndex = 2;
            this.btnServiceRequestStatus.Text = "Service Request Status";
            this.btnServiceRequestStatus.UseVisualStyleBackColor = true;
            this.btnServiceRequestStatus.Click += new System.EventHandler(this.btnServiceRequestStatus_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(636, 357);
            this.Controls.Add(this.btnServiceRequestStatus);
            this.Controls.Add(this.localEventsButton);
            this.Controls.Add(this.btnReportIssues);
            this.Name = "Form1";
            this.Text = "Municipal Services";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button localEventsButton;
        private System.Windows.Forms.Button btnServiceRequestStatus;
    }
}

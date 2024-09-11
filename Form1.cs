using MunicipalServiceApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class Form1 : Form
    {
        // List to store reported issues
        private List<ReportedIssue> reportedIssues;

        public Form1()
        {
            InitializeComponent();
            reportedIssues = new List<ReportedIssue>(); // Initialize the list to store issues 
            // Disable buttons that are not yet implemented
            btnLocalEvents.Enabled = false;
            btnServiceRequestStatus.Enabled = false;
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // Open the Report Issues Form
            ReportIssuesForm reportForm = new ReportIssuesForm();
            reportForm.IssueReported += ReportForm_IssueReported; // Subscribe to the IssueReported event
            reportForm.Show();
        }

        // Event handler to capture reported issues from ReportIssuesForm
        private void ReportForm_IssueReported(object sender, ReportedIssue e)
        {
            reportedIssues.Add(e); // Add the reported issue to the list
            MessageBox.Show("Issue reported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Data structure to store reported issue details
    public class ReportedIssue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachmentPath { get; set; }
    }
}

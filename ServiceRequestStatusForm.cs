using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServiceApp
{
    public partial class ServiceRequestStatusForm : Form
    {
        // Simulated data structure to store service requests
        private Dictionary<string, (string Status, string Description)> serviceRequests;

        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            InitializeServiceRequests(); 
        }

        private void ServiceRequestStatusForm_Load(object sender, EventArgs e)
        {
        }

        private void InitializeServiceRequests()
        {
            
            serviceRequests = new Dictionary<string, (string Status, string Description)>
            {
                { "ABCD1", ("Pending", "Fixing a water leakage at Main Street") },
                { "EFGH2", ("Completed", "Resolved electricity outage at Park Avenue") },
                { "IJKL3", ("In Progress", "Road repair at Highfield Road") }
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string requestId = txtRequestId.Text.Trim();

            if (string.IsNullOrEmpty(requestId))
            {
                MessageBox.Show("Please enter a request ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (serviceRequests.TryGetValue(requestId, out var requestDetails))
            {
                lblRequestStatus.Text = requestDetails.Status;
                lblRequestDescription.Text = requestDetails.Description;
            }
            else
            {
                MessageBox.Show("Request ID not found. Please check the ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRequestStatus.Text = "N/A";
                lblRequestDescription.Text = "N/A";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear the input and output fields
            txtRequestId.Text = string.Empty;
            lblRequestStatus.Text = "N/A";
            lblRequestDescription.Text = "N/A";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close this form and return to the main menu
            this.Close();
        }
    }
}

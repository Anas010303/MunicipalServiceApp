using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ReportIssuesForm : Form
    {
        // Event to notify the main form when a new issue is reported
        public event EventHandler<ReportedIssue> IssueReported;

        // To store the path of the attached file
        private string attachmentPath = string.Empty;

        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        // Event handler for the Attach button
        private void btnAttach_Click(object sender, EventArgs e)
        {
            // Open file dialog to allow users to select an attachment
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|Document Files|*.doc;*.docx;*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Store the selected file path
                    attachmentPath = openFileDialog.FileName;
                    MessageBox.Show("File attached: " + attachmentPath, "Attachment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Event handler for the Submit button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve data from the form controls
            string location = txtLocation.Text;
            string category = cmbCategory.SelectedItem?.ToString();
            string description = rtbDescription.Text;

            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
            {
                // Show error message if any field is missing
                MessageBox.Show("Please fill in all fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new ReportedIssue object with the provided details
            ReportedIssue newIssue = new ReportedIssue
            {
                Location = location,
                Category = category,
                Description = description,
                AttachmentPath = attachmentPath
            };

            // Raise the IssueReported event to notify the main form
            IssueReported?.Invoke(this, newIssue);

            // Display a success message and close the form
            MessageBox.Show("Issue reported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

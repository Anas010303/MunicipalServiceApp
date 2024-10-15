using System;
using System.Windows.Forms;

namespace MunicipalServiceApp
{
    public partial class ReportIssuesForm : Form
    {
        // Constructor for the form
        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        // Event handler for the Submit button click event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the inputs from the form
            string location = txtLocation.Text;
            string category = comboBoxCategory.SelectedItem?.ToString();
            string description = txtDescription.Text;
            string attachmentPath = lblAttachmentPath.Text; // Assuming you store the attachment path in a label after attaching

            // Validate inputs
            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new ReportedIssue object and pass the values
            ReportedIssue newIssue = new ReportedIssue(location, category, description, attachmentPath);

            // Store the issue (you can save it to a list, database, or file depending on your app logic)
            SaveReportedIssue(newIssue);

            // Show a confirmation message
            MessageBox.Show("Issue reported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form inputs after submission
            ClearForm();
        }

        // Method to handle the attachment of media
        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"; // Specify file types allowed
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the file path
                    lblAttachmentPath.Text = openFileDialog.FileName;
                }
            }
        }

        // Helper method to save the reported issue (to a list, database, or file)
        private void SaveReportedIssue(ReportedIssue issue)
        {
            // Example: you could store this in a file, database, or in-memory list
            // Here we just print it to the console for now
            Console.WriteLine($"Location: {issue.Location}, Category: {issue.Category}, Description: {issue.Description}, Attachment: {issue.MediaAttachment}");
        }

        // Method to clear the form inputs after submitting an issue
        private void ClearForm()
        {
            txtLocation.Clear();
            comboBoxCategory.SelectedIndex = -1;
            txtDescription.Clear();
            lblAttachmentPath.Text = string.Empty;
        }
    }

    // Class to represent a reported issue
    public class ReportedIssue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MediaAttachment { get; set; }

        // Constructor to initialize all fields
        public ReportedIssue(string location, string category, string description, string mediaAttachment)
        {
            Location = location;
            Category = category;
            Description = description;
            MediaAttachment = mediaAttachment;
        }
    }
}

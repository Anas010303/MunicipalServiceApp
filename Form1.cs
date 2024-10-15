﻿using MunicipalServiceApp;
using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // Open ReportIssuesForm
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.ShowDialog();
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            // Open LocalEventsForm
            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.ShowDialog();
        }

        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Service Request Status will be implemented in Task 3.");
        }
    }
}

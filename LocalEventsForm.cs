using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class LocalEventsForm : Form
    {
        // Data structures to manage event information
        private SortedDictionary<DateTime, List<string>> eventDictionary;
        private HashSet<string> eventCategories;

        public LocalEventsForm()
        {
            InitializeComponent();
            InitializeDataStructures();
        }

        // Initialize data structures
        private void InitializeDataStructures()
        {
            eventDictionary = new SortedDictionary<DateTime, List<string>>();
            eventCategories = new HashSet<string>();

            // Sample data
            AddEvent(new DateTime(2024, 10, 18), "Festival", "City Park");
            AddEvent(new DateTime(2024, 11, 5), "Town Meeting", "Town Hall");
            AddEvent(new DateTime(2024, 12, 15), "Music Concert", "Stadium");

            // Populate category dropdown
            comboBoxCategory.Items.AddRange(eventCategories.ToArray());
        }

        // Add event to dictionary
        private void AddEvent(DateTime eventDate, string category, string description)
        {
            if (!eventDictionary.ContainsKey(eventDate))
            {
                eventDictionary[eventDate] = new List<string>();
            }

            eventDictionary[eventDate].Add($"{category}: {description}");
            eventCategories.Add(category);
        }

        // Search button handler
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listViewEvents.Items.Clear();

            // Get user inputs
            string selectedCategory = comboBoxCategory.SelectedItem?.ToString();
            DateTime selectedDate = dateTimePicker.Value.Date;

            bool foundMatch = false;

            // Search through events
            foreach (var eventEntry in eventDictionary)
            {
                if (eventEntry.Key == selectedDate || string.IsNullOrEmpty(selectedCategory))
                {
                    foreach (var eventDetail in eventEntry.Value)
                    {
                        if (eventDetail.Contains(selectedCategory))
                        {
                            listViewEvents.Items.Add(new ListViewItem($"{eventEntry.Key.ToShortDateString()} - {eventDetail}"));
                            foundMatch = true;
                        }
                    }
                }
            }

            // Recommendation if no matches found
            if (!foundMatch)
            {
                MessageBox.Show("No events found. Here are some recommended events.");
                // Display recommended events (all)
                foreach (var eventEntry in eventDictionary)
                {
                    foreach (var eventDetail in eventEntry.Value)
                    {
                        listViewEvents.Items.Add(new ListViewItem($"{eventEntry.Key.ToShortDateString()} - {eventDetail}"));
                    }
                }
            }
        }

        private void LocalEventsForm_Load(object sender, EventArgs e)
        {

        }
    }
}

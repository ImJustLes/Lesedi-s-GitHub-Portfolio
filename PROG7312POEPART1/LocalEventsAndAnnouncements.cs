using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312POEPART1
{
    public partial class LocalEventsAndAnnouncements : Form
    {
        //Initialisation of priority queue, dictionary and HashSet.
        private PriorityQueue<EventsAndAnnouncements, DateTime> eventQueue = new PriorityQueue<EventsAndAnnouncements, DateTime>();
        private Dictionary<string, List<EventsAndAnnouncements>> categoryDict = new Dictionary<string, List<EventsAndAnnouncements>>();
        private readonly HashSet<DateTime> uniqueDates = new HashSet<DateTime>();
        private Dictionary<string, List<string>> userPreferences = new Dictionary<string, List<string>>();

        public LocalEventsAndAnnouncements()
        {
            InitializeComponent();
            txtSearch.Focus();

            //Adds all events and announcements
            AddEvent(new EventsAndAnnouncements("Community Book Fair",
                "Browse a wide selection of books at discounted prices. Meet local authors and enjoy refreshments.",
                new DateTime(2024, 10, 26, 10, 0, 0), "Bryndale", "Community", 0));

            AddEvent(new EventsAndAnnouncements("Charity Art Auction",
                "Support a worthy cause and bid on beautiful artwork by local talents. Light refreshments will be served.",
                new DateTime(2024, 11, 09, 18, 0, 0), "Grand Ballroom, City Hall", "Charity", 0));

            AddEvent(new EventsAndAnnouncements("Free Yoga Class in the Park",
                "Join a certified instructor for a relaxing and rejuvenating yoga session in the fresh air.",
                new DateTime(2024, 10, 20, 9, 0, 0), "Jukskei Park", "Health & Wellness", 0));

            AddEvent(new EventsAndAnnouncements("Coding Workshop for Beginners",
                "Learn the basics of coding in a fun and interactive workshop. Perfect for those curious about programming.",
                new DateTime(2024, 10, 23, 14, 0, 0), "Community Center, Olivedale", "Technology", 0));

            AddAnnouncement(new EventsAndAnnouncements("School Closure - Teacher Professional Day",
                "All schools in the district will be closed for teacher professional development. No classes will be held.",
                new DateTime(2024, 10, 25, 0, 0, 0), null, "School", 0));

            AddAnnouncement(new EventsAndAnnouncements("Local Library Book Drive",
                "Donate your gently used books to support literacy programs in the community. Drop-off bins are located at all library branches.",
                new DateTime(2024, 10, 15, 0, 0, 0), null, "Community", 0));

            AddEvent(new EventsAndAnnouncements("Farmers Market",
                "Shop for fresh produce, local crafts, and delicious food from local vendors.",
                new DateTime(2024, 10, 27, 9, 0, 0), "Robyn Park", "Community", 0));

            AddEvent(new EventsAndAnnouncements("Movie Night Under the Stars",
                "Bring a blanket or lawn chair and enjoy a family-friendly movie outdoors.",
                new DateTime(2024, 11, 02, 19, 0, 0), "City Park Amphitheatre", "Entertainment", 0));

            AddEvent(new EventsAndAnnouncements("Hiking Trail Cleanup",
                "Help keep our local trails clean and beautiful. Gloves and trash bags will be provided.",
                new DateTime(2024, 10, 29, 8, 0, 0), "Norscot Koppies Nature Reserve", "Environmental", 0));

            AddAnnouncement(new EventsAndAnnouncements("Library Closure for Renovations",
                "The main library branch will be closed for renovations from November 4th to November 17th. Online resources and other branches remain open.",
                new DateTime(2024, 11, 04, 0, 0, 0), null, "Library", 0));

            AddEvent(new EventsAndAnnouncements("Fall Festival",
                "Celebrate the fall season with games, activities, and live music. Enjoy pumpkin carving, hayrides, and delicious food.",
                new DateTime(2024, 10, 31, 10, 0, 0), "Sandton City Square", "Family Fun", 0));

            AddAnnouncement(new EventsAndAnnouncements("Road Closure Due to Construction",
                "Main Street between 1st and 2nd Avenues will be closed to traffic from November 10th to November 15th for road construction. Detour signs will be posted.",
                new DateTime(2024, 11, 10, 0, 0, 0), null, "Traffic", 0));

            AddAnnouncement(new EventsAndAnnouncements("Job Fair",
                "Connect with local employers and explore job opportunities in various industries. The job fair will be held at the Community Center on October 28th.",
                new DateTime(2024, 10, 28, 0, 0, 0), "Community Center, Lonehill", "Job Search", 0));

            AddAnnouncement(new EventsAndAnnouncements("Blood Drive",
                "Donate blood and help save lives. The blood drive will be held at Town Hall on November 3rd. All donors will receive a complimentary snack and refreshments.",
                new DateTime(2024, 11, 03, 0, 0, 0), "Town Hall, Morningside", "Health", 0));

            AddAnnouncement(new EventsAndAnnouncements("Public Meeting on Proposed Zoning Changes",
                "Attend a public meeting to learn about proposed zoning changes in your neighborhood and provide your input. The meeting will be held at City Council Chambers on October 29th.",
                new DateTime(2024, 10, 29, 0, 0, 0), "City Council Chambers, Braamfontein", "Community", 0));

            AddAnnouncement(new EventsAndAnnouncements("Holiday Parade",
                "Join in the festive celebration with floats, marching bands, and Santa Claus! The holiday parade will be held on Main Street on December 1st.",
                new DateTime(2024, 12, 01, 0, 0, 0), "Sandton Roads", "Holiday", 0));

            //Diplays all the announcements and events.
            DisplayAllEvents();
        }

        //Returns a list of upcoming events in the form of a list
        private List<EventsAndAnnouncements> GetUpcomingEvents(int count)
        {
            var upcomingEvents = new List<EventsAndAnnouncements>();
            var tempQueue = new PriorityQueue<EventsAndAnnouncements, DateTime>();

            while (upcomingEvents.Count < count && tempQueue.TryDequeue(out var evt, out _))
            {
                if (evt.Date >= DateTime.Now)
                {
                    upcomingEvents.Add(evt);
                }
            }

            return upcomingEvents;
        }

        //Returns a list of events from the queue depending on what the user typed.
        private List<EventsAndAnnouncements> SearchEvents(string keyword)
        {
            return eventQueue.UnorderedItems
                .Where(e => e.Element.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            e.Element.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .Select(e => e.Element)
                .ToList();
        }

        //Adds the events into the priority queue, dictionary and unique dates get added into a hashSet
        private void AddEvent(EventsAndAnnouncements evt)
        {
            //Add to priority queue (sorted by date)
            eventQueue.Enqueue(evt, evt.Date);

            //Add to category dictionary
            if (!categoryDict.ContainsKey(evt.Category))
            {
                categoryDict[evt.Category] = new List<EventsAndAnnouncements>();
            }
            categoryDict[evt.Category].Add(evt);

            //Add to unique dates set
            uniqueDates.Add(evt.Date.Date);
        }

        //Returns the list of dates in order by date.
        public List<DateTime> GetUniqueDates()
        {
            return uniqueDates.OrderBy(d => d).ToList();
        }

        //Shows the events/announcements in the listbox
        private void DisplayFilteredEvents(List<EventsAndAnnouncements> events)
        {
            lstSearchResults.Items.Clear();
            foreach (var evt in events)
            {
                lstSearchResults.Items.Add($"{evt.Date.ToShortDateString()} - {evt.Title}");
            }
        }

        private void AddAnnouncement(EventsAndAnnouncements announcement)
        {
            //Sets the locations of announcements to null because annoucements don't have a location. 
            announcement.Location = null;
            AddEvent(announcement);
        }

        //Displays all the events in the listbox
        private void DisplayAllEvents()
        {
            lstSearchResults.Items.Clear();
            foreach (var evt in eventQueue.UnorderedItems.Select(e => e.Element))
            {
                lstSearchResults.Items.Add($"{evt.Date.ToShortDateString()} - {evt.Title}");
            }
        }

        private void UpdateUserPreferences(string searchTerm, EventsAndAnnouncements selectedEvent)
        {
            if (!userPreferences.ContainsKey(selectedEvent.Category))
            {
                userPreferences[selectedEvent.Category] = new List<string>();
            }
            userPreferences[selectedEvent.Category].Add(searchTerm);
        }

        //When a user selects an event/announcement in the listbox, it will show the details of the selected item in the details textbox
        private void lstSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSearchResults.SelectedIndex != -1)
            {
                // Get the selected item's text
                string selectedItemText = lstSearchResults.SelectedItem.ToString();

                // Find the corresponding event in the eventQueue
                var selectedEvent = eventQueue.UnorderedItems
                    .Select(item => item.Element)
                    .FirstOrDefault(evt => $"{evt.Date.ToShortDateString()} - {evt.Title}" == selectedItemText);

                if (selectedEvent != null)
                {
                    txtDescription.Text = $"{selectedEvent.Title}\n\n{selectedEvent.Description}\n\nDate: {selectedEvent.Date}\nLocation: {selectedEvent.Location ?? "N/A"}";

                    // Update user preferences and trigger recommendations
                    UpdateUserPreferences(txtSearch.Text, selectedEvent);
                    RecommendEvents(txtSearch.Text);
                }
            }
        }

        //Whenever a user makes a change to the text in the search bar, it will reflect the results in the listbox
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            var searchResults = SearchEvents(searchTerm);
            DisplayFilteredEvents(searchResults);
            RecommendEvents(searchTerm);
        }

        private void RecommendEvents(string searchTerm)
        {
            var searchResults = SearchEvents(searchTerm);
            var recommendations = new List<EventsAndAnnouncements>();

            foreach (var evt in searchResults)
            {
                int score = 0;

                if (userPreferences.ContainsKey(evt.Category))
                {
                    foreach (var keyword in userPreferences[evt.Category])
                    {
                        if (evt.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            evt.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                        {
                            score++;
                        }
                    }
                }

                if (score > 0)
                {
                    evt.RecommendationScore = score;
                    recommendations.Add(evt);
                }
            }

            // Sort recommendations by score (descending)
            recommendations.Sort((a, b) => b.RecommendationScore.CompareTo(a.RecommendationScore));

            // Display top N recommendations
            lstRecommendations.Items.Clear();
            int maxRecommendations = 5; // Configure the number of recommendations to display
            for (int i = 0; i < Math.Min(maxRecommendations, recommendations.Count); i++)
            {
                lstRecommendations.Items.Add($"{recommendations[i].Date.ToShortDateString()} - {recommendations[i].Title}");
            }
        }

        //Goes to the feedback page without closing the previous windows page
        private void lblSendFeedback_Click(object sender, EventArgs e)
        {
            Send_Feedback send_Feedback = new Send_Feedback();
            send_Feedback.ShowDialog();
        }

        //Returns to the main menu
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Close();
        }

        //Goes to the report issues page.
        private void reportIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Issues_Page report_Issues_Page = new Report_Issues_Page();
            report_Issues_Page.Show();
            Close();
        }
    }
}

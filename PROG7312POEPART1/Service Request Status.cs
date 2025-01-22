using System;
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
    public partial class Service_Request_Status : Form
    {
        private BinarySearchTree<ServiceRequest> allRequests = new BinarySearchTree<ServiceRequest>();
        private Heap<ServiceRequest> trackedRequests = new Heap<ServiceRequest>();

        public Service_Request_Status()
        {
            InitializeComponent();

            AddServiceRequest("Street Light Repair", "In Progress", "Faulty street light on Mandela Drive, Pretoria Central");
            AddServiceRequest("Refuse Collection", "Completed", "Missed weekly collection on Thabo Mbeki Street, Centurion");
            AddServiceRequest("Water Leak", "Pending", "Burst pipe on Jan Smuts Avenue, Randburg");
            AddServiceRequest("Pothole Repair", "In Progress", "Large pothole on Chris Hani Road near shopping centre");
            AddServiceRequest("Illegal Dumping", "Pending", "Waste dumped on vacant lot in Mamelodi East");
            AddServiceRequest("Power Outage", "In Progress", "No electricity in Soshanguve Block H since morning");
            AddServiceRequest("Grass Cutting", "Completed", "Overgrown grass in park on Solomon Mahlangu Drive");
            AddServiceRequest("Storm Water Drain", "Pending", "Blocked drain causing flooding on Steve Biko Road");
            AddServiceRequest("Traffic Light Fault", "In Progress", "Non-functioning robot at William Nicol and Sandton Drive intersection");
            AddServiceRequest("Meter Reading", "Completed", "Request for water meter reading in Waterkloof Heights");
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            string selectedString = lstServices.SelectedItem?.ToString();
            if (selectedString != null)
            {
                // Find the selected service request
                ServiceRequest request = allRequests.Find(x => x.ToString() == selectedString);
                if (request != null)
                {
                    // Check if this request is already being tracked
                    bool isAlreadyTracked = false;

                    // Check if it exists in the tracked ListBox
                    foreach (var item in lstTrackedServices.Items)
                    {
                        if (item.ToString() == request.ToString())
                        {
                            isAlreadyTracked = true;
                            break;
                        }
                    }

                    if (isAlreadyTracked)
                    {
                        MessageBox.Show("This service request is already being tracked!", "Duplicate Track", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // If not tracked, add it to tracked requests
                        trackedRequests.Insert(request);
                        lstTrackedServices.Items.Add(request.ToString());
                        DisplayServiceRequestDetails(request);
                    }
                }
            }
        }

        private void lstServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedString = lstServices.SelectedItem?.ToString();
            if (selectedString != null)
            {
                // Assuming your allRequests.Find method can search based on the ToString() representation
                ServiceRequest selectedRequest = allRequests.Find(x => x.ToString().Equals(selectedString));
                if (selectedRequest != null)
                {
                    DisplayServiceRequestDetails(selectedRequest);
                }
            }
        }

        private void lstTrackedServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTrackedServices.SelectedItem is string selectedRequestString)
            {
                ServiceRequest selectedRequest = trackedRequests.Find(selectedRequestString);
                DisplayServiceRequestDetails(selectedRequest);
            }
        }

        private void DisplayServiceRequestDetails(ServiceRequest request)
        {
            txtDescription.Text = $"Name: {request.Name}\n" +
                             $"Status: {request.Status}\n" +
                             $"Description: {request.Description}";
        }

        private void AddServiceRequest(string name, string status, string description)
        {
            ServiceRequest request = new ServiceRequest
            {
                Name = name,
                Status = status,
                Description = description
            };

            allRequests.Insert(request);
            lstServices.Items.Add(request);
        }

        private void lblSendFeedback_Click(object sender, EventArgs e)
        {
            Send_Feedback send_Feedback = new Send_Feedback();

            //Opens the send feedback window while keeping the report issues window open in the background.
            send_Feedback.ShowDialog();
        }

        private void btn_events_Click(object sender, EventArgs e)
        {
            try
            {
                LocalEventsAndAnnouncements eventsWindow = new LocalEventsAndAnnouncements();
                eventsWindow.Show();
                Hide();
            }
            catch (Exception ex)
            {
                //Error message if an error occurs.
                MessageBox.Show("Please inform one of the developers about the following error:\n" + ex.ToString(), "ERROR");
            }

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            try
            {
                Report_Issues_Page rep = new Report_Issues_Page();
                rep.Show();
                Hide();
            }
            catch (Exception ex)
            {
                //Error message if an error occurs.
                MessageBox.Show("Please inform one of the developers about the following error:\n" + ex.ToString(), "ERROR");
            }
        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 mm = new Form1();
                mm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                //Error message if an error occurs.
                MessageBox.Show("Please inform one of the developers about the following error:\n" + ex.ToString(), "ERROR");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }           
        }
    }
}

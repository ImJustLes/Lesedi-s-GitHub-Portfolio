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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Click event that handles opening the report issues window.
        private void btn_report_Click_1(object sender, EventArgs e)
        {
            try
            {
                Report_Issues_Page report_Issues_Page = new Report_Issues_Page();

                //Opens the report issue page
                report_Issues_Page.Show();

                //Closes/hides the main menu
                this.Hide();
            }
            catch (Exception ex)
            {
                //Error message if an error occurs.
                MessageBox.Show("Please inform one of the developers about the following error:\n" + ex.ToString(), "ERROR");
            }
        }

        //Click event that handles opening the send feedback window.
        private void btnFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                Send_Feedback send_Feedback = new Send_Feedback();

                //Opens the send feedback window
                send_Feedback.Show();

                //Closes/hides the main menu
                this.Hide();
            }
            catch (Exception ex)
            {
                //Error message if an error occurs.
                MessageBox.Show("Please inform one of the developers about the following error:\n" + ex.ToString(), "ERROR");
            }
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

        private void btn_req_Click(object sender, EventArgs e)
        {
            try
            {
                Service_Request_Status srs = new Service_Request_Status();
                srs.Show();
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

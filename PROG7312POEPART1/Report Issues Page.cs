using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace PROG7312POEPART1
{
    public partial class Report_Issues_Page : Form
    {
        //List of quotes used in the report issues window.
        List<string> quotes = new List<string>()
        {
            "You can do this!",
            "Keep going, you're almost there.",
            "Believe in yourself.",
            "Never give up on your dreams.",
            "You're stronger than you think.",
            "Every challenge is an opportunity to grow.",
            "Don't let anyone tell you that you can't.",
            "You've got this!",
            "Keep your head up, better days are coming.",
            "You are capable of amazing things."
        };

        //Initializations of objects.
        List<Issue> issue = new List<Issue>();
        Random rnd = new Random();
        Form1 form = new Form1();
        OpenFileDialog ofd = new OpenFileDialog();

        //String used to prevent repeat quotes from occuring.
        string previousQuote;

        public Report_Issues_Page()
        {
            InitializeComponent();

            //Automatically allows the user to type in the Location textbox after the window opens
            txtLocation.Focus();
            EncouragmentQuotes();
        }

        //Click event used to handle submitting issues.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Content from textboxes is retrieved into strings.
                string location = txtLocation.Text;
                string category = lstCategory.Text;
                string description = txtDescription.Text;

                //If any of the fields are empty, the user will be prompted with an error message.
                if (location.Equals("") || category.Equals(null) || description.Equals(""))
                {
                    MessageBox.Show("Please input all required fields.", "ERROR");
                }
                else
                {
                    //If all required fields have been filled, the issue will be added into the list
                    issue.Add(new Issue(txtLocation.Text, lstCategory.Text, txtDescription.Text, ofd.FileName));

                    //Defaults the textboxes, lists and media.
                    txtLocation.Clear();
                    lstCategory.ClearSelected();
                    txtDescription.Clear();
                    txtMediaName.Text = "None";

                    MessageBox.Show("Report Sent!", "SUCCESS");
                }
            }
            catch (Exception ex)
            {
                //If an error occurs, the user will be prompted with this.
                MessageBox.Show("Please inform one of the developers about the following error:\n" + ex.ToString(), "ERROR");
            }
        }

        //Click event to get a new quote
        private void lblRefreshQuote_Click(object sender, EventArgs e)
        {
            EncouragmentQuotes();
        }

        //Click event for when the user wants to go back to the main menu.
        private void drpMainMenu_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            //Opens the main menu
            frm.Show();

            //Closes the report issues window.
            Close();
        }

        //Click event to open the user's file explorer so they can select and image or document.
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            //When the user clicks ok after selecting the file, the name of the file will be displayed to the user.
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string mediaPath = Path.Combine(Path.GetTempPath(), ofd.FileName);
                string sourceFilePath = ofd.FileName;
                string destinationFolder = Path.GetTempPath();

                // Create the destination path by combining the destination folder and the file name
                string destinationFilePath = Path.Combine(destinationFolder, Path.GetFileName(sourceFilePath));
                if (File.Exists(destinationFilePath))
                {
                    File.Delete(destinationFilePath);
                }
                // Copy the file
                File.Copy(sourceFilePath, destinationFilePath);
                txtMediaName.Text = ofd.SafeFileName;
            }
            else
            {
                //If the user closed file explorer, the textbox will remain at its default value.
                txtMediaName.Text = "None";
            }
        }

        //Click event for when a user wants to open the send feedback window.
        private void lblFeedback_Click(object sender, EventArgs e)
        {
            Send_Feedback send_Feedback = new Send_Feedback();

            //Opens the send feedback window while keeping the report issues window open in the background.
            send_Feedback.ShowDialog();
        }

        //Used to cycle through quotes.
        private void EncouragmentQuotes()
        {
            //The while loop is used to make sure that the application doesn't display the same quote twice in a row.
            while (true)
            {
                int num = rnd.Next(0, quotes.Count);

                if (!quotes[num].Equals(previousQuote))
                {
                    lblMessages.Text = quotes[num];
                    previousQuote = quotes[num];
                    break;
                }
            }
        }

        //Click event for when the user would like to clear their selected media file.
        private void btnClearMedia_Click(object sender, EventArgs e)
        {
            string mediaPath = Path.Combine(Path.GetTempPath(), ofd.FileName);
            File.Delete(mediaPath);
            txtMediaName.Text = "None";
        }

        //Click event to open the file that the user selected after browsing media files.
        private void txtSelectedMedia_Click(object sender, EventArgs e)
        {
            //If a media file has been chosen, the user can open the selected media file.
            if (!txtMediaName.Text.Equals("None"))
            {
                string mediaPath = Path.Combine(Path.GetTempPath(), ofd.FileName);
                Process.Start(mediaPath);
            }
            else
            {
                //If a media file has not been chosen, the user will be prompted with this.
                MessageBox.Show("No file has been selected.", "ERROR");
            }
        }

        private void drpEvents_Click(object sender, EventArgs e)
        {
            LocalEventsAndAnnouncements eventsAndAnnouncements = new LocalEventsAndAnnouncements();
            eventsAndAnnouncements.Show();
            Close();
        }

        private void drpReq_Click(object sender, EventArgs e)
        {
            try
            {
                Service_Request_Status srs = new Service_Request_Status();

                //Opens the main menu
                srs.Show();

                //Closes the send feedback window.
                Close();
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

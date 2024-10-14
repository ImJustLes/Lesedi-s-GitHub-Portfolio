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
    public partial class Send_Feedback : Form
    {
        //initialisation of feedback object
        List<Feedback> feedback = new List<Feedback>();
        public Send_Feedback()
        {
            InitializeComponent();
            txtLocation.Focus();
        }

        //Click event for handling the submission of feedback.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //If all the required fields are populated, the user will enter the if statement.
                if (!txtLocation.Text.Equals("") && !txtEmail.Text.Equals("") && !txtDescription.Text.Equals(""))
                {

                    //If the user inputs a valid email address, they will enter the if statement.
                    if (emailIsValid(txtEmail.Text))
                    {
                        //Adds the feedback into the list.
                        feedback.Add(new Feedback(txtLocation.Text, txtEmail.Text, txtDescription.Text));

                        //Defaults the controls.
                        txtLocation.Clear();
                        txtEmail.Clear();
                        txtDescription.Clear();

                        MessageBox.Show("Feedback sent!", "SUCCESS");
                    }
                    else
                    {
                        //If the email is invalid, the user will be prompted with this.
                        MessageBox.Show("Email is invalid", "ERROR");
                    }
                }
                else
                {
                    //If the user did not populate all the required fields, they will be prompted with this.
                    MessageBox.Show("Please fill in all required fields", "ERROR");
                }
            }
            catch (Exception ex)
            {
                //Error message if an error occurs.
                MessageBox.Show("Please inform one of the developers about the following error:\n" + ex.ToString(), "ERROR");
            }
        }

        //Click event that handles going back to the main menu.
        private void drpMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 mainMenu = new Form1();

                //Opens the main menu
                mainMenu.Show();

                //Closes the send feedback window.
                this.Close();
            }
            catch (Exception ex)
            {
                //Error message if an error occurs.
                MessageBox.Show("Please inform one of the developers about the following error:\n" + ex.ToString(), "ERROR");
            }
        }

        private void drpEvents_Click(object sender, EventArgs e)
        {
            try
            {
                LocalEventsAndAnnouncements eventsAndAnnouncements = new LocalEventsAndAnnouncements();

                //Opens the main menu
                eventsAndAnnouncements.Show();

                //Closes the send feedback window.
                Close();
            }
            catch (Exception ex)
            {
                //Error message if an error occurs.
                MessageBox.Show("Please inform one of the developers about the following error:\n" + ex.ToString(), "ERROR");
            }
        }

        //Method to check validity of email
        private bool emailIsValid(string email)
        {
            //Makes the inputted email address lowercase.
            email.ToLower();

            //If the email contains an @, the user will enter the if statement.
            if (email.Contains("@")){

                //Gets the email suffix.
                string emailService = email.Substring(email.IndexOf("@"));

                //If the email suffix is anyone of these email services, the user has a valid email address.
                if (email.Contains("@gmail.com") || (email.Contains("@live.co.za") || email.Contains("@yahoo.com") || email.Contains("@vcconnect.edu.za")))
                {                                         
                    return true;
                } 
                else
                {      
                    //If the suffix is incorrect/is not a support email address then the email address is invalid.
                    return false;
                }
            } 
            else
            {
                //If the email doesn't contain an @, the email address is invalid.
                return false;
            }
        }        
    }
}

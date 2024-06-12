using ModuleMethods;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace PROG6212POEPART1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        //Declerations
        Module obj1 = new Module();
        ObservableCollection<Module> modules = new ObservableCollection<Module>();

        public MainWindow() {

            InitializeComponent();          
        }

        private async void Main_Loaded(object sender, RoutedEventArgs e) {

            cmbCodes.Items.Clear();

            using (SqlConnection con = new SqlConnection(Module.strCon)) {

                con.Open();

                string strSelect = $"SELECT Weeks, StartDate, EndDate FROM Semesters WHERE UserID = {Module.currentUserID}";
                SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                using (SqlDataReader reader = cmdSelect.ExecuteReader()) {

                    while (reader.Read()) {

                        Module.Weeks = (int)reader[0];
                        obj1.startDate = (DateTime)reader[1];
                        obj1.endDate = (DateTime)reader[2];
                    }

                    //Creates parameters that can be accessed in the datePicker
                    dteStudyDay.DisplayDateStart = obj1.startDate;
                    dteStudyDay.DisplayDateEnd = obj1.endDate;
                }

                //Select statement
                strSelect = $"SELECT COUNT(*) FROM Semesters WHERE UserID = {Module.currentUserID}";
                cmdSelect = new SqlCommand(strSelect, con);

                int count = (int)cmdSelect.ExecuteScalar();

                if (count < 1) {

                    //Mulithreading
                    Dispatcher.Invoke(() => {

                        DisableControls();
                        txtWeeks.Focus();
                    });

                } else {

                    //Select statement
                    strSelect = $"SELECT * FROM Modules WHERE UserID = {Module.currentUserID}";
                    cmdSelect = new SqlCommand(strSelect, con);

                    //Reader to get information from the database.
                    using (SqlDataReader reader = cmdSelect.ExecuteReader()) {

                        while (reader.Read()) {
                            
                            //Inputs the data from the database.
                            Module module = new Module(reader.GetString(0), reader.GetString(2), reader.GetInt32(3), reader.GetDouble(4), obj1.StudyCalc(reader.GetInt32(3), reader.GetDouble(4)));
                            modules.Add(module);
                        }
                    }

                    //Select statement
                    strSelect = $"SELECT ModuleCode, DateStudied, HoursStudied FROM StudyHoursRecords WHERE UserID = {Module.currentUserID}";
                    cmdSelect = new SqlCommand(strSelect, con);

                    //Reads the data from the database.
                    using (SqlDataReader reader = cmdSelect.ExecuteReader()) {

                        DateTime startOfWeek = DateTime.Now.Date;

                        // While loop that subtracts a day until Monday using the current date the user uses the application in.
                        while (startOfWeek.DayOfWeek != DayOfWeek.Monday) {

                            startOfWeek = startOfWeek.AddDays(-1);
                        }

                        // After finding the certain Monday's date, we determine the end of the week by adding 6 days from the obtained Monday date.
                        DateTime endOfWeek = startOfWeek.AddDays(6);

                        while (reader.Read()) {

                            // Obtains the date chosen by the user and the current day the user used the application on and the module code
                            DateTime studiedDate = reader.GetDateTime(1);

                            // If statement to check if the chosen date by the user falls within the current week they're running the application
                            if (studiedDate >= startOfWeek && studiedDate <= endOfWeek) {

                                for (int i = 0; i < modules.Count; i++) {

                                    if (reader.GetString(0).Equals(modules[i].Code)) {

                                        // When the index of the chosen module code is found, the hours of self-study for the week is subtracted.
                                        double hoursDone = reader.GetDouble(2);
                                        modules[i].studyHours -= hoursDone;

                                        obj1.UpdateUserInformation(modules, i);
                                    }
                                }
                            }
                        }

                        //Multithreading
                        Dispatcher.Invoke(() => {
                            
                            //Adds the codes and modules into the DataGrid and module codes
                            for (int i = 0; i < modules.Count; i++) {

                                // Adds the module code into the combo box to make it selectable
                                cmbCodes.Items.Add(modules[i].Code);

                                // Displays the module at the specific index in the DataGrid with the information
                                dgDisplay.Items.Add(modules[i]);
                            }

                            //Disables the semester controls.
                            txtWeeks.IsEnabled = false;
                            btnSemester.IsEnabled = false;
                            dteStart.IsEnabled = false;
                        });
                    }
                }
            }
        }

        //Button that confirms the details of the semester start and length
        private async void btnSemester_Click(object sender, RoutedEventArgs e) {

            // If statement to make sure the textbox and DatePicker return values.
            if (txtWeeks.Text.Equals("") || dteStart.SelectedDate == null) {

                MessageBox.Show("Define the semester start date and weeks until the end of the semester.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            
            } else {

                //Obtain values for the start date, weeks, and calculate the end date based on the weeks.
                obj1.startDate = dteStart.SelectedDate.Value;
                Module.Weeks = Convert.ToInt32(txtWeeks.Text);
                obj1.endDate = obj1.startDate.AddDays(Convert.ToInt32(Module.Weeks * 7));

                //Disable the controls for semester length so they can't be used again while processing.
                txtWeeks.IsEnabled = false;
                btnSemester.IsEnabled = false;
                dteStart.IsEnabled = false;

                //Run the database operation in the background using Task.Run.
                await Task.Run(() => { 

                    //Insert into the semester table in the database.
                    obj1.InsertSemester(obj1.startDate, obj1.endDate);
                });

                //Create the start and end of the datePicker control.
                dteStudyDay.DisplayDateStart = obj1.startDate;
                dteStudyDay.DisplayDateEnd = obj1.endDate;

                //Enable the controls now that the operation is complete.
                Dispatcher.Invoke(() =>
                {
                    EnableControls();
                });
            }
        }



        //Button used to save a module
        private async void btnEnter_Click(object sender, RoutedEventArgs e) {

            //If statement to make sure the user inputs ALL needed values
            if (txtCode.Text.Equals("") || txtCredits.Text.Equals("") || txtHours.Text.Equals("") || txtName.Text.Equals("")) {

                MessageBox.Show("Please fill in all the boxes with the correct values.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            //Gets user input
            string code = txtCode.Text;
            int credits = Convert.ToInt32(txtCredits.Text);
            string name = txtName.Text;
            double hours = Convert.ToDouble(txtHours.Text);
            double studyHours = obj1.StudyCalc(credits, hours);
            bool dupeChecker = false;

            //list to get codes from the database
            List<string> codes = new List<string>();

            //Select statement
            string strSelect = $"SELECT ModuleCode FROM Modules";

            using (SqlConnection con = new SqlConnection(Module.strCon)) {

                con.Open();

                SqlCommand cmdInsert = new SqlCommand(strSelect, con);

                //Reader used to get information from database into the codes list.
                using (SqlDataReader reader = await cmdInsert.ExecuteReaderAsync()) {

                    while (await reader.ReadAsync()) {

                        codes.Add(reader.GetString(0));
                    }
                }
            }

            //foreach used to check if any username that exists in the database is equal to the one inputted by the user.
            foreach (string existingCode in codes){

                if (code == existingCode) {

                    dupeChecker = true;
                    break;
                }
            }

            //If the username is unique, it will input.
            if (dupeChecker == false) {

                //Run database operations in the background.
                await Task.Run(async () => {

                    //Add the information to your modules list.
                    modules.Add(new Module(code, name, credits, hours, studyHours));

                    // Insert values into the database
                     obj1.InsertModule(code, credits, name, hours);
                     obj1.InsertUserInformation(code, studyHours);
                });

                //Clears the textboxes for adding a module.
                ClearCreate();

                cmbCodes.Items.Add(code);
                dgDisplay.Items.Add(modules[modules.Count - 1]);

                MessageBox.Show("Module successfully created!", "MODULE COMPLETE", MessageBoxButton.OK, MessageBoxImage.Information);

            } else {

                MessageBox.Show("Module with the same module code has already been made!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        //Button used to confirm the hours a user spent on a certain date
        private async void btnConfirmHours_Click(object sender, RoutedEventArgs e) {

            //If any of the information for confirming hours is missing, it will not go into the else statement
            if (dteStudyDay.SelectedDate == null || txtStudyHours.Text == "" || cmbCodes.SelectedItem == null) {

                MessageBox.Show("Please input all the needed information.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);

            } else {

                //Gets the inputted value and date of the day the user runs the app
                DateTime startOfWeek = DateTime.Now.Date;
                DateTime chosenDate = dteStudyDay.SelectedDate.Value;

                //While loop used to determine the start of the week.
                while (startOfWeek.DayOfWeek != DayOfWeek.Monday) {

                    startOfWeek = startOfWeek.AddDays(-1);
                }

                //Determines the end of the week from start of the week.
                DateTime endOfWeek = startOfWeek.AddDays(6); //Atris(2014)

                    double hoursDone = Convert.ToDouble(txtStudyHours.Text);
                    
                //If the if statement is within the the week, it will implement the changes to the dataGrid and add to the database.
                    if (chosenDate >= startOfWeek && chosenDate <= endOfWeek) {

                        var tasks = new List<Task>();

                        for (int i = 0; i < modules.Count; i++) {

                            if (cmbCodes.SelectedItem.ToString().Equals(modules[i].Code)) {

                                modules[i].studyHours -= hoursDone;

                                obj1.UpdateUserInformation(modules, i);
                                obj1.InsertStudyHoursRecords(modules, i, hoursDone, chosenDate);
                            }
                        }

                        await Task.WhenAll(tasks);
                        
                        //Clears the DataGrid and textbox
                        dgDisplay.Items.Clear();
                        txtStudyHours.Clear();

                        var updatedList = (from mod in modules
                                           select mod).ToList();

                        foreach (var module in updatedList) {

                            dgDisplay.Items.Add(module);
                        }

                        MessageBox.Show("Study hours successfully recorded!", "RECORDED", MessageBoxButton.OK, MessageBoxImage.Information);

                    } else {

                        var tasks = new List<Task>();

                        for (int i = 0; i < modules.Count; i++) {

                            tasks.Add(Task.Run(() => obj1.InsertStudyHoursRecords(modules, i, hoursDone, chosenDate)));
                        }

                        await Task.WhenAll(tasks);

                        MessageBox.Show("Study hours successfully recorded!", "RECORDED", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }

        //Exit button
        private void btnExit_Click(object sender, RoutedEventArgs e) {
             
            MessageBoxResult result = MessageBox.Show("Are you sure you'd like to exit?", "WARNING", MessageBoxButton.YesNo, MessageBoxImage.Information);

            //If the user selects yes then they will exit the application.
            if (result == MessageBoxResult.Yes) {

                Environment.Exit(0);
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e) {

            MessageBoxResult result = MessageBox.Show("Are you sure you want to logout?", "WARNING", MessageBoxButton.YesNo, MessageBoxImage.Information);

            //If the user selects yes then they will go back to the register page.
            if (result == MessageBoxResult.Yes) {

                Close();
            }
        }

        //Used to clear the textboxes when a module is successfully created
        private void ClearCreate() {

            Dispatcher.Invoke(() => {

                txtCode.Clear();
                txtCredits.Clear();
                txtHours.Clear();
                txtName.Clear();
                txtWeeks.Clear();
                txtCode.Focus();
            });
        }


        //Disables the controls to create the module and update self-study hours in the beginning of runtime
        private void DisableControls() {

            Dispatcher.Invoke(() => {

                txtCode.IsEnabled = false;
                txtName.IsEnabled = false;
                txtCredits.IsEnabled = false;
                txtHours.IsEnabled = false;
                cmbCodes.IsEnabled = false;
                txtStudyHours.IsEnabled = false;
                dteStudyDay.IsEnabled = false;
                btnConfirmHours.IsEnabled = false;
                btnEnter.IsEnabled = false;
            });
        }


        //Used to enable the controls when the semester start and length is determined.
        private void EnableControls() {

            Dispatcher.Invoke(() => {

                txtCode.IsEnabled = true;
                txtName.IsEnabled = true;
                txtCredits.IsEnabled = true;
                txtHours.IsEnabled = true;
                cmbCodes.IsEnabled = true;
                txtStudyHours.IsEnabled = true;
                dteStudyDay.IsEnabled = true;
                btnConfirmHours.IsEnabled = true;
                btnEnter.IsEnabled = true;
            });
        }
    }
}

using ModuleMethods;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROG6212POEPART1
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e) {

            //Declerations
            string username = txtUsernameRegister.Text;
            string password = txtPasswordRegister.Password;
            string password2 = txtConfirmPassword.Password;

            //List to get the usernames from the database.
            List<string> usernames = new List<string>();

            //If any of the values are missing, it will not enter the else statement.
            if (txtUsernameRegister.Text == "" || txtPasswordRegister.Password == string.Empty || txtConfirmPassword.Password == string.Empty) {

                MessageBox.Show("Please fill in all the needed details", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            
            } else {

                //Multithreading
                Task.Run(() => {

                    using (SqlConnection con = new SqlConnection(Module.strCon)) {

                        con.Open();

                        //Select statement
                        string strSelect = $"SELECT Username FROM RegisteredUsers";
                        SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                        using (SqlDataReader reader = cmdSelect.ExecuteReader()) {

                            //Uses while loop to input information from the database into the list.
                            while (reader.Read()) {

                                usernames.Add((string)reader[0]);
                            }
                        }
                    }

                    //boolean to check if the username exists
                    bool usernameTaken = false;

                    //foreach to check if it exists in the database,
                    foreach (string existingUsername in usernames) {

                        if (existingUsername == username) {

                            usernameTaken = true;
                            break;
                        }
                    }

                    //if the username is taken, it will enter the if statement
                    if (usernameTaken == false) {

                        Application.Current.Dispatcher.Invoke(() => {

                            MessageBox.Show("Username already taken!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        });

                    } else {

                        //If the passwords match, it will enter the if statement
                        if (password == password2) {

                            //Select statement
                            string strInsert = $"INSERT INTO RegisteredUsers(Username, UserPassword) VALUES('{username}', '{password.GetHashCode()}')";

                            using (SqlConnection con = new SqlConnection(Module.strCon)) {

                                SqlCommand cmdInsert = new SqlCommand(strInsert, con);

                                con.Open();
                                cmdInsert.ExecuteNonQuery();
                            }

                            //Multithreading
                            Application.Current.Dispatcher.Invoke(() => {

                                //Clears the textboxes
                                txtConfirmPassword.Clear();
                                txtPasswordRegister.Clear();
                                txtUsernameRegister.Clear();

                                MessageBox.Show("Successfully created new profile!", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);
                            });

                        } else {

                            Application.Current.Dispatcher.Invoke(() => {

                                MessageBox.Show("Passwords do not match!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                            });
                        }
                    }
                });
            }
        }
    }
}

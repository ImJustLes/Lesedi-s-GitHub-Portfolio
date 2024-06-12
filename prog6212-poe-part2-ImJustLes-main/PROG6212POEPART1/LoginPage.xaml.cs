using ModuleMethods;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROG6212POEPART1
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {       

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {

            //Recieves values from the textboxes
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Password;

            //Boolean to check if the account exists in the database already.
            Boolean accountCheck = false;

            using (SqlConnection con = new SqlConnection(Module.strCon)) {

                startWindow sw = new startWindow();
                MainWindow mw = new MainWindow();

                //Using SQL statements to retrieve the data in the database 
                string strSelect = $"SELECT * FROM RegisteredUsers";

                //Input the statement into cmdSelect with the connections string
                SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                con.Open();
                
                using (SqlDataReader reader = cmdSelect.ExecuteReader()) {

                    //Reader used to input data from database into the application.
                    while (reader.Read()) {

                        if (reader.GetString(1).Equals(username)) {

                            //If the username matches one in the database then the account exists.
                            accountCheck = true;

                            //If the password is correct, then it will enter the main part of the application with the user's details.
                            if (reader.GetString(2).Equals(password.GetHashCode().ToString())) {

                                Module.currentUserID = (int)reader[0];

                                txtUsernameLogin.Clear();
                                txtPasswordLogin.Clear();

                                mw.ShowDialog();                             

                            } else {

                                MessageBox.Show("Invalid login!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        } 
                    } 
                    
                    //If the account exists, then it will prompt this error.
                    if (accountCheck == false) { 
                    
                        MessageBox.Show("Account does not exist.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);

                    //If the textboxes are missing values, they will give this error.
                    } else if (username.Equals("") && password.Equals("")) {

                        MessageBox.Show("Please fill in the needed details.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}

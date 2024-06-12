using ModuleMethods;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PROG6212POEPART1
{
    /// <summary>
    /// Interaction logic for RegisterLogin.xaml
    /// </summary>
    public partial class RegisterLogin : Window
    {
        string strCon = @"Data Source=LAPTOP-8JIKB8P8\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True";
        MainWindow mw;

        public RegisterLogin()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;    

            using (SqlConnection con = new SqlConnection(strCon)) {

                string strSelect = $"SELECT Username, UserPassword FROM RegisteredUsers";

                SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                using (SqlDataReader reader = cmdSelect.ExecuteReader()) {

                    while (reader.Read()) {
                        
                        if ((string)reader[0] == username) {

                            if ((string)reader[1] == password) {

                                mw.Show();
                            
                            } else {

                                MessageBox.Show("Incorrect password!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Account does not exist.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}

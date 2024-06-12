using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PROG6212POEPART1
{
    /// <summary>
    /// Interaction logic for startWindow.xaml
    /// </summary>
    public partial class startWindow : Window {

        //Create the pages as objects
        RegisterPage rp = new RegisterPage();
        LoginPage lp = new LoginPage();

        public startWindow() {

            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e) {

            //Inputs the page into the frame.
            frmRegisterLogin.Content = rp;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e) {

            //Inputs the page into the frame.
            frmRegisterLogin.Content = lp;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            //Presses the button which opens the login.
            btnLogin.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }

        private void btnExit_Click(object sender, RoutedEventArgs e) {

            MessageBoxResult result = MessageBox.Show("Are you sure you'd like to exit?", "WARNING", MessageBoxButton.YesNo, MessageBoxImage.Information);

            //If the user selects yes then they will exit the application.
            if (result == MessageBoxResult.Yes) {

                Environment.Exit(0);
            }
        }
    }
}

using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace OptiChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool IsUsernameChanged = false;
        bool IsPasswordChanged = false;

        public bool getCridentials(string _username, string _password)
        {
            //Sets the value of booliean variable called valid to false
            bool valid = false;
            //Sql statement that counts the amount of rows in the OSDE_Users table where the username and password fields are the same as those entered by the user
            string loginSQLcmd = "SELECT COUNT(UserID) FROM pbasic WHERE Username = '" + _username + "' AND Password = '" + _password + "'";
            //initialize connection

            string server = "localhost";
            string database = "userinfo";
            string uid = "root";
            string password = "kartofili";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //Sql command that executes the Sql statement
            MySqlCommand cmd = new MySqlCommand(loginSQLcmd, connection);

            try
            {
                //int variable that stores the result of the Sql statement
                int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
                //Executed if the value of rowCount is greater than or equal to 1
                if (rowCount >= 1)
                {
                    //Sets the value of valid variable to true
                    valid = true;
                }
                //Executed if the value of rowCount is less than or equal to 0
                else if (rowCount <= 0)
                {
                    //Sets the value of valid variable to false
                    valid = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Returns the value of valid
            return valid;
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            if (Username.Text.Length<2) { MessageBox.Show("Username is Invalid"); }
            else if (PasswordBox1.Password.Length < 2) { MessageBox.Show("Password is Invalid"); }
            else
            {
                bool validitycheck = getCridentials(Username.Text, PasswordBox1.Password);
                if (validitycheck == true) { MainWindow2 MW2 = new MainWindow2(); this.Close(); MW2.Show(); }
            }

        }

        private void UsernameChanged(object sender, TextChangedEventArgs e)
        {
            if (Username.Text!="Username" && Username.Text != "") { IsUsernameChanged = true; }
            if (IsUsernameChanged && IsPasswordChanged == true) { LoginButton.IsEnabled = true; }
        }

        private void PasswordBoxChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordBox1.Password != "Password" && PasswordBox1.Password != "") { IsPasswordChanged = true; }
            if (IsUsernameChanged && IsPasswordChanged == true) { LoginButton.IsEnabled = true; }
        }



        private void DragWithMouseButton(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MouseDownOnEye(object sender, MouseButtonEventArgs e)
        {
            PasswordBoxRevealer.Text = PasswordBox1.Password;
            PasswordBox1.Visibility = Visibility.Hidden;
            PasswordBoxRevealer.Visibility = Visibility.Visible;
        }

        private void MouseUpOnEye(object sender, MouseButtonEventArgs e)
        {
            PasswordBox1.Visibility = Visibility.Visible;
            PasswordBoxRevealer.Visibility = Visibility.Hidden;
        }

        private void LeftMouseDownOnUsername(object sender, MouseButtonEventArgs e)
        {
            if (Username.Text == "Username" || Username.Text == " ")
            {
                TextBox tb = (TextBox)sender;
                tb.Text = string.Empty;
            }
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            RegistrationForm RF = new RegistrationForm(); this.Close(); RF.Show();
        }

        private void ClickedOnPassword(object sender, MouseButtonEventArgs e)
        {
            PasswordBoxRevealer.Visibility = Visibility.Hidden;
            PasswordBox1.Visibility = Visibility.Visible;
        }
    }
}

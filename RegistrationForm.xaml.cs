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
using MySql.Data.MySqlClient;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace OptiChat
{
    /// <summary>
    /// Interaction logic for RegistrationForm.xaml
    /// </summary>
    public partial class RegistrationForm : Window
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        public static bool IsEmptyOrAllSpaces(string str)
        {
            return null != str && str.All(c => c.Equals(' '));
        }

        public static string GetPublicIP()
        {
            string url = "http://checkip.dyndns.org";
            System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] a = response.Split(':');
            string a2 = a[1].Substring(1);
            string[] a3 = a2.Split('<');
            string a4 = a3[0];
            return a4;
        }

        private void DragWithMouseButton(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Register(object sender, RoutedEventArgs e)
        {

        }

        private void LeftMouseDownOnFirstNameBox(object sender, MouseButtonEventArgs e)
        {
            if (FirstNameBox.Text == "First Name" || FirstNameBox.Text == " ")
            {
                TextBox tb = (TextBox)sender;
                tb.Text = string.Empty;
            }
        }

        private void LeftMouseDownOnLastNameBox(object sender, MouseButtonEventArgs e)
        {
            if (LastNameBox.Text == "Last Name" || LastNameBox.Text == " ")
            {
                TextBox tb = (TextBox)sender;
                tb.Text = string.Empty;
            }
        }

        private void LeftMouseDownOnUserNameBox(object sender, MouseButtonEventArgs e)
        {
            if (UsernameBox.Text == "Username" || UsernameBox.Text == " ")
            {
                TextBox tb = (TextBox)sender;
                tb.Text = string.Empty;
            }
        }

        private void LeftMouseDownOnEmailAddressBox(object sender, MouseButtonEventArgs e)
        {
            if (EmailAddressBox.Text == "Email Address" || EmailAddressBox.Text == " ")
            {
                TextBox tb = (TextBox)sender;
                tb.Text = string.Empty;
            }
        }

        private void LeftMouseDownOnPasswordBox(object sender, MouseButtonEventArgs e)
        {
            if (PasswordBoxRevealerBox.Text == "Password" || PasswordBoxRevealerBox.Text == " ")
            {
                PasswordBoxRevealerBox.Clear();
            }
        }



        private void LeftMouseDownOnRegister(object sender, MouseButtonEventArgs e)
        {

            bool FirstNameContainsSpecials;
            bool FirstNameStartsOrEndsWithSpace;
            bool FirstNameLengthIsLessThanTwo;
            bool FirstNameContainsLetters;

            bool LastNameContainsSpecials;
            bool LastNameStartsOrEndsWithSpace;
            bool LastNameLengthIsLessThanTwo;
            bool LastNameContainsLetters;

            bool UserNameContainsSpecials;
            bool UserNameStartsOrEndsWithSpace;
            bool UserNameLengthIsLessThanTwo;
            bool UserNameContainsLetters;

            bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }
            bool IsEmailValid;


            // Firstname

            if (!Regex.IsMatch(FirstNameBox.Text, "^[a-zA-Z0-9\x20]+$"))
            {
                MessageBox.Show(@"Your First Name Contains Special Character: \|!#$%&/()=?»«@£§€{}.-;'<>_ , ");
                FirstNameContainsSpecials = true;
            }
            else { FirstNameContainsSpecials = false; }

            if (FirstNameBox.Text.EndsWith(" ") || FirstNameBox.Text.StartsWith(" "))
            {
                MessageBox.Show("First Name Cannot Start/End With whitespace");
                FirstNameStartsOrEndsWithSpace = true;
            }
            else { FirstNameStartsOrEndsWithSpace = false; }

            if (FirstNameBox.Text.Length < 2) 
            {
                MessageBox.Show("First Name Should At least 2 character long ");
                FirstNameLengthIsLessThanTwo = true;
            }
            else { FirstNameLengthIsLessThanTwo = false; }

            if (IsEmptyOrAllSpaces(FirstNameBox.Text))
            {
                MessageBox.Show("First Name Should Contain Characters");
                FirstNameContainsLetters = false;
            }
            else { FirstNameContainsLetters = true; }

            // Lastname

            if (!Regex.IsMatch(LastNameBox.Text, "^[a-zA-Z0-9\x20]+$"))
            {
                MessageBox.Show(@"Your Last Name Contains Special Character: \|!#$%&/()=?»«@£§€{}.-;'<>_ , ");
                LastNameContainsSpecials = true;
            }
            else { LastNameContainsSpecials = false; }

            if (LastNameBox.Text.EndsWith(" ") || LastNameBox.Text.StartsWith(" "))
            {
                MessageBox.Show("Last Name Cannot Start/End With whitespace");
                LastNameStartsOrEndsWithSpace = true;
            }
            else { LastNameStartsOrEndsWithSpace = false; }

            if (LastNameBox.Text.Length < 2)
            {
                MessageBox.Show("Last Name Should be At least 2 character long ");
                LastNameLengthIsLessThanTwo = true;
            }
            else { LastNameLengthIsLessThanTwo = false; }

            if (IsEmptyOrAllSpaces(LastNameBox.Text))
            {
                MessageBox.Show("Last Name Should Contain Characters");
                LastNameContainsLetters = false;
            }
            else { LastNameContainsLetters = true; }

            // Username

            if (!Regex.IsMatch(UsernameBox.Text, @"^[a-zA-Z0-9\s.\?\,\'\;\:\!\-]+$"))
            {
                MessageBox.Show(@"Your Username Contains Special Character: \|!#$%&/()=?»«@£§€{}.-;'<>_ , ");
                UserNameContainsSpecials = true;
            }
            else { UserNameContainsSpecials = false; }

            if (UsernameBox.Text.EndsWith(" ") || UsernameBox.Text.StartsWith(" "))
            {
                MessageBox.Show("Username Cannot Start/End With whitespace");
                UserNameStartsOrEndsWithSpace = true;
            }
            else { UserNameStartsOrEndsWithSpace = false; }

            if (UsernameBox.Text.Length < 2)
            {
                MessageBox.Show("Username Should be At least 2 character long ");
                UserNameLengthIsLessThanTwo = true;
            }
            else { UserNameLengthIsLessThanTwo = false ; }

            if (IsEmptyOrAllSpaces(UsernameBox.Text))
            {
                MessageBox.Show("Username Should Contain Characters");
                UserNameContainsLetters = false;
            }
            else { UserNameContainsLetters = true; }

            //  Email

            if (!IsValidEmail(EmailAddressBox.Text))
            {   
                MessageBox.Show("Email Is Invalid");
                IsEmailValid = false;
            }
            else { IsEmailValid = true; }

            if (
            FirstNameContainsSpecials == false &&
            FirstNameStartsOrEndsWithSpace == false &&
            FirstNameLengthIsLessThanTwo == false &&
            FirstNameContainsLetters == true &&
            LastNameContainsSpecials == false &&
            LastNameStartsOrEndsWithSpace == false &&
            LastNameLengthIsLessThanTwo == false &&
            LastNameContainsLetters == true &&
            UserNameContainsSpecials == false &&
            UserNameStartsOrEndsWithSpace == false &&
            UserNameLengthIsLessThanTwo == false &&
            UserNameContainsLetters == true &&
            IsEmailValid==true)
            {
                string ipaddress = GetPublicIP();
                string server = "localhost";
                string database = "userinfo";
                string uid = "root";
                string password = "kartofili";
                string connectionString;

                connectionString = "SERVER=" + server + "; PORT = 3306 ;" + "DATABASE="
                + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";



                try
                {
                    MySqlConnection con = new MySqlConnection(connectionString);
                    MySqlCommand cmd = null;
                    string cmdString = "";
                    con.Open();

                    cmdString = "INSERT INTO pbasic VALUES(" + "DEFAULT" + ", '" + ipaddress + "', '"
                        + FirstNameBox.Text + "', '" + LastNameBox.Text + "', '" + UsernameBox.Text
                        + "', '" + EmailAddressBox.Text + "', '" + PasswordBox.Password + "')";

                    cmd = new MySqlCommand(cmdString, con);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Registered Successfully");

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

        }

        private void MouseDownOnEye(object sender, MouseButtonEventArgs e)
        {
            PasswordBoxRevealerBox.Text = PasswordBox.Password;
            PasswordBox.Visibility = Visibility.Hidden;
            PasswordBoxRevealerBox.Visibility = Visibility.Visible;
        }

        private void MouseUpOnEye(object sender, MouseButtonEventArgs e)
        {
            PasswordBox.Visibility = Visibility.Visible;
            PasswordBoxRevealerBox.Visibility = Visibility.Hidden;
        }

        private void GoBackClicked(object sender, MouseButtonEventArgs e)
        {
            MainWindow MW = new MainWindow(); this.Close(); MW.Show();
        }
    }
}

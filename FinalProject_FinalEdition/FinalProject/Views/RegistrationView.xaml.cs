using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalProject.Views
{
    /// <summary>
    /// Interaction logic for RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : MetroWindow
    {
        public RegistrationView()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginView login = new LoginView();
            login.Show();
            Close();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxDate.Text = "";
            textBoxPhone.Text = "";
            passwordBox1.Password = "";
            passwordBoxConfirm.Password = "";
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private static async Task SendEmailAsync(string username)
        {
            MailAddress from = new MailAddress("thebest.tennisshop2020@gmail.com", "Andrew");
            MailAddress to = new MailAddress(username);
            MailMessage msg = new MailMessage(from, to);
            msg.Subject = "Регистрация";
            msg.Body = "Вы успешно зарегистрировались на нашем сайте. Можете переходить к просмотру и покупке товаров.\n\n\nС уважением,\nАдминистрация";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("thebest.tennisshop2020@gmail.com", "Shop&Tennis09");
            smtpClient.EnableSsl = true;
            await smtpClient.SendMailAsync(msg);
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                textBoxEmail.Focus();
            }
            else if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }
            else
            {
                string firstname = textBoxFirstName.Text;
                string lastname = textBoxLastName.Text;
                string email = textBoxEmail.Text;
                string password = passwordBox1.Password;
                if (passwordBox1.Password.Length == 0)
                {
                    errormessage.Text = "Enter password.";
                    passwordBox1.Focus();
                }
                else if (passwordBoxConfirm.Password.Length == 0)
                {
                    errormessage.Text = "Enter Confirm password.";
                    passwordBoxConfirm.Focus();
                }
                else if (passwordBox1.Password != passwordBoxConfirm.Password)
                {
                    errormessage.Text = "Confirm password must be same as password.";
                    passwordBoxConfirm.Focus();
                }
                else
                {
                    errormessage.Text = "";
                    string address = textBoxDate.Text;
                    string phone = textBoxPhone.Text;
                    SqlConnection con = new SqlConnection(@"Server=tcp:mysqlserver220300.database.windows.net,1433;Initial Catalog=TennisShop;Persist Security Info=False;User ID=azureuser;Password=ShopTennis09;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into T_User (UserName,UserSurname,UserEmail,UserPassword,UserDateOfBirth,UserPhone) values('" + firstname + "','" + lastname + "','" + email + "','" + password + "','" + address + "','" + phone + "')", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    SendEmailAsync(email).GetAwaiter();
                    errormessage.Text = "You have Registered successfully.";
                    MainView mainView = new MainView();
                    mainView.TextBlockName.Text = email;
                    mainView.Show();
                    Reset();
                }
            }
        }
        
    }
}

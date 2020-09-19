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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using MahApps.Metro.Controls;
using System.Net.Mail;
using System.Net;

namespace FinalProject.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : MetroWindow
    {
        public LoginView()
        {
            InitializeComponent();
        }

        RegistrationView registration = new RegistrationView();
        MainView mainView = new MainView();
        AdminView adminView = new AdminView();
        private void button1_Click(object sender, RoutedEventArgs e)
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
                string email = textBoxEmail.Text;
                string password = passwordBox1.Password;
                SqlConnection con = new SqlConnection(@"Server=tcp:mysqlserver220300.database.windows.net,1433;Initial Catalog=TennisShop;Persist Security Info=False;User ID=azureuser;Password=ShopTennis09;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from T_User where UserEmail='" + email + "'  and UserPassword='" + password + "'", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    int userId = (int)dataSet.Tables[0].Rows[0]["UserId"];
                    string emailUser = dataSet.Tables[0].Rows[0]["UserEmail"].ToString();
                    string username = dataSet.Tables[0].Rows[0]["UserName"].ToString() + " " + dataSet.Tables[0].Rows[0]["UserSurname"].ToString();
                    if (userId == 1)
                    {
                        adminView.Show();
                        adminView.UserEmailAdmin.Text = $"{username} ({emailUser})";
                        mainView.TextBlockName.Text = $"{emailUser}";
                        login.Close();
                    }
                    else
                    {
                        mainView.TextBlockName.Text = $"{emailUser}";
                        mainView.Show();
                        login.Close();
                    }
                }
                else
                {
                    errormessage.Text = "Sorry! Please enter existing email/password.";
                }
                con.Close();
            }
        }
        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            registration.Show();
            Close();
        }
    }
}

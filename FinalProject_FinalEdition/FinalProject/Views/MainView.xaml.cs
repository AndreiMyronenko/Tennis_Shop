using FinalProject.Models;
using FinalProject.ViewModels;
using LinqKit;
using MahApps.Metro;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
using System.Windows.Shapes;

namespace FinalProject.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : MetroWindow
    {
        public MainView()
        {
            InitializeComponent();

            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
            }
        }

        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Close();
            LoginView loginView = new LoginView();
            loginView.Show();
        }

        private void ManCombo_SelectionChanged(object sender, SelectionChangedEventArgs e) { }
        private void StyleCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StyleCombo.SelectedIndex == 2)
                ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent("Orange"), ThemeManager.GetAppTheme("BaseLight"));
            else if (StyleCombo.SelectedIndex == 1)
                ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent("Cobalt"), ThemeManager.GetAppTheme("BaseDark"));
        }
        private void ManBagCombo_SelectionChanged(object sender, SelectionChangedEventArgs e) { }
        private void ManStrCombo_SelectionChanged(object sender, SelectionChangedEventArgs e) { }

        private void Price_Sender_Click(object sender, RoutedEventArgs e)
        {
            string username = TextBlockName.Text;
            string price = TotalAmount.Text;
            SendEmail(username, price);
            if (CultureInfo.CurrentUICulture.Name == "en-US")
            {
                MessageBox.Show("The order was sent to your email.");
            }
            else if(CultureInfo.CurrentUICulture.Name == "ru-RU")
            {
                MessageBox.Show("Заказ был отправлен на Ваш почтовый адрес.");
            }
            else
            {
                MessageBox.Show("Замовлення було відправлено на Вашу поштову адресу.");
            }
        }

        private void SendEmail(string username, string price)
        {
            MailAddress from = new MailAddress("thebest.tennisshop2020@gmail.com", "Andrew");
            MailAddress to = new MailAddress(username);
            MailMessage msg = new MailMessage(from, to);
            msg.Subject = "Сумма заказа";
            msg.Body = $"Сумма Вашего заказа составила ${price}\nЕсли у Вас есть какие-то вопросы или уточнения по заказу, Вы можете связаться с нашим менеджером по телефону +380958388000.\n\n\nС уважением,\nАдминистрация";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("thebest.tennisshop2020@gmail.com", "Shop&Tennis09");
            smtpClient.EnableSsl = true;
            smtpClient.Send(msg);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            wrap.Visibility = Visibility.Visible;
            RacquetGrid.Visibility = Visibility.Visible;
            wrapTotalRacquet.Visibility = Visibility.Visible;
            RacquetWarning.Visibility = Visibility.Collapsed;
            wrapRacquetQuantity.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (BagTotal.Text == "0" && TotalString.Text == "0")
            {
                wrap.Visibility = Visibility.Hidden;
            }
            RacquetGrid.Visibility = Visibility.Collapsed;
            wrapTotalRacquet.Visibility = Visibility.Collapsed;
            wrapRacquetQuantity.Visibility = Visibility.Hidden;
            RacquetWarning.Visibility = Visibility.Visible;
        }

        private void Add_String_Click(object sender, RoutedEventArgs e)
        {
            wrap.Visibility = Visibility.Visible;
            CartStringGrid.Visibility = Visibility.Visible;
            wrapString.Visibility = Visibility.Visible;
            StringWarning.Visibility = Visibility.Collapsed;
            wrapStringQuantity.Visibility = Visibility.Visible;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            if (RacquetTotal.Text == "0" && BagTotal.Text == "0")
            {
                wrap.Visibility = Visibility.Hidden;
            }
            CartStringGrid.Visibility = Visibility.Collapsed;
            wrapString.Visibility = Visibility.Collapsed;
            StringWarning.Visibility = Visibility.Visible;
            wrapStringQuantity.Visibility = Visibility.Hidden;
        }

        private void Add_Bag_Click(object sender, RoutedEventArgs e)
        {
            wrap.Visibility = Visibility.Visible;
            GridBag.Visibility = Visibility.Visible;
            wrapBag.Visibility = Visibility.Visible;
            BagWarning.Visibility = Visibility.Collapsed;
            wrapBagQuantity.Visibility = Visibility.Visible;
        }

        private void Clear_Bag_Click(object sender, RoutedEventArgs e)
        {
            if (RacquetTotal.Text == "0" && TotalString.Text == "0") 
            {
                wrap.Visibility = Visibility.Hidden;
            }
            GridBag.Visibility = Visibility.Collapsed;
            wrapBag.Visibility = Visibility.Collapsed;
            BagWarning.Visibility = Visibility.Visible;
            wrapBagQuantity.Visibility = Visibility.Hidden;
        }
    }
}

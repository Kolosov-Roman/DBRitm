using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
using ООО_Ритм.Classes;
using ООО_Ритм.DB_Ritm;
using ООО_Ритм.Windows;

namespace ООО_Ритм
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                Helper.DB = new DB_Ritm.DB_Ritm();
                MessageBox.Show("Связь удалась!");
            }
            catch
            {
                MessageBox.Show("Связь не удалась(");
                App.Current.Shutdown();
            }
        }

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Button_Enter(object sender, RoutedEventArgs e)
        {
            string login = tb_login.Text;
            string password = tb_password.Text;
            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrEmpty(password) && String.IsNullOrEmpty(login))
            {
                sb.AppendLine("Вы забыли ввести логин и пароль");
                MessageBox.Show(sb.ToString());
                return;
            }
            if (String.IsNullOrEmpty(login))
            {
                sb.AppendLine("Вы забыли ввести логин");
                MessageBox.Show(sb.ToString());
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                sb.AppendLine("Вы забыли ввести пароль");
                MessageBox.Show(sb.ToString());
                return;
            }

            if (sb.Length == 0)
            {
                List<User> users = new List<User>();
                users = Helper.DB.User.Where(u => u.password == password && u.login == login).ToList();

                Helper.user = users.FirstOrDefault();
                if (Helper.user != null)
                {
                    sb.AppendLine("Здравствуйте, уважаемый " + Helper.user.Role1.titleRole + "!");
                    MessageBox.Show(sb.ToString());
                    goCatalog();
                }
                else
                {
                    sb.AppendLine("Данный пользователь не зарегистрирован");
                    MessageBox.Show(sb.ToString());
                }
            }
        }

        private void goCatalog()
        {
            switch (Helper.user.role)
            {
                case 3:
                    Catalog_client catalog_client = new Catalog_client();
                    this.Hide();
                    catalog_client.ShowDialog();
                    this.Show();
                    break;
                case 2:
                    Catalog_manager catalog_manager = new Catalog_manager();
                    this.Hide();
                    catalog_manager.ShowDialog();
                    this.Show();
                    break;
                case 1:
                    Catalog_admin catalog_admin = new Catalog_admin();
                    this.Hide();
                    catalog_admin.ShowDialog();
                    if (catalog_admin.IsActive)
                    {
                        catalog_admin.Show();
                    }
                    this.Show();
                    break;
            }
        }

        private void Button_Guest(object sender, RoutedEventArgs e)
        {
            Catalog_guest catalog_guest = new Catalog_guest();
            this.Hide();
            catalog_guest.ShowDialog();
            this.Show();
        }
    }
}
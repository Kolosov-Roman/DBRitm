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
using ООО_Ритм.Classes;
using ООО_Ритм.DB_Ritm;

namespace ООО_Ритм.Windows
{
    /// <summary>
    /// Логика взаимодействия для Client_cart.xaml
    /// </summary>
    public partial class Client_cart : Window
    {
        Catalog_client catalog_Client = new Catalog_client();
        public Client_cart()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
            catalog_Client.Show();
        }
    }
}

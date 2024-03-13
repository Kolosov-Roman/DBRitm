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
    /// Логика взаимодействия для Catalog_client.xaml
    /// </summary>
    public partial class Client_orders : Window
    {
        List<Product_class> products;
        Catalog_client catalog_Client = new Catalog_client();
        public Client_orders()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            products = Helper.DB.Product.ToList().ConvertAll<Product_class>(p => new Product_class(p));
            listBoxProducts.ItemsSource = products;
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
            catalog_Client.Show();
        }
    }
}
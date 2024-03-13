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
    public partial class Catalog_client : Window
    {
        List<Product_class> products;
        public Catalog_client()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            clearValuesOfFiltersAndSorts();
            products = Helper.DB.Product.ToList().ConvertAll<Product_class>(p => new Product_class(p));
            listBoxProducts.ItemsSource = products;
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            totalSorAndFilter();
        }

        private void cbSort_Category(object sender, SelectionChangedEventArgs e)
        {
            totalSorAndFilter();
        }
        
        private void cbSort_Discount(object sender, SelectionChangedEventArgs e)
        {
            totalSorAndFilter();
        }

        private void cbSort_Cost(object sender, SelectionChangedEventArgs e)
        {
            totalSorAndFilter();
        }

        private void sortCost()
        {
            if (cbSort.SelectedIndex == 1) products.Sort(delegate (Product_class a, Product_class b) { return a.ProductCostWithDiscount.CompareTo(b.ProductCostWithDiscount); });
            if (cbSort.SelectedIndex == 2)
            {
                products.Sort(delegate (Product_class a, Product_class b) { return a.ProductCostWithDiscount.CompareTo(b.ProductCostWithDiscount); });
                products.Reverse();
            }
        }

        private void filterDiscount()
        {
            switch (cbFilterDiscount.SelectedIndex)
            {
                case 1:
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Product.discount > 9)
                        {
                            products.Remove(products[i]);
                            i--;
                        }
                    }
                    listBoxProducts.ItemsSource = products;
                    break;

                case 2:
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Product.discount < 10 || products[i].Product.discount > 19)
                        {
                            products.Remove(products[i]);
                            i--;
                        }
                    }
                    listBoxProducts.ItemsSource = products;
                    break;

                case 3:
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Product.discount < 20)
                        {
                            products.Remove(products[i]);
                            i--;
                        }
                    }
                    listBoxProducts.ItemsSource = products;
                    break;
            }
        }

        private void filterCategory()
        {
            switch (cbFilterCategory.SelectedIndex)
            {
                case 1:
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Product.category != "Электрогитара")
                        {
                            products.Remove(products[i]);
                            i--;
                        }
                    }
                    listBoxProducts.ItemsSource = products;
                    break;

                case 2:
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Product.category != "Акустическая гитара")
                        {
                            products.Remove(products[i]);
                            i--;
                        }
                    }
                    listBoxProducts.ItemsSource = products;
                    break;

                case 3:
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Product.category != "Классическая гитара")
                        {
                            products.Remove(products[i]);
                            i--;
                        }
                    }
                    listBoxProducts.ItemsSource = products;
                    break;

                case 4:
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Product.category != "Бас-гитара")
                        {
                            products.Remove(products[i]);
                            i--;
                        }
                    }
                    listBoxProducts.ItemsSource = products;
                    break;
            }
        }

        private void filterWords()
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (tbSearch.Text == "")
                {
                    listBoxProducts.ItemsSource = products;
                    return;
                }
                if (products[i].Product.titleProduct.IndexOf(tbSearch.Text, StringComparison.OrdinalIgnoreCase) != 0)
                {
                    products.Remove(products[i]);
                    i--;
                }
            }
        }

        private void totalSorAndFilter()
        {
            products = Helper.DB.Product.ToList().ConvertAll<Product_class>(p => new Product_class(p));
            filterWords();
            filterCategory();
            filterDiscount();
            sortCost();
            listBoxProducts.ItemsSource = products;
        }

        private void Button_DeleteFilters(object sender, RoutedEventArgs e)
        {
            clearValuesOfFiltersAndSorts();
        }

        private void clearValuesOfFiltersAndSorts()
        {
            cbSort.SelectedIndex = 0;
            cbFilterDiscount.SelectedIndex = 0;
            cbFilterCategory.SelectedIndex = 0;
            tbSearch.Text = "";
        }

        private void ClientOrders_Click(object sender, RoutedEventArgs e)
        {
            Client_orders client_Orders = new Client_orders();
            this.Hide();
            client_Orders.ShowDialog();
        }

        private void ClientCart_Click(object sender, RoutedEventArgs e)
        {
            Client_cart client_Cart = new Client_cart();
            this.Hide();
            client_Cart.ShowDialog();
        }
    }
}
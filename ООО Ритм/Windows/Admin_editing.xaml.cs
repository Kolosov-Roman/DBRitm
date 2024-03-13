using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
    public partial class Admin_editing : Window
    {
        private Product_class selectedProduct;
        List<ProductInOrder> productInOrders = new List<ProductInOrder>();
        List<Product_class> products = new List<Product_class>();
        Catalog_admin catalogAdmin = new Catalog_admin();

        public Admin_editing(Product_class selectedProduct)
        {
            InitializeComponent();
            this.selectedProduct = selectedProduct;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            products.Add(selectedProduct);
            listBoxProductEditing.ItemsSource = products;
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
            catalogAdmin.Show();
        }

        private void Button_DeleteProduct(object sender, RoutedEventArgs e)
        {
            int deletingProduct = selectedProduct.Product.idProduct;

            productInOrders = Helper.DB.ProductInOrder.Where(p => p.idProduct == deletingProduct).ToList();

            string connectionString = "Data Source=DESKTOP-QCHFEM5;Initial Catalog=DB_Ritm;Integrated Security=True";
            string sqlQuery = $"DELETE FROM Product WHERE idProduct = {deletingProduct}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();

                    if (productInOrders.Count > 0)
                    {
                        MessageBox.Show("Данная позиция находится в заказе.");
                        this.Close();
                        catalogAdmin.Show();
                        return;
                    }

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Позиция удалена успешно.");
                        this.Close();
                        catalogAdmin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить позицию.");
                        this.Close();
                        catalogAdmin.Show();
                    }
                }
            }
        }

        private void Button_SaveChanges(object sender, RoutedEventArgs e)
        {

        }
    }
}
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace ООО_Ритм.Windows
{
    /// <summary>
    /// Логика взаимодействия для Admin_adding.xaml
    /// </summary>
    public partial class Admin_adding : Window
    {
        Product product = new Product();
        Catalog_admin catalog_Admin = new Catalog_admin();
        public Admin_adding()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
            catalog_Admin.Show();
        }

        private void Button_SaveChanges(object sender, RoutedEventArgs e)
        {
            product.category = (cbCategory.SelectedItem as ComboBoxItem).Content.ToString();
            product.price = Convert.ToInt32(tbPrice.Text);
            product.titleProduct = tbTitle.Text;
            product.maker = tbMaker.Text;
            product.description = tbDescription.Text;
            product.discount = Convert.ToInt32(tbDiscount.Text);

            Helper.DB.Product.Add(product);
            try
            {
                Helper.DB.SaveChanges();
                MessageBox.Show("Позиция добавлена успешно.");
            }
            catch
            {
                MessageBox.Show("При добавлении позиции произошла ошибка.");
            }
        }

        private void Button_TakePhoto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                product.image = openFileDialog.SafeFileName.Replace(".png", "");
                string temp = Environment.CurrentDirectory + @"\Images\" + product.image + ".png";
                if (File.Exists(temp))
                {
                    return;
                }
                File.Copy(filePath, temp);
            }
        }
    }
}

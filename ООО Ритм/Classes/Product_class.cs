using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ООО_Ритм.Classes
{
    public class Product_class
    {
        public Product_class(DB_Ritm.Product product)
        {
            this.Product = product;
        }
        public DB_Ritm.Product Product { get; set; }

        //фото + папка
        public string ProductPhotoPath
        {
            get
            {
                string temp = Environment.CurrentDirectory + "/Images/" + Product.image + ".png";
                if (!File.Exists(temp))
                {
                    temp = "/Resourses/picture.png";
                }
                return temp;
            }
        }

        //цена со скидкой
        public double ProductCostWithDiscount
        {
            get
            {
                double temp = 0.0;
                double discount = (double)Product.price * (double)Product.discount / 100;
                temp = (double)Product.price - discount;
                return temp;
            }
        }
    }
}

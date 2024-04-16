using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPValid
{
    public class ProductManager
    {
        public static void AddProduct()
        {
            Product product = new Product();
            Console.WriteLine("Eklenecek ürün ID giriniz");
            product.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Ürün adı giriniz");
            product.Name = Console.ReadLine();

            Console.WriteLine("Ürün fiyatı giriniz");
            product.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ürün ekleme başarılı");
        }
    }
}

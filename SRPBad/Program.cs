
namespace SRPBad 
{
    class Program 
    { 
      public static void Main(string[] args) 
      { 
        Product product = new Product();
            Console.WriteLine("Hoşgeldiniz!");
            Console.WriteLine("Eklenecek ürün ID giriniz");
            product.ID =int.Parse(Console.ReadLine());
            Console.WriteLine("ürün adı giriniz");
            product.Name = (Console.ReadLine());
            Console.WriteLine("ürün fiyat giriniz");
            product.Price=decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ürün ekleme başarılı");

       }
    }
}
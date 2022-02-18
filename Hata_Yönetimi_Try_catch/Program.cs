using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yönetimi_Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir Sayı Gİriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş oldunuz Sayi: " + sayi);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata " + ex.Message.ToString());
            }
            finally 
            {
                Console.WriteLine("İşlem tamamlandı");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000000");
            }
            catch (ArgumentNullException ex  )
            {
                Console.WriteLine("Boş Deger Girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Degil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok Küçük yada Çok Büyük Deger Girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Başarıyla Tamamlandı");
            }


            Console.ReadLine();
        }
    }
}

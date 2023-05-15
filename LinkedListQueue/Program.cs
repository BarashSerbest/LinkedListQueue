using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var kuyruk = new Queue(); // "kuyruk" isminde "Queue" Class türünden değişken tanımlandı. "Queue" üzerinden "F12" tuşu ile Class içerisine gidip kod incelenebilir. 
            int tercih;

            do // Kullanıcıdan girilen değer 4'ten farklı olduğu süre boyunca işlem devam edecek. 
            {
                Console.WriteLine("Lütfen aşağıdaki işlemlerden birini seçiniz:");
                Console.WriteLine("1. Ekleme (Enqueue)");
                Console.WriteLine("2. Silme (Dequeue)");
                Console.WriteLine("3. Kuyruğu Görüntüle");
                Console.WriteLine("4. Çıkış");
                Console.Write("Seçiminizi yapın: ");
                tercih = int.Parse(Console.ReadLine());

                switch (tercih) // Kullanıcıdan alınan değere karşılık gelen işlemi gerçekleştirme. 
                {
                    case 1: 
                        Console.Write("Eklenecek elemanı girin: ");
                        int eleman = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        kuyruk.Enqueue(eleman);
                        break;
                    case 2:
                        kuyruk.Dequeue();
                        Console.WriteLine();
                        break;
                    case 3:
                        kuyruk.PrintQueue();
                        break;
                    case 4:
                        Console.WriteLine("\nProgram sonlandırıldı, lütfen bir tuşa basarak çıkış yapınız.");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek. Tekrar deneyin.");
                        break;
                }
                Console.WriteLine();
            } while (tercih != 4);
        }
    }

}

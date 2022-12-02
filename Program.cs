using ConsoleDarslari.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<firmasi> firmalar = new List<firmasi>();
            {
                firmalar.Add(new firmasi(1, "Asus", "ASUS"));
                firmalar.Add(new firmasi(2, "Lenovo", "LENOVO"));
                firmalar.Add(new firmasi(3, "Acer", "ACER"));
                firmalar.Add(new firmasi(4, "Hp", "HP"));
                firmalar.Add(new firmasi(5, "Dell", "DELL"));
                firmalar.Add(new firmasi(6, "Mac", "APPLE"));
                
            };

            Noutbuk noutbuk = new Noutbuk();

            noutbuk.SetObjects(firmalar);

            Console.WriteLine("---------Update`dan oldin---------");

            foreach (var item in noutbuk.Firmalar)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Autor);
            }

            Console.WriteLine("\n\n\n\n--------============------------\n\n\n\n");
           
            firmasi update1 = new firmasi(1, "Asus TUF Gaming", "ASUS");
            noutbuk.Update(update1, 1);
            
            firmasi update = new firmasi(4, "Sumsung", "SUMSUNG");
            noutbuk.Update(update, 4);

            firmasi update2 = new firmasi(6, "MacBook Pro", "APPLE");
            noutbuk.Update(update2, 6);
            
            Console.WriteLine("---------Update`dan keyin---------");

            foreach (var item in noutbuk.Firmalar)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Autor);
            }

            Console.ReadLine();
            
            

        }
    }
}

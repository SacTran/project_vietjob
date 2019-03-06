using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace du_an1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> danhba = new List<Contact>();
            char r;
            do
            {
                Console.WriteLine("Moi nhap thong tin:");
                Console.Write("Ho:");
                string ho = Console.ReadLine();
                Console.Write("Ten:");
                string ten = Console.ReadLine();
                Console.Write("Dia chi:");
                string diachi = Console.ReadLine();
                Console.Write("So dien thoai:");
                string sodt = Console.ReadLine();
                Contact co = new Contact(ho, ten, diachi, sodt);
                danhba.Add(co);
                Console.WriteLine("Ban co muon tiep tuc khong:(y/n)");
                r = Console.ReadKey().KeyChar;
            }
            while (r == 'y');
            Console.WriteLine("/n Danh sach danh ba gom:");
            foreach (Contact c in danhba)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", c.GetHo(), c.GetTen(), c.GetDiachi(), c.GetSodt());
            }
            Console.ReadLine();
        }
    }
}

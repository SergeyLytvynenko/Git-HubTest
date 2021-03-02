using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_Laba8
{
    class NewVurib
    {
        
        public void ib(string NameVurib)
        {
            Console.WriteLine("Назва виробу: {0}", NameVurib);
        }

        public void ib(string NameVurib, int CostVurib)
        {
            Console.WriteLine("Назва виробу: {0}\nВартість: {1}", NameVurib, CostVurib);
        }

        public void ib(string NameVurib, int CostVurib, byte Quality)
        {
            Console.WriteLine("Назва виробу: {0}\nВартість: {1}\nЯкість: {2}%", NameVurib, CostVurib, Quality);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NewVurib vurib1 = new NewVurib();
            // Разные реализации вызова перегружаемого метода
            
            vurib1.ib("Шахматне поле", 40, 90);

            Console.ReadLine();
        }
    }
}
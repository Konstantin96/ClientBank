using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClient.Modul;

namespace Clients
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Client[] clientDataBase = new Client[]
                {
                    new Investor("Пупкин", new DateTime(2011,5,7), rnd.Next(), 20.15),
                    new Investor("Петров", DateTime.Now, rnd.Next(), 18.75),
                    new Creditor("Обломов", new DateTime(2012, 8, 9), rnd.Next(), 18.75, rnd.Next()),
                    new Creditor("Раскольников", new DateTime(2013, 7, 19), rnd.Next(), 18.75, rnd.Next()),
                    new Organization("КлопСтрой №1", new DateTime(2013,2,18), 123456785, rnd.Next()),
                    new Organization("КлопСтрой №2", new DateTime(2014,3,8), 456456785, rnd.Next())
                };

            foreach (Client client in clientDataBase)
            {
                client.PrintInfo();
                Console.WriteLine();
            }

            Console.WriteLine();

 
        }
    }
}

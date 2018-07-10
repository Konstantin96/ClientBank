using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClient.Modul
{
    public class Organization : Client
    {
        public string Name { get; set; }
        public DateTime AccountDate { get; set; }
        public int AccountNumber { get; set; }
        public decimal AccountAmount { get; set; }

        public Organization(string name, DateTime accountDate, int accountNumber, decimal accountAmount)
        {
            Name = name;
            AccountDate = accountDate;
            AccountNumber = accountNumber;
            AccountAmount = accountAmount;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Название организации: {0}", Name);
            Console.WriteLine("Дата открытия счета: {0}", AccountDate.ToShortDateString());
            Console.WriteLine("Номер счета: {0}", AccountNumber);
            Console.WriteLine("Сумма на счету: {0}", AccountAmount);
        }

        public override bool IsClientByDate(DateTime date)
        {
            if (AccountDate == date)
                return true;
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClient.Modul
{
    public class Investor : Client
    {
        public string Surname { get; set; }
        public DateTime DepositDate { get; set; }
        public decimal DepositAmount { get; set; }
        public double DepositInterest { get; set; }

        public Investor(string surname, DateTime depositDate, decimal depositAmount, double depositInteres)
        {
            Surname = surname;
            DepositDate = depositDate;
            DepositAmount = depositAmount;
            DepositInterest = depositInteres;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Фамилия вкладчика: {0}", Surname);
            Console.WriteLine("Дата открытия вклада: {0}", DepositDate.ToShortDateString());
            Console.WriteLine("Размер вклада: {0}", DepositAmount);
            Console.WriteLine("Процент по вкладу: {0}", DepositInterest);
        }

        public override bool IsClientByDate(DateTime date)
        {
            if (DepositDate == date)
                return true;
            return false;
        }
    }
}

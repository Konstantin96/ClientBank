using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClient.Modul
{
    public class Creditor:Client
    {
        public string Surname { get; set; }
        public DateTime CreditDate { get; set; }
        public decimal CreditAmount { get; set; }
        public double CreditInterest { get; set; }
        public decimal CreditBalance { get; set; }
        public Creditor(string surname, DateTime creditDate, decimal creditAmount, double creditInterest,
                        decimal creditBalance)
        {
            Surname = surname;
            CreditDate = creditDate;
            CreditAmount = creditAmount;
            CreditInterest = creditInterest;
            CreditBalance = creditBalance;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Фамилия вкладчика: {0}", Surname);
            Console.WriteLine("Дата выдачи кредита: {0}", CreditDate.ToShortDateString());
            Console.WriteLine("Размер кредита: {0}", CreditAmount);
            Console.WriteLine("Процент по кредиту: {0}", CreditInterest);
            Console.WriteLine("Остаток долга: {0}", CreditBalance);
        }
        public override bool IsClientByDate(DateTime date)
        {
            if (CreditDate == date)
                return true;
            return false;
        }
    }
}

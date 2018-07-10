using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClient.Modul
{
    public abstract class Client
    {
        public abstract void PrintInfo();
        public abstract bool IsClientByDate(DateTime date);
    }
}

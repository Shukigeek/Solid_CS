using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class SmsAlert : ISmsAlert
    {
        public void SendSms(string phonNumber, string message)
        {
            Console.WriteLine($"{phonNumber} : {message}");
        }

    }
}

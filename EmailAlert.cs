using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class EmailAlert : IEmailAlert
    {
        public void SendEmail(string emailAdress, string message)
        {
            Console.WriteLine($"{emailAdress} : {message}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmergencyHandler handler = new EmergencyHandler("shukihefler@gmail.com", "alert", "+9765345798");
            handler.EmergencyShutdown();
        }
    }
}

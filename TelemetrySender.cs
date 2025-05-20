using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid_Principle
{
    internal class TelemetrySender :IEmailAlert , ISmsAlert
    {
        public void SendTelemetry()
        {
            Console.WriteLine("Telemetry sent to Earth...");
        }
        public void SendEmail(string email, string message)
        {
            Console.WriteLine(email,message);
        }
        public void SendSms(string sms) 
        {
            Console.WriteLine(sms);
        }
    }
}

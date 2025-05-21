using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Solid_Principle
{
    internal class EmergencyHandler
    {
        public EmailAlert emailAlert = new EmailAlert();
        public SmsAlert smsAlert = new SmsAlert();
        public TelemetrySender telemetrySender = new TelemetrySender();

        string Email;
        string Message;
        string PhonNumber;
        public EmergencyHandler(string email, string message, string  phonNumber)
        {
            Email = email;
            Message = message;
            PhonNumber = phonNumber;
        }
        public void EmergencyShutdown()
        {
            Console.WriteLine("Emergency shutdown triggered!");
            emailAlert.SendEmail(Email, Message);
            smsAlert.SendSms(PhonNumber, Message);
            telemetrySender.SendTelemetry();
        


    }
        
        }
    }


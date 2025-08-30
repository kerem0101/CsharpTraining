using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining.Snippets
{
    internal class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending email...");
            Disconnect();

        }

        private void Connect()
        {
            Console.WriteLine("Connecting to email server...");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authanticating...");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnect from email server...");
        }
    }
}

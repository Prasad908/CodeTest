using OnlineInventory.Models;
using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineInventory
{
    public class Email
    {
        public void SendEmail(Order order)
        {
            //Creating a mail message
            MailMessage mail = new MailMessage();

            //set the address
            
            mail.From = new MailAddress("xyza@gml.com");
            mail.To.Add(new MailAddress("admin@gml.com"));

            //set the message.

            mail.Subject = "User Order Details" + DateTime.Now;
            mail.Body = "User Details and " + order.OrderId;

            //setting the connection

            SmtpClient Message = new SmtpClient("LocalHost");
            try
            {
                Message.Credentials = new System.Net.NetworkCredential("username", "Password");
                Message.Send(mail);
            }
            catch (Exception Ex)
            {
                Exception Ex1 = Ex;
                string errorMessage = string.Empty;
                while (Ex1 != null)
                {
                    errorMessage += Ex1.ToString();
                    Ex1 = Ex1.InnerException;
                }

                Console.WriteLine("Error Message");

            }
        }
    }
}

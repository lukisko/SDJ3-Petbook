using System;
using System.Net.Mail;
using business_logic.Controllers;

namespace business_logic.Model
{
    public class EmailHandler : IEmailHandler
    {
        private static void sendEmail(string EmailAddress, string title, string content){
            Console.WriteLine("in sendEmail final method");
            MailMessage mail = new MailMessage();
            SmtpClient mailClient = new SmtpClient("smtp.mail.com");

            mail.From = new MailAddress("PetBook@mail.com");
            mail.To.Add(EmailAddress);
            mail.Subject = title;
            mail.Body = content;
            Console.WriteLine("in the middle");

            mailClient.Port = 587;
            mailClient.Credentials = new System.Net.NetworkCredential("PetBook@mail.com","Pet3@Book4");
            mailClient.EnableSsl = true;
            Console.WriteLine("at the end");

            //mailClient.Send(mail);
            mailClient.SendMailAsync(mail).ContinueWith((task) => {
                if (task.IsFaulted){
                    Console.WriteLine(EmailAddress+":"+title+":"+content);
                    Console.WriteLine(task.Exception);
                }
            });
        }
        public void sendLoginLink(string EmailAddress, string LoginCode){
            EmailHandler.sendEmail(EmailAddress,"login code","Hello, here you have your login code: "+LoginCode);
        }
    }
}
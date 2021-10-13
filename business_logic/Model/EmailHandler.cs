using System;
using System.Net.Mail;

namespace business_logic.Model
{
    public class EmailHandler : IEmailHandler
    {
        public void sendEmail(string EmailAddress, string title, string content){
            MailMessage mail = new MailMessage();
            SmtpClient mailClient = new SmtpClient("smtp.mail.com");

            mail.From = new MailAddress("PetBook@mail.com");
            mail.To.Add(EmailAddress);
            mail.Subject = title;
            mail.Body = content;

            mailClient.Port = 587;
            mailClient.Credentials = new System.Net.NetworkCredential("PetBook@mail.com","********");
            mailClient.EnableSsl = true;

            //mailClient.Send(mail);
            mailClient.SendMailAsync(mail);
        }
        public void sendLoginLink(string EmailAddress, string LoginCode){

        }
    }
}
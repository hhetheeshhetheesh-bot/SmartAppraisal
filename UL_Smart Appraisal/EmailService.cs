using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace UL_Smart_Appraisal
{
    public static class EmailService
    {
        public static void SendPasswordChangeMail(
           string toEmail,
           int userId,
           string newPassword)
        {
            if (string.IsNullOrWhiteSpace(toEmail))
                return;

            var message = new MailMessage
            {
                From = new MailAddress("hetheesheduguttu@gmail.com", "Smart Appraisal System"),
                Subject = "Password Changed Successfully",
                Body =
                    $"Hello {userId},\n\n" +
                    $"Your password has been changed successfully.\n\n" +
                    $"User ID: {userId}\n" +
                    $"New Password: {newPassword}\n\n" +
                    $"If you did not perform this action, please contact admin.\n"+
                    $"Regards,\n"+
                    $"SmartAppraisal Team",
                IsBodyHtml = false
            };

            message.To.Add(toEmail);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(
                    "hetheesheduguttu@gmail.com",
                    "rrta lajm ftja lkhr") 
            };

            smtp.Send(message);
        }

        
    }
}

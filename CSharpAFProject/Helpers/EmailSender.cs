/*using System;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace CSharpAFProject.Helpers
{
    /// <summary>
    /// Helper methods for Email.
    /// </summary>
    public static class EmailSender
    {
        /// <summary>
        /// send emails to perticular recipients 
        /// </summary>
        /// <param name="EmailAddress">email addresses of recipients</param>
        /// <param name="emailSubject">emailSubject</param>
        /// <param name="filepath">path of the file that has to attached</param>
        /// <param name="emailBody">emailBody that has to be written</param>
        /// <example>How to use it: <code>
        /// EmailSender.SendEmail(Settings.EmailAddress, Settings.EmailSubject, HtmlReportFullPath.Replace("TestResults", "index"), Settings.EmailBody);
        /// </code></example>

        public static void SendEmail(string[] emailDestinations, string emailSubject, string filePathToBeAttached, string emailBody)
         {
             var ol = new Outlook.Application();
             Outlook.MailItem mail = ol.CreateItem(Outlook.OlItemType.olMailItem) as Outlook.MailItem;

            mail.Subject = emailSubject;
             Outlook.AddressEntry currentUser =
                 ol.Session.CurrentUser.AddressEntry;
             if (currentUser.Type == "EX")
             {
                 foreach (string email in emailDestinations)
                 {
                     if (!String.IsNullOrEmpty(email) && !String.IsNullOrWhiteSpace(email))
                         mail.Recipients.Add(email);
                 }
                 mail.Recipients.ResolveAll();
                 mail.Attachments.Add(filePathToBeAttached,
                     Outlook.OlAttachmentType.olByValue, Type.Missing,
                     Type.Missing);
                 mail.Body = emailBody;
                 if (mail.Recipients.Count > 0)
                     mail.Send();
             }
         }

    }
}

*/
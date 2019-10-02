using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outings_Console
{
    class ProgramUI
    {


    }

    //display a list of all outings


    //add individual outings to a list(dont need to delete)

    //calculations combined cost for all outings
    //    see a display of all outing cost by tybe
    //    ex.--$2000.00 for all bowling outings for 1 year
    //        conserts were $5000.00


}






//Console.WriteLine("Mail To");
//        MailAddress to = new MailAddress(Console.ReadLine());

//Console.WriteLine("Mail From");
//        MailAddress from = new MailAddress(Console.ReadLine());

//MailMessage mail = new MailMessage(from, to);

//Console.WriteLine("Subject");
//        mail.Subject = Console.ReadLine();

//        Console.WriteLine("Your Message");
//        mail.Body = Console.ReadLine();

//        SmtpClient smtp = new SmtpClient();
//smtp.Host = "smtp.gmail.com";
//        smtp.Port = 587;

//        smtp.Credentials = new NetworkCredential(
//            "username@domain.com", "password");
//smtp.EnableSsl = true;
//        Console.WriteLine("Sending email...");
//        smtp.Send(mail);


//private void ThisAddIn_Startup(object sender, System.EventArgs e)
//{
//    SendEmailtoContacts();
//}

//private void SendEmailtoContacts()
//{
//    string subjectEmail = "Meeting has been rescheduled.";
//    string bodyEmail = "Meeting is one hour later.";
//    Outlook.MAPIFolder sentContacts = (Outlook.MAPIFolder)
//        this.Application.ActiveExplorer().Session.GetDefaultFolder
//        (Outlook.OlDefaultFolders.olFolderContacts);
//    foreach (Outlook.ContactItem contact in sentContacts.Items)
//    {
//        if (contact.Email1Address.Contains("example.com"))
//        {
//            this.CreateEmailItem(subjectEmail, contact
//                .Email1Address, bodyEmail);
//        }
//    }
//}

//private void CreateEmailItem(string subjectEmail,
//       string toEmail, string bodyEmail)
//{
//    Outlook.MailItem eMail = (Outlook.MailItem)
//        this.Application.CreateItem(Outlook.OlItemType.olMailItem);
//    eMail.Subject = subjectEmail;
//    eMail.To = toEmail;
//    eMail.Body = bodyEmail;
//    eMail.Importance = Outlook.OlImportance.olImportanceLow;
//    ((Outlook._MailItem)eMail).Send();
//}



//This example requires:

//Contacts that have the domain name example.com in their email addresses.
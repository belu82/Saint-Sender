using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


using System.IO;
namespace Saint_Sender
{
    public class Email
    {

        public string sender;
        public string subject;
        public string date;
        public string address;
        public string content;



       

        public Email()
        {
        }

        public Email(string sender, string subject, string date, string address, string content)
        {
            this.sender = sender;
            this.subject = subject;
            this.date = date;
            this.address = address;
            this.content = content;
        }

        public void SaveMail(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Email));
                serializer.Serialize(stream, this);

            }
        }

        public static Email LoadMail(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Email));
                return (Email)deserializer.Deserialize(stream);
            }
        }
    
        /*
        public void getMails()
        {
            try
            {

                string localInbox = string.Format("{0}\\inbox", Directory.GetCurrentDirectory());
                if (!Directory.Exists(localInbox))
                {
                    Directory.CreateDirectory(localInbox);
                }

                MailServer oServer = new MailServer("imap.gmail.com",
                                "beluhbo82@gmail.com",
                                "Manson82",
                                ServerProtocol.Imap4);

                oServer.SSLConnection = true;

                oServer.Port = 993;

                MailClient oClient = new MailClient("TryIt");
                oClient.Connect(oServer);

                MailInfo[] infos = oClient.GetMailInfos();
                //Console.WriteLine("Total {0} email(s)\r\n", infos.Length);
                for (int i = 0; i < infos.Length; i++)
                {
                    MailInfo info = infos[i];
                    //Console.WriteLine("Index: {0}; Size: {1}; UIDL: {2}",
                    //info.Index, info.Size, info.UIDL);

                    Mail oMail = oClient.GetMail(info);
                          
                }

                oClient.Quit();
            }
            catch (Exception ep)
            {
                Console.WriteLine(ep.Message); 
            }
        }
        */

       
    }
}

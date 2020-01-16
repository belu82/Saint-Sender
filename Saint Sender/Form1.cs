using System;
using Limilabs.Client.IMAP;
using Limilabs.Client.POP3;
using Limilabs.Client.SMTP;
using Limilabs.Mail;
using Limilabs.Mail.MIME;
using Limilabs.Mail.Fluent;
using Limilabs.Mail.Headers;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Saint_Sender
{

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static readonly Flag All;
        public Form1()
        {
            InitializeComponent();

            loadMails();

        }


        public void loadMails()
        {

            Limilabs.Mail.Log.Enabled = true;
            using (Imap imap = new Imap())
            {
                imap.ConnectSSL("imap.gmail.com");       // or ConnectSSL for SSL

                imap.UseBestLogin("beluhbo82@gmail.com", "Manson82");
                
                imap.SelectInbox();
                List<long> uidList = imap.Search(Flag.Unseen);
                if(uidList.Count == 0)
                {
                    metroLabel1.Text = "You have no new messages";
                }
                else
                {
                    foreach (long uid in uidList)
                    {
                        //saving e-mails to eml format
                        var eml = imap.GetMessageByUID(uid);
                        /*
                        string fileName = string.Format(@"d:\teszt\email_{0}.eml", uid);
                        File.WriteAllBytes(fileName, eml);
                        */
                        IMail mail = new MailBuilder().CreateFromEml(eml);

                        string[] newMail = new string[3];
                        ListViewItem itm;
                        newMail[0] = mail.Sender.Name.ToString();
                        newMail[1] = mail.Subject.ToString();
                        newMail[2] = mail.Date.ToString();
                        itm = new ListViewItem(newMail);
                        metroListView1.Items.Add(itm);
                    }
                    imap.Close();
                }
                
            }
        }

        public void metroButton1_Click(object sender, EventArgs e)
        {
            metroListView1.Refresh();
            using (Imap imap = new Imap())
            {
                imap.ConnectSSL("imap.gmail.com");       // or ConnectSSL for SSL
                imap.UseBestLogin("beluhbo82@gmail.com", "Manson82");

                imap.SelectInbox();
                List<long> uidList = imap.Search(Flag.All);
                if (uidList.Count > 0)
                {
                    metroLabel1.Text = "All emails:";
                }
                
                foreach (long uid in uidList)
                {
                    //saving e-mails to eml format
                    var eml = imap.GetMessageByUID(uid);
                    /*
                    string fileName = string.Format(@"d:\teszt\email_{0}.eml", uid);
                    File.WriteAllBytes(fileName, eml);
                    */
                    IMail mail = new MailBuilder().CreateFromEml(eml);

                    string[] newMail = new string[5];
                    ListViewItem itm;
                    newMail[0] = mail.Sender.Name.ToString();
                    newMail[1] = mail.Subject.ToString();
                    newMail[2] = mail.Date.ToString();
                    newMail[3] = mail.Text.ToString();
                    newMail[4] = mail.Sender.Address.ToString();
                  
                    itm = new ListViewItem(newMail);
                    metroListView1.Items.Add(itm);
                }
                imap.Close();

                uidList.Clear();
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //metroButton1.PerformClick();
        }

        private void newMessageButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void showMessageButton_Click(object sender, EventArgs e)
        {
            string senderName;
            string mailAddress;
            string subject;
            string date;
            string content;


            senderName = metroListView1.SelectedItems[0].SubItems[0].Text;
            mailAddress = metroListView1.SelectedItems[0].SubItems[4].Text;
            subject = metroListView1.SelectedItems[0].SubItems[1].Text;
            date = metroListView1.SelectedItems[0].SubItems[2].Text;
            content = metroListView1.SelectedItems[0].SubItems[3].Text;

            Email emails = new Email(senderName, mailAddress, date, subject, content);
            emails.SaveMail("Valami.xml");
            ReadMailFrom email = new ReadMailFrom();
         
            email.Show();
            this.Hide();
        }
    }
}

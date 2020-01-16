using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Saint_Sender
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {

        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ádám\Downloads\LoginForm\LoginForm\LoginForm\Login.mdf;Integrated Security=True;Connect Timeout=30";
        public Form2()
        {
            InitializeComponent();
        }

        
        private void loginButton_Click(object sender, EventArgs e)
        {
            MailMessage mymessage = new MailMessage();
            SmtpClient gmailsetupsmtp = new SmtpClient("smtp.gmail.com");
            gmailsetupsmtp.Port = 587;
            gmailsetupsmtp.Credentials = new System.Net.NetworkCredential(textMail.Text, textPassw.Text);
            gmailsetupsmtp.EnableSsl = true;
            User user = new User(textMail.Text, textPassw.Text);
            user.mailAddress = textMail.Text;
            user.password = textPassw.Text;
            user.save(textMail.Text, textPassw.Text);

            user = null;


            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            /*
            if (textMail.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textMail.Focus();
                return;
            }
            if (textPassw.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassw.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT Username,Password FROM Users WHERE Username = @Username AND Password = @Password", myConnection);

                SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);

                uName.Value = textMail.Text;
                uPassword.Value = textPassw.Text;

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    MessageBox.Show("You have logged in successfully " + textMail.Text);
                    User user = new User(textMail.Text, textPassw.Text);
                               
                    Form1 form = new Form1();
                    this.Hide();
                    form.Show();
                }


                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textMail.Clear();
                    textPassw.Clear();
                    textMail.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            /*
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ádám\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(str);
            //con.ConnectionString = (str);
            SqlDataAdapter sda = new SqlDataAdapter("select  Count (*) from Login where User ='" +textMail.Text + "' and Password ='" + textPassw.Text +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form1 form = new Form1();
            }

            else
            {

                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
               
            }
            con.Close();

            */
            /*
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count <= 0)
            {
                MessageBox.Show("Nem jó");
            }
            else
            {
                this.Hide();
                Form1 form1 = new Form1();
            }
            */
        }
        public string TextboxText() { 
             return textMail.Text; 
        }
    }
}

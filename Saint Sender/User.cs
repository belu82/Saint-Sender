using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Saint_Sender
{
    class User
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ádám\Downloads\LoginForm\LoginForm\LoginForm\Login.mdf;Integrated Security=True;Connect Timeout=30";

        public string mailAddress { get; set; }
        public string password { get; set; }

        public User(string mailAddress, string password)
        {
            this.mailAddress = mailAddress;
            this.password = password;
        }

        public User()
        {
        }

       public void save(string mailAddress, string password)
        {
            
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs);

                SqlCommand myCommand = default(SqlCommand);
                //ellenőrzés előtti
                //myCommand = new SqlCommand("INSERT into Users(Username, Password) values(@Username, @Password)", myConnection);
                
                myCommand = new SqlCommand("SELECT COUNT (*) from Users where Username = @Username", myConnection);
                myCommand.Connection.Open();
                myCommand.Parameters.AddWithValue("@Username", value: mailAddress);
                myCommand.Parameters.AddWithValue("@Password", value: password);
                
                int userCount = (int)myCommand.ExecuteScalar();
                if(userCount > 0)
                {
                    MessageBox.Show("Bent vagy");
                    myCommand.Connection.Close();
                }
                else
                {       
                    myCommand = new SqlCommand("INSERT into Users(Username, Password) values(@Username, @Password)", myConnection);
                    myCommand.Parameters.AddWithValue("@Username", value: mailAddress);
                    myCommand.Parameters.AddWithValue("@Password", value: password);
                    /*
                    SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
                    SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);

                    myCommand.Parameters.Add(uName);
                    myCommand.Parameters.Add(uPassword);
                    */
                    //myCommand.Connection.Open();

                    SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        public void Save1(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(User));
                serializer.Serialize(stream, this);
            }

        }
    }
}

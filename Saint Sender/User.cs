using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Saint_Sender
{
    class User
    {
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

       
    }
}

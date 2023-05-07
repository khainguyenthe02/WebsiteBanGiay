using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTLW
{
    public class NguoiDung
    {
        private string sUsername;
        private string sEmail;
        private string sPassword;
        private string sRepassword;
        public NguoiDung(string username, string email, string password, string repassword)
        {
            this.SUsername = username;
            this.SEmail = email;
            this.SPassword = password;
            this.SRepassword = repassword;
        }

        public string SUsername { get => sUsername; set => sUsername = value; }
        public string SEmail { get => sEmail; set => sEmail = value; }
        public string SPassword { get => sPassword; set => sPassword = value; }
        public string SRepassword { get => sRepassword; set => sRepassword = value; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace earthGrade
{
    class user 
    {
        private int userid;
        private string gebruikersnaam;
        private string password;
        private string email;
        private int punten;

        public int myPunten
        {
            get { return punten; }
        }

        public user(int userid, string gebruikersnaam, string password, string email, int punten)
        {
            this.userid = userid;
            this.gebruikersnaam = gebruikersnaam;
            this.password = password;
            this.email = email;
            this.punten = punten;
        }

    }
}

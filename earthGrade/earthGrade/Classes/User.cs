using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace earthGrade.Classes
{
    class User
    {
        private int userid;
        private string gebruikersnaam;
        private string password;
        private string email;
        private int punten;

        public int myPunten
        {
            get { return punten; }
            set { punten = value; }
        }

        public User(int userid, string gebruikersnaam, string password, string email, int punten)
        {
            this.userid = userid;
            this.gebruikersnaam = gebruikersnaam;
            this.password = password;
            this.email = email;
            this.punten = myPunten;
        }

        public void removePoints(int amount)
        {
            if (amount >= 100)
            {
                punten -= amount;
            }
        }

    }
}

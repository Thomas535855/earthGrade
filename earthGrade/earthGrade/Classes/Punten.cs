using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace earthGrade.Classes
{
    public class Punten
    {
        private int puntenBeheer;
        private int puntenSaldo;

        public Punten(int beheer, int saldo)
        {
            puntenBeheer = beheer;
            puntenSaldo = saldo;
        }

        // public int CalculatePoints(int starRating)
        //{
        //  int punten = 0;
        //switch (starRating)
        //{
        //  case 2:
        //    punten = 1;
        //  break;
        //case 3:
        //  punten = 5;
        // break;
        //case 4:
        //  punten = 12;
        //  break;
        // case 5:
        //   punten = 25; 
        // break;
        // default:
        //   punten = 0;
        // break;
        // }
        // return punten;
        //}

        public void puntenToevoegen(int puntenToevogen)
        {
            puntenSaldo += puntenToevogen;
        }

        public int puntenTotaal()
        {
            return puntenSaldo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace earthGrade
{
    class product
    {
        private int productId;
        private string productName;
        private string barcode;
        private double rating;

        public product(int productId, string productName, string barcode, double rating)
        {
            this.productId = productId;
            this.productName = productName;
            this.barcode = barcode;
            this.rating = rating;
        }

        public void rateDuurzaamheid(string product)
        {
            user test2 = new user(4, "sfad", "sdafas", "fssd", 0);
            
            MessageBox.Show("Duurzaamheids rating: " + rating + "/n" + "Punten: " + test2.myPunten);
        }
    }
}

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
        public int id
        {
            get { return productId; }
            set { productId = value; }
        }
        public string name
        {
            get { return productName; }
            set { productName = value; }
        }
        public string code
        {
            get { return barcode;}
            set { barcode = value; }
        }
        public double sterren
        {
            get { return rating; }
            set { rating = value; }
        }

        public product(int productId, string productName, string barcode, double rating)
        {
            this.productId = productId;
            this.productName = productName;
            this.barcode = barcode;
            this.rating = rating;
        }

        
    }
}

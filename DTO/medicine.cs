using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class medicine
    {
        private int barcode;
        private string name;
        private double price;
        private DateTime dateOfManu;
        private DateTime dateExp;
        private string howToUse;
        private int codeSupplier;

        public medicine(int barcode, string name, double price, DateTime dateOfManu, DateTime dateExp, string howToUse, int codeSupplier)
        {
            this.barcode = barcode;
            this.name = name;
            this.price = price;
            this.dateOfManu = dateOfManu;
            this.dateExp = dateExp;
            this.howToUse = howToUse;
            this.codeSupplier = codeSupplier;
        }

        public int Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public DateTime DateOfManu
        {
            get { return dateOfManu; }
            set { dateOfManu = value; }
        }

        public DateTime DateExp
        {
            get { return dateExp; }
            set { dateExp = value; }
        }

        public string HowToUse
        {
            get { return howToUse; }
            set { howToUse = value; }
        }

        public int CodeSupplier
        {
            get { return codeSupplier; }
            set { codeSupplier = value; }
        }
    }
}

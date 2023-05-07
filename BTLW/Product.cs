using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTLW
{
    public class Product
    {
        private string sName;
        private string sID;
        private string sMota;
        private string sImage;
        private int iQuantity;
        private float fPrice;
        private string sType;

        public float FPrice { get => fPrice; set => fPrice = value; }
        public string SImage { get => sImage; set => sImage = value; }
        public string SID { get => sID; set => sID = value; }
        public string SName { get => sName; set => sName = value; }
        public string SMota { get => sMota; set => sMota = value; }
        public int IQuantity { get => iQuantity; set => iQuantity = value; }
        public string SType { get => sType; set => sType = value; }

        public Product (string Id, string Images, string Name, float Price, int quantity, string Details, string Type )
        {
            this.sName = Name;
            this.sID = Id;
            this.sMota = Details;
            this.SImage = Images;
            this.iQuantity = quantity;
            this.fPrice = Price;
            this.sType = Type;
        }
        public Product (string Id)
        {
            this.sID = Id;
        }
    }
}
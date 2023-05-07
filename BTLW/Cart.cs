using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTLW
{
    public class Cart
    {
        private string sName;
        private string sId;
        private string sImage;
        private int isoluong = 1;
        private double sPrice;

        public string SName { get => sName; set => sName = value; }
        public string SId { get => sId; set => sId = value; }
        public int Isoluong { get => isoluong; set => isoluong = value; }
        public double SPrice { get => sPrice; set => sPrice = value; }
        public string SImage { get => sImage; set => sImage = value; }

        public Cart(string id, string name, string image, int soluong, double price)
        {
            this.sId = id;
            this.sName = name;
            this.SImage = image;
            this.sPrice = price;
            this.isoluong = soluong;
        }

        public Cart() { }
        public Cart(string id)
        {
            this.sId = id;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLW
{
    public partial class Giaythoitrang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["username"].ToString() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";
            }
        }

        public string hienGiayThoiTrang()
        {
            List<Product> productList = Application[Global.PRODUCT_LIST] as List<Product>;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < productList.Count; i++)
            {
                //Product item = productList[i] as Product;
                if(productList[i].SType == "thoitrang")
                {
                    sb.AppendFormat(
                    "<div class='cardHot'>" +
                        "<a style='text-decoration:none; color: black' " +
                            "href='TrangChiTietSP.aspx?pi={0}&img={1}&name={2}&quantity={4}&price={3}'>" +
                            "<img src='{1}' alt='{2}' title='{2}'/>" +
                            "<h2 id='h2'>{2}</h2>" +
                            "<p id='gia'>{3} đồng</p>" +
                        "</a>" +
                    "</div>",
                    productList[i].SID,
                    productList[i].SImage,
                    productList[i].SName,
                    productList[i].FPrice,
                    productList[i].IQuantity);
                }
                
            }
            return sb.ToString();

        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string search_text = "";
            if (txtsearch.Value != null)
            {
                search_text = txtsearch.Value.ToLower();

            }
            Response.Redirect($"TrangTimKiem.aspx?search={search_text}");
        }
    }
}
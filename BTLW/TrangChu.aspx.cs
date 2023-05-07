using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLW
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            //string timeall = Request.QueryString["time"];
            //if (timeall != null)
            //{
            //    Response.Write("<script>alert('Thời gian bạn đăng nhập là: " + timeall + " giây')</script>");
            //}
            if (Session["username"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["username"].ToString() + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";
                DateTime tgbd = DateTime.Now;
                int min = tgbd.Minute;
                int sec = tgbd.Second;
                int timein = min * 60 + sec;
                Session["time"] = timein;

            }
        }

        public string hienSPBanChay()
        {
            List<Product> productList = Application[Global.PRODUCT_LIST] as List<Product>;
            StringBuilder sb = new StringBuilder();
            for (int i =0; i<4; i++)
            {
                Product item = productList[i] as Product;
                sb.AppendFormat(
                    "<div class='cardHot'>" +
                        "<a style='text-decoration:none; color: black' " +
                            "href='TrangChiTietSP.aspx?pi={0}&img={1}&name={2}&quantity={4}&price={3}'>" +
                            "<img src='{1}' alt='{2}' title='{2}'/>" +
                            "<h2 id='h2'>{2}</h2>" +
                            "<p id='gia'>{3} đồng</p>" +
                            
                        "</a>" +
                    "</div>",
                    item.SID,
                    item.SImage,
                    item.SName,
                    item.FPrice,
                    item.IQuantity);
            }
            return sb.ToString();
        }

        public string hienSPMoi()
        {
            List<Product> productList = Application[Global.PRODUCT_LIST] as List<Product>;
            StringBuilder sb = new StringBuilder();
            for (int i = 4; i < 8; i++)
            {
                Product item = productList[i] as Product;
                sb.AppendFormat(
                    "<div class='cardHot'>" +
                        "<a style='text-decoration:none; color: black' " +
                        "href='TrangChiTietSP.aspx?pi={0}&img={1}&name={2}&quantity={4}&price={3}'>" +
                            "<img src='{1}' alt='{2}' title='{2}'/>" +
                            "<h2 id='h2'>{2}</h2>" +
                            "<p id='gia'>{3} đồng</p>" +
                        "</a>" +
                    "</div>",
                    item.SID,
                    item.SImage,
                    item.SName,
                    item.FPrice,
                    item.IQuantity);
            }
            return sb.ToString();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string search_text = "";
            if(txtsearch.Value != null)
            {
                search_text = txtsearch.Value.ToLower();
                
            }
            Response.Redirect($"TrangTimKiem.aspx?search={search_text}");
        }
    }
}
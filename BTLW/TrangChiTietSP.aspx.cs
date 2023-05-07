using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLW
{
    public partial class TrangChiTietSP : System.Web.UI.Page
    {
        public const string cart = "cart";
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["username"].ToString() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";
            }
        }
        public string HienProductInformation()
        {
            List<Product> productList = Application[Global.PRODUCT_LIST] as List<Product>;
            
            StringBuilder sb = new StringBuilder();
            //Lấy id từ sản phẩm đã click
            string id = Request.QueryString.Get("pi");
            if (id != null)
            {
                for (int i = 0; i < productList.Count; i++)
                {
                    Product pr = productList[i] as Product;
                    if (id == pr.SID)
                    {
                        Product item = pr;
                        sb.AppendFormat(
                            "<div class ='chitietsp'>" +
                                "<table>" +
                                    "<tr>" +
                                        "<td> <img id='anhchitiet' src='{0}' alt='{1}' title='{1}'></td>" +
                                        "<td id='textchitiet'>" +
                                            "<h2 id='namegiay'>{1}</h2>" +
                                            "<hr />" +
                                            "</br>" +
                                            "<h3>Mô tả sản phẩm</h3>" +
                                            "<p>{2}</p>" +
                                            "<h3 style='margin-top: 10px;'>Cam kết</h3>" +
                                            "<ul style='margin-left: 10px;'>" +
                                                "<li>Hàng chính hãng</li>" +
                                                "<li>Giao hàng Toàn Quốc</li>" +
                                                "<li>Bảo hành chính hãng trọn đời sản phẩm</li>" +
                                            "</ul>" +
                                            "<hr style='width: 90%;' />" +
                                            "<h3>Giá tiền: <span style='color:red;'>{3}</span> đồng</h3>" +
                                            
                                        "</td>" +
                                    "</tr>" +
                                "</table>" +
                            "</div>",
                            item.SImage,
                            item.SName,
                            item.SMota,
                            item.FPrice,
                            item.SID);
                    }
                }
            }
            else
            {
                Response.Redirect("TrangChu.aspx");
            }
            return sb.ToString();

        }
        
        protected void AddToCart(object sender, EventArgs e)
        {        
            if (Session["username"] != null)
            {

                string id = Request.QueryString.Get("pi");
                //Store cart to cookies
                if (Request.Cookies["cart"] == null)
                {
                    Response.Cookies["cart"].Value = $"{id},";
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
                }
                else
                {

                    //Store cookies by productID, example: 1,2,3,40,50,... 
                    Response.Cookies["cart"].Value = Request.Cookies["cart"].Value + $"{id},";
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
                }

                string strAlertText = "<script language='javascript'> alert('Thêm vào giỏ hàng thành công' )</script>";
                Response.Write(strAlertText);
            }
            else
            {
                string strAlertText = "<script language='javascript'> alert('Bạn chưa đăng nhập!!!!' )</script>";
                Response.Write(strAlertText);
                Response.Redirect("DangNhap.aspx");
            }
        }//

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
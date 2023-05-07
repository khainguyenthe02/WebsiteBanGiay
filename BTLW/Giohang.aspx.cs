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
    public partial class Giohang : System.Web.UI.Page
    {
        
        public const string cart = "cart";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["username"].ToString() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";
                HienGioHang();

            }
            else
            {
                Response.Redirect("DangNhap.aspx");
            }
        }
            public string HienGioHang()
        {
            
            StringBuilder sb = new StringBuilder();



            int soluot = Convert.ToInt32(Application["sogiohang"]);
            int quantity = Convert.ToInt32(Application["quantity"]);

            if (Session["username"] != null)
            {
                if (Request.Cookies[cart] != null)
                {

                    List<Product> cartList = new List<Product>();
                    List<Product> productList = Application[Global.PRODUCT_LIST] as List<Product>;
                    string[] productsIDCookies = Request.Cookies[cart].Value.Split(',');
                    foreach (string productID in productsIDCookies)
                    {

                        foreach (Product product in productList)
                        {
                            if (product.SID == productID)
                            {
                                cartList.Add(product);
                                soluot++;

                                sb.AppendFormat(
                                "<tr>" +
                                    "<div style='border: 1px solid #000;'>" +
                                    "<td class='td1'> <img src='{0}' class='anh'/></td>" +
                                    "<td><p>{1}</p></td>" +
                                    "<td ><p id='price'>{2}<span> đ</span></td>" +
                                    "<td><input style='width:40%; margin-left:15%;' id='quan' type='number' runnat='server' /></td>" +
                                    "<td><a href='Xoagiohang.aspx?pi={4}' class='xoa'><button class='xoa'>Xóa</button></a></td>" +
                                    "</div>" +
                               "</tr>",
                            product.SImage,
                            product.SName,
                            product.FPrice,
                            quantity,
                            product.SID);

                            }
                        }
                    }
                    //Display products price toan bo san pham
                    float productsPrice = 0;
                    for(int i=0; i<cartList.Count; i++)
                    {
                        Product p = cartList[i] as Product;
                        productsPrice += (p.FPrice);
                    }
                    
                    products_price.InnerHtml = $"{productsPrice} <span class='cart__product-price-unit'>đ</span>";
                    sogiohang.InnerHtml = "<span>Số sản phẩm trong giỏ: " + soluot + " sản phẩm</span>";
                    //string js = "<script type=\"text / javascript\"> " +
                    //   " let txtTen = document.getElementById(\"txtTen\"); " +
                    //   "         let txtDiachi = document.getElementById(\"txtDiachi\"); " +
                    //   "         let txtSDT = document.getElementById(\"txtSDT\"); " +
                    //   "        let btnDH = document.getElementById(\"btnDH\"); " +
                    //   "        let select = document.getElementById(\"select - bank\");" +
                    //   "        btnDH.onclick = function(){ " +
                    //   "            if (txtDiachi.value.trim().length == 0 || " +
                    //   "                txtSDT.value.trim().length == 0 || " +
                    //   "                txtTen.value.trim().length == 0) " +
                    //   "            { " +
                    //   "                alert('Bạn chưa điền đầy đủ thông tin'); " +
                    //   "             } " +
                    //   "            else " +
                    //   "            { " +
                    //   "                 alert('Đặt hàng thành công' + \"\n\" + " +
                    //   "                \"Khách hàng: \" + txtTen.value + \"\n\" + " +
                    //   "                \"Địa chỉ: \" + txtDiachi.value + \"\n\" + " +
                    //   "                \"SĐT: \" + txtSDT.value + \"\n\" + " +
                    //   "                 \"Đã thanh toán qua: \" + select.options[select.selectedIndex].text); " +
                    //   "                console.log(giatri.value); " +
                    //   "            } " +
                    //   "            txtDiachi.value = txtSDT.value = txtTen.value = \"\"; " +
                    //   "        } " +
                    //   " </ script > ";
                    //Response.Write(js);
                }
                else
                {

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
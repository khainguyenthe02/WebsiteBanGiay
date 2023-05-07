using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLW
{
    public partial class ThemGiay : System.Web.UI.Page
    {
        string txtFile;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["username"].ToString() + "</p>" +
                                 "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";

                
            }
            
        }
        protected void btnThem(object sender, EventArgs e)
        {
            if(Session["username"] != null)
            {
                List<Product> productList = Application[Global.PRODUCT_LIST] as List<Product>;
                string id = txtID.Value.ToString();
                string name = txtName.Value.ToString();
                int sl = Int32.Parse(txtQuan.Value.ToString());
                float gia = float.Parse(txtPrice.Value.ToString());

                HttpPostedFile FileUp = Request.Files["txtFile"];
                if (FileUp != null && FileUp.ContentLength > 0)
                {
                    txtFile = Server.MapPath("img/" + FileUp.FileName);
                    FileUp.SaveAs(txtFile);
                }
                string file = string.Format("./img/{0}", FileUp.FileName);
                string theloai = txtLoai.Value.ToString();
                string mota = txtMoTa.Value.ToString();


                for(int i=0; i<productList.Count; i++)
                {
                    if (productList[i].SID != id && sl > 0 && name != null && gia > 0
                            && theloai == productList[i].SType && mota != null)
                    {
                        productList.Add(new Product(id, file, name, gia, sl, mota, theloai));
                    }
                }
                Application[Global.PRODUCT_LIST] = productList;
                Response.Write("<script>alert('Thêm thành công')</script>");
                Response.Redirect($"TrangChu.aspx?id={id}&name={name}");
            }
        }
    }
}
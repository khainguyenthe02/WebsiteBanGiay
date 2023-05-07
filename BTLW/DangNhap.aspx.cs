using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLW
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string usernameL = Request.Form.Get("usernameL");
                string passwordL = Request.Form.Get("passwordL");
                int dem = 0;
                
                if (usernameL != "" && passwordL != "")
                {
                    ArrayList users = Application[Global.NGUOIDUNG_LIST] as ArrayList;

                    foreach (NguoiDung user in users)
                    {
                        if (usernameL == user.SUsername)
                        {
                            dem = 1;
                            if (passwordL == user.SPassword)
                            {
                                Session["username"] = usernameL;
                                
                                Response.Redirect("TrangChu.aspx");
                                break;
                            }
                            else
                            {
                                errorL.InnerHtml = "Sai mật khẩu";                                
                                break;
                            }                           
                        }
                    }
                    if (dem == 0)
                    {
                        errorL.InnerHtml = "Tài khoản không tồn tại";
                    }
                }
            }
        }
    }
}
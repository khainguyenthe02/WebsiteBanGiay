using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLW
{
    public partial class DangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string username = Request.Form.Get("username");
                string email = Request.Form.Get("email");
                string password = Request.Form.Get("password");
                string repassword = Request.Form.Get("re-password");
                ArrayList users = Application[Global.NGUOIDUNG_LIST] as ArrayList;
                bool check = true;
                if (username != "" && email != "" && password != "" && repassword != "")
                {
                    foreach (NguoiDung user in users)
                    {
                        if (username == user.SUsername)
                        {
                            btn_error.InnerHtml = "Tài khoản đã được sử dụng";
                            check = false;
                        }
                    }

                    if (check)
                    {
                        btn_error.InnerHtml = "Đăng ký thành công";
                        NguoiDung newUser = new NguoiDung(username, email, password, repassword);
                        users.Add(newUser);
                        Application[Global.NGUOIDUNG_LIST] = users;
                    }
                }

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLW
{
    public partial class Lienhe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                login.InnerHtml = "<p class='user'>Xin chào " + Session["username"].ToString() + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";

            }
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
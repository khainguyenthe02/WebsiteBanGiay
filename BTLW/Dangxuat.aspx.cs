using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLW
{
    public partial class Dangxuat : System.Web.UI.Page
    {
        int time;
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime tgkt = DateTime.Now;
            
            int min = tgkt.Minute;
            int sec = tgkt.Second;
            int timeout = min * 60 + sec;
            int timein =(int) Session["time"] ;
            
            if(timein > 0)
            {
                 time = timeout - timein;
            }
            
            Session.Abandon();
            string strAlertText = $"<script language='javascript'> alert('Thời gian là: {time }' )</script>";
            Response.Write(strAlertText);
            Response.Redirect($"TrangChu.aspx?time={time}");
            Session["timeall"] = time;
            

        }
    }
}
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
    public partial class TrangTimKiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string search = Request.QueryString.Get("search");
            string filter = Request.QueryString.Get("filter");
            if (search != null)
            {
                if (Session["username"] != null)
                {
                    login.InnerHtml = "<p class='user'>Xin chào " + Session["username"].ToString() + "</p>" +
                                      "<a href = 'Dangxuat.aspx'> Đăng xuất </a>";

                }
                List<Product> productList = (List<Product>) Application[Global.PRODUCT_LIST];
                search = search.ToLower();

                //Khởi tạo list rỗng 
                List<Product> productListByFilter = new List<Product>();

                if(filter != null)
                {
                    if(filter == "01")
                    {
                        showProductListBySearchAndFilter(search, 0, 300000, productListByFilter, productList);
                        all_products_brand_name.InnerText = $"Kết quả tìm kiếm cho '{search}' dưới 300.000đ";
                    }
                    if (filter == "02")
                    {
                        showProductListBySearchAndFilter(search, 300000, 600000, productListByFilter, productList);
                        all_products_brand_name.InnerText = $"Kết quả tìm kiếm cho '{search}' 300.000đ - 600.000đ";
                    }
                    if (filter == "03")
                    {
                        showProductListBySearchAndFilter(search, 600000, 1000000, productListByFilter, productList);
                        all_products_brand_name.InnerText = $"Kết quả tìm kiếm cho '{search}'600.000đ - 1.000.000đ";
                    }
                }
                else
                {
                    showProductListBySearchAndFilter(search, 0, 1000000, productListByFilter, productList);
                    all_products_brand_name.InnerText = $"Kết quả tìm kiếm cho '{search}'";
                }
            }
            //update link search

            string currentUrl = Request.Url.ToString();
            int andSignPosition = currentUrl.IndexOf('&');
            if (andSignPosition != -1)
            {
                string currentUrlWithoutFilter = currentUrl.Substring(0, andSignPosition);
                Filter_01.HRef = $"{currentUrlWithoutFilter}&filter=01";
                Filter_02.HRef = $"{currentUrlWithoutFilter}&filter=02";
                Filter_03.HRef = $"{currentUrlWithoutFilter}&filter=03";
            }
            else
            {
                Filter_01.HRef = $"{currentUrl}&filter=01";
                Filter_02.HRef = $"{currentUrl}&filter=02";
                Filter_03.HRef = $"{currentUrl}&filter=03";
            }
        }
        protected void showProductListBySearchAndFilter(string search, int start, int end, List<Product> productsListByFilter, List<Product> productList)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product product in productList)
            {
                if(product.SName.ToLower().IndexOf(search) != -1 && product.FPrice >= start && product.FPrice <= end)
                {
                    productsListByFilter.Add(product);
                    
                   
                }
            }
            sanphammoi.DataSource = productsListByFilter;
            sanphammoi.DataBind();
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
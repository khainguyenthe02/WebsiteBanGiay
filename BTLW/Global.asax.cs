using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTLW
{
    public class Global : System.Web.HttpApplication
    {
        public const string PRODUCT_LIST = "ProductList";
        public const string CART_LIST = "CartList";
        public const string NGUOIDUNG_LIST = "Users";
        protected void Application_Start(object sender, EventArgs e)
        {
            //TÀI KHOẢN

            //Application["Users"] = new List<NguoiDung>();
            //List<NguoiDung> Users = (List<NguoiDung>)Application["Users"];
            //Users.Add(new NguoiDung("thekhai", "thekhai@gmail.com", "thekhai", "thekhai"));
            ArrayList MemberList = new ArrayList();
            MemberList.Add(new NguoiDung("thekhai", "thekhai@gmail.com", "thekhai", "thekhai"));
            Application[NGUOIDUNG_LIST] = MemberList;

            //arraylist sản phẩm
            List<Product> productList = new List<Product>();
            

            //sản phẩm bán chạy
            productList.Add(
                new Product("1", "../img/product-01.jpg", "Boots Martin", 750000, 1,  "Đây là mẫu boots đế bằng, mang phong cách Châu Âu với khóa kéo  tạo điểm nhấn cho đôi giày", "thethao"));
            productList.Add(
                new Product("2", "../img/product-02.jpg", "New Balance 1400", 800000, 1, "New Balance 1400 tiếp cận được với nhiều tệp khách hàng vì mang tính chất \"Casual\" vừa có thể dùng để đi làm và đi chơi." , "thethao"));
            productList.Add(
                new Product("3", "../img/product-03.jpg", "New Balance 327", 450000, 1, "Đế giữa loe Mặt trên tổng hợp, da lộn và nylon có thiết kế nanh phóng đại lấy cảm hứng từ 320,355 và Supercomp ", "thethao"));
            productList.Add(
                new Product("4", "../img/product-04.jpg", "Vans Old Classic", 650000, 1, "Sử dụng thiết kế cổ điển với gam màu đen trắng đơn giản, kết hợp chất liệu vải Canvas cùng Da lộn ở mũi và gót giày, Vans Old Skool Classic Black White phù hợp với mọi lứa tuổi, mọi không gian khác nhau", "thethao"));

            //sản phẩm mới nhất
            productList.Add(
                new Product("10", "../img/product-10.jpg", "Run Star Hike Platform", 750000, 1, "Giày thể thao đế cao vải canvas, SmartFOAM sockliner để đệm, Đế ngoài bằng cao su hai tông màu, phóng đại.", "thoitrang"));
            productList.Add(
                new Product("11", "../img/product-11.jpg", "Chelsea Boots", 800000, 1, "Đôi giày có kiểu dáng đẹp, bắt mắt, tính thẩm mỹ cao, vô cùng lịch sự khi kết hợp với các trang phục công sở thanh lịch được rất nhiều quý ông ưa chuộng.", "thoitrang"));
            productList.Add(
                new Product("12", "../img/product-12.jpg", "Giày lười Moccasin", 650000, 1, "Chất liệu da bò cao cấp, da thật 100% Form giày ôm chân, thiết kế trẻ trung hiện đại Đường chỉ may tỉ mỉ, tinh tế", "thoitrang"));
            productList.Add(
                new Product("13", "../img/product-13.jpg", "Giày da Apron Toe", 750000, 1, "Chất liệu da bò cao cấp, da thật 100% Thiết kế dáng lười thời trang, sang trọng", "thoitrang"));

            //giày thời trang
            productList.Add(new Product("14", "../img/giaythoitrang-14.jpg", "Jordan Dior", 760000, 1, "Sự giao thoa giữa văn hóa đường phố với thời trang high fashion tạo nên một cái nhìn thật sự khác lạ, cao cấp, bóng bẩy ", "thoitrang"));
            productList.Add(new Product("15", "../img/giaythoitrang-15.jpg", "Giày Oxford", 550000, 1, "Chất liệu da bò cao cấp, da thật 100% Thiết kế dáng lười thời trang, sang trọng", "thoitrang"));
            productList.Add(new Product("16", "../img/giaythoitrang-16.jpg", "Adidas Superstar", 650000, 1, "Đôi giày có kiểu dáng đẹp, bắt mắt, tính thẩm mỹ cao, vô cùng lịch sự khi kết hợp với các trang phục công sở thanh lịch được rất nhiều quý ông ưa chuộng.", "thoitrang"));
            productList.Add(new Product("17", "../img/giaythoitrang-17.jpg", "Chuck Plasform", 450000, 1, "Đế giữa loe Mặt trên tổng hợp, da lộn và nylon có thiết kế nanh phóng đại lấy cảm hứng từ 320,355 và Supercomp", "thoitrang"));
            productList.Add(new Product("18", "../img/giaythoitrang-18.jpg", "Giày lười GNTA", 250000, 1, "Chất liệu da bò cao cấp, da thật 100% Thiết kế dáng lười thời trang, sang trọng", "thoitrang"));
            productList.Add(new Product("19", "../img/giaythoitrang-19.jpg", "Knight Boots", 670000, 1, "Đôi giày có kiểu dáng đẹp, bắt mắt, tính thẩm mỹ cao, vô cùng lịch sự khi kết hợp với các trang phục công sở thanh lịch được rất nhiều quý ông ưa chuộng.", "thoitrang"));
            productList.Add(new Product("20", "../img/giaythoitrang-20.jpg", "Martin Boots", 300000, 1, "Đây là mẫu boots đế bằng, mang phong cách Châu Âu với khóa kéo  tạo điểm nhấn cho đôi giày", "thoitrang"));
            productList.Add(new Product("21", "../img/giaythoitrang-21.jpg", "Giày bệt Dior", 350000, 1, "Chất liệu da bò cao cấp, da thật 100% Thiết kế dáng lười thời trang, sang trọng", "thoitrang" ));

            //giày thể thao
            productList.Add(new Product("22", "../img/giaythethao-22.jpg",  "Air Force One",250000, 1, "Đây là mẫu boots đế bằng, mang phong cách Châu Âu với khóa kéo  tạo điểm nhấn cho đôi giày", "thethao"));
            productList.Add(new Product("29", "../img/giaythethao-29.jpg",  "Jockey Style", 640000, 1, "Chất liệu da bò cao cấp, da thật 100% Thiết kế dáng lười thời trang, sang trọng", "thethao"));
            productList.Add(new Product("23",  "../img/giaythethao-24.jpg",  "Sneaker Jordan", 550000, 1, "Đôi giày có kiểu dáng đẹp, bắt mắt, tính thẩm mỹ cao, vô cùng lịch sự khi kết hợp với các trang phục công sở thanh lịch được rất nhiều quý ông ưa chuộng.", "thethao"));
            productList.Add(new Product("24", "../img/giaythethao-25.jpg", "Vans Old Skoll", 820000, 1, "Chất liệu da bò cao cấp, da thật 100% Form giày ôm chân, thiết kế trẻ trung hiện đại Đường chỉ may tỉ mỉ, tinh tế", "thethao"));
            productList.Add(new Product("25", "../img/giaythethao-26.jpg", "MC Queen", 320000, 1, "Đế giữa loe Mặt trên tổng hợp, da lộn và nylon có thiết kế nanh phóng đại lấy cảm hứng từ 320,355 và Supercomp", "thethao"));
            productList.Add(new Product("26", "../img/giaythethao-27.jpg", "YZ Force", 450000, 1, "Đây là mẫu boots đế bằng, mang phong cách Châu Âu với khóa kéo  tạo điểm nhấn cho đôi giày", "thethao"));
            productList.Add(new Product("27", "../img/giaythethao-28.jpg", "Kappa Blue", 680000, 1, "Đế giữa loe Mặt trên tổng hợp, da lộn và nylon có thiết kế nanh phóng đại lấy cảm hứng từ 320,355 và Supercomp", "thethao"));
            productList.Add(new Product("28",  "../img/giaythethao-23.jpg",  "Air Force White", 390000, 1, "Chất liệu da bò cao cấp, da thật 100% Thiết kế dáng lười thời trang, sang trọng", "thethao"));
            productList.Add(new Product("30", "../img/product-13.jpg", "Giày da Apron Toe II", 900000, 1, "Chất liệu da bò cao cấp, da thật 100% Thiết kế dáng lười thời trang, sang trọng", "thethao"));
            Application[PRODUCT_LIST] = productList;

            //arraylist giỏ hàng
            
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = 0;
            Session["giohang"] = new List<Cart>();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
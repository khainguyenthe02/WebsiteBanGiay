<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UuDai.aspx.cs" Inherits="BTLW.UuDai" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin/>
    <link rel="stylesheet" href="./css/Uudai.css" />
    <link rel="stylesheet" href="./css/trangchu.css" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@500&display=swap" rel="stylesheet"/>
    <title>Shop giày HKT Sneaker</title>
</head>
<body>
      <div class="login" >       
        <table>
            <tr>
               <td class="td-login">
                    <div class="txtlogin" id="login" runat="server">     
                    <p class="user"></p>
                    <a href="DangNhap.aspx">Đăng Nhập</a>
                    </div>
               </td>
            </tr>
        </table>
      </div>

     <div class="header">  
        
        <ul class="menu">
            <li><a href="TrangChu.aspx">Trang chủ</a></li>
            <li><a href="GioiThieu.aspx">Giới thiệu</a></li>
            <li><a href="GioHang.aspx">Giỏ hàng</a></li>
            <li>
                <a href="#">Thể loại</a>
                <ul class="dropdown-theloai">
                    <li><a href="Giaythoitrang.aspx">Giày thời trang</a></li>
                    <li><a href="Giaythethao.aspx">Giày thể thao</a></li>
                    
                </ul>
            </li>
            <li style="background-color:cadetblue"><a href="UuDai.aspx">Ưu đãi</a></li>
            <li><a href="Lienhe.aspx">Liên hệ</a></li>
            
        </ul>
    </div>

    <form id="form1" runat="server">
         <div class="search-product">
            <input runat="server" name="txtsearch" id="txtsearch" type="text" placeholder="   Nhập tên sản phẩm cần tìm" />
            <button runat="server" type="button" onserverclick="btnSearch_Click" id="btnSearch" name="btnSearch" >Tìm kiếm</button>
        </div>
    </form>

        <h1 style="font-family:  Cochin, serif; text-align:center; width: 100%; background-color: aquamarine; line-height: 90px; text-transform: uppercase; text-decoration: none; ">
        Ưu đãi đặc biệt
    </h1>
    <div class="banner-uudai">
    
        <img id="banner1" src="./img/uudai1.png" alt=""/>
    
        <img id="banner2" src="./img/uudai2.jpg" alt=""/>
        <img id="banner3" src="./img/uudai3.png" alt=""/>
    
    </div>
    <div class="banner1">
        <img src="./img/uudai4.jpg" alt="" id="banner4" />
        <img src="./img/uudai5.jpg" alt="" id="banner5" />
    </div>
    <div class="footer">
        <div class="footer-name">
          <h2>Shop bán giày HKT Sneaker</h2>
          <p>Trang web được thiết kế bởi nhóm sinh viên năm 2.</p>
       </div>
       <div class="footer-add">
        <h2>Địa chỉ liên hệ</h2>
        <p>Công ty TNHH HKT</p>
        <p>Địa chỉ: 96A Định Công, Hoàng Mai, Hà Nội.</p>
        <p>Email: hktgroup@gmail.com.</p>
        <p>Điện thoại: 06771508</p>
     </div>
     <div class="footer-last">
        <h2>Điều khoản</h2>
        <p>Bảo mật</p>
        <p>Khuyến mãi</p>
        <p>Chính sách</p>
        <p>Thông tin người dùng</p>
     </div> 
    </div>
</body>
</html>

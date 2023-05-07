<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="BTLW.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <%--<meta http-equiv="refresh" content="number" />--%>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link rel="stylesheet" href="./css/dangnhap.css">
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@500&display=swap" rel="stylesheet"/>
    <title>Shop giày HKT Sneaker</title>
    
</head>
<body >
    <div class="login">
            <div class="btnlogin">
                
            </div>
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
            <li><a href="UuDai.aspx">Ưu đãi</a></li>
            <li><a href="Lienhe.aspx">Liên hệ</a></li>
            
        </ul>
    </div>

    <div class="content">
        <div id="login-form" class="auth" >
                <form action="DangNhap.aspx" method="post" runat="server">
                <div class="auth__header">
                    <h2>Đăng nhập</h2>
                    <a href="Dangky.aspx">Đăng ký</a>
                </div>
                <div class="auth__form">
                    <div class="form-control">
                        <label for="username">Tên đăng nhập</label>
                        <input type="text" id="usernameL" placeholder="Nhập tên đăng nhập" name="usernameL" />
                    </div>
                    <div class="form-control">
                        <label for="password">Mật khẩu</label>
                        <input type="password" id="passwordL" placeholder="Nhập mật khẩu" name="passwordL" />
                    </div>
                    <p runat="server" id="errorL" style=" color:red"></p>
                    <button class="auth_btn" id="btnLogin" runat="server">Đăng nhập</button>
                </div>
                </form>
            </div>
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
    <script src="./js/dangnhap.js" >
       
    </script>
</body>
</html>


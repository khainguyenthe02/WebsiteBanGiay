<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="BTLW.DangKy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin/>
    <link rel="stylesheet" href="./css/dangky.css">
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@500&display=swap" rel="stylesheet"/>
    <title>Shop giày HKT Sneaker</title>
</head>
<body>
     <div class="login">
            <div class="btnlogin">
                <p class="user"></p>
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
        <div id="reg-form" class="auth">
            <form action="DangKy.aspx" method="post" runat="server">
                <div class="auth__header">
                    <h2>Đăng ký</h2>
    

                    <a href="Dangnhap.aspx">Đăng nhập</a>
                </div>
                <div class="auth__form">
                    <div class="form-control">
                        <label for="username">Tên đăng nhập</label>
                        <input type="text" id="username" placeholder="Nhập tên đăng nhập" name="username"/>
                        <p runat="server" id="username_error" style="color:red"></p>
                    </div>
                    <div class="form-control">
                        <label for="email">Email</label>
                        <input type="text" id="email" placeholder="nguyenvana@gmail.com" name="email"/>
                        <p style="color:red"></p>
                    </div>
                    <div class="form-control">
                        <label for="password">Mật khẩu</label>
                        <input type="password" id="password" placeholder="Nhập mật khẩu" name="password"/>
                        <p style="color:red"></p>
                    </div>
                    <div class="form-control">
                        <label for="re-password">Xác nhận mật khẩu</label>
                        <input type="password" id="re-password" placeholder="Nhập lại mật khẩu" name="re-password"/>
                        <p style="color:red"></p>
                    </div>
                    <p runat="server" id="btn_error" style="color:red"></p>
                    <button class="auth_btn" id="btnReg">Đăng ký</button>
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
   <script src="./js/dangky.js"></script>
</body>
</html>

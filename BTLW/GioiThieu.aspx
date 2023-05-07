<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GioiThieu.aspx.cs" Inherits="BTLW.GioiThieu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="UTF-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin/>
    <link rel="stylesheet" href="./css/trangchu.css" />

    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@500&display=swap" rel="stylesheet"/>
    <title>Shop giày HKT Sneaker</title>
    <style type="text/css">
        .user {
            height: 20px;
            color: white;
            text-decoration: inherit;
            font-weight: bold;
            width: 100%;
        }
        .td-login {
            width: 300px;
        }
        
    </style>
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
            <li ><a href="TrangChu.aspx">Trang chủ</a></li>
            <li style="background-color:cadetblue"><a href="GioiThieu.aspx">Giới thiệu</a></li>
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
   
    <form id="form1" runat="server">
         <div class="search-product">
        <input runat="server" name="txtsearch" id="txtsearch" type="text" placeholder="   Nhập tên sản phẩm cần tìm" />
        <button runat="server" type="button" onserverclick="btnSearch_Click" id="btnSearch" name="btnSearch" >Tìm kiếm</button>
    </div>
    </form>

    <div class="intro" style="margin: 10px 7%;">
        <h2>GIỚI THIỆU HKT Sneaker</h2>
        <p><b>Công ty Cổ Phần Giày HKT </b>được thành lập vào năm 2003. Với sứ mệnh đem đến cho những tín đồ thời trang Việt Nam những sản phẩm thời trang cao cấp chính hãng, độc đáo, cập nhật cũng như bắt kịp với xu hướng và trào lưu thế giới.</p>
        <p>Ngoài chất liệu và kiểu dáng chúng tôi đặc biệt chú trọng đến công nghệ của sản phẩm. Vì sự thoải mái, tiện dụng, tốt cho sức khỏe của khách hàng là mối quan tâm hàng đầu của chúng tôi.</p><br />
        <h3>THÔNG TIN ĐĂNG KÝ DOANH NGHIỆP</h3>
        <p><b>Tên công ty:</b> Công Ty Cổ Phần Giày HKT</p>
        <p><b>Người đại diện:</b> Khum có</p>
        <p><b>Mã số doanh nghiệp:</b> 06771508</p>
        <p><b>Ngày cấp:</b> 11/11/2222</p>
        <p><b>Nơi cấp:</b> Sao Hỏa</p>
        <p><b>Địa chỉ:</b> Mặt Trời</p><br />
        <h3>GIỚI THIỆU HKT Sneaker</h3>
        <p>Kể từ năm 2003, HKT đã giới thiệu đến thị trường Việt Nam nhiều thương hiệu uy tín và nổi tiếng trên thế giới như Furla, Geox, cùng nhiều thương hiệu giúp ích cho sức khỏe như giày HBB (Healthy Back Bag), giày Vionic, Native,...</p>
        <p>Với mong muốn mang những sản phẩm uy tín của thế giới đến khách hàng Việt Nam, HKT giới thiệu thêm hệ thống outlet mang tên <b>HKT</b> từ năm 2019. <b>HKT</b> đã và đang là một địa chỉ mua sắm uy tín và quen thuộc tại Việt Nam.</p>
        <p>Trong tương lai, kênh mua sắm trực tuyến <b>HKT</b> sẽ tiếp tục giới thiệu thêm nhiều sự lựa chọn hấp dẫn với mức giá ưu đãi cùng nhiều dịch vụ hậu mãi, chăm sóc khách hàng chu đáo.</p>
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

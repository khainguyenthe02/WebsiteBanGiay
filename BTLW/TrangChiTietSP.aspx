<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChiTietSP.aspx.cs" Inherits="BTLW.TrangChiTietSP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin/>
    <link rel="stylesheet" href="./css/chitietsp.css">
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@500&display=swap" rel="stylesheet"/>
    <title>Chi tiết sản phẩm</title>
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
    
        <form id="form1" runat="server" >
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
            <li><a href="UuDai.aspx">Ưu đãi</a></li>
            <li><a href="Lienhe.aspx">Tin Tức</a></li>
            
        </ul>
    </div>

    
    <div class="search-product">
        <input runat="server" name="txtsearch" id="txtsearch" type="text" placeholder="   Nhập tên sản phẩm cần tìm" />
        <button runat="server" type="button" onserverclick="btnSearch_Click" id="btnSearch" name="btnSearch" >Tìm kiếm</button>
    </div>
    

    <div class="content">
        <div class="danhmuc">
            <h3 id="titlehead" style="margin-top: 20px; text-align: center; text-decoration: underline;">Danh mục sản phẩm</h3><br>
            <a href="Giaythoitrang.aspx">Giày thời trang</a> <br><br>
            <a href="Giaythethao.aspx">Giày thể thao</a>

        </div>
         
        <div class="chitiet">
           <%= HienProductInformation() %>

            <div class="clicksubmit">
                <p class="themgio" name="themgio" runat="server" id="themgio" style="color:red"></p>
                <button type="submit"   ID ="btnaddtocart" style="width: 40%; height: 40px; margin-top: 30px;" runat="server" onserverclick="AddToCart">Thêm vào giỏ hàng</button>
                
            </div>
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
    
    
        </form>
    <%--<script>
        let quantity = parseInt(document.getElementById("quantity").innerHTML);
        let tang = document.getElementById("tang");
        let giam = document.getElementById("giam");
        tang.onclick = function (e) {
            e.preventDefault();
            quantity++;
            document.getElementById("quantity").innerHTML = quantity;

            //sumPrice = quantity * price;
            //document.getElementById("products_price").innerHTML = sumPrice;

        }
        giam.onclick = function (e) {
            e.preventDefault();
            if (quantity <= 1) {
                alert("Số lượng nhỏ nhất bằng 1");
                quantity = 1;
                document.getElementById("quantity").innerHTML = 1;
            }
            quantity--;
            document.getElementById("quantity").innerHTML = quantity;

            //sumPrice = quantity * price;
            //document.getElementById("products_price").innerHTML = sumPrice;
        }
    </script>--%>
</body>
</html>

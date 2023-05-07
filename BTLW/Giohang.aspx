<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giohang.aspx.cs" Inherits="BTLW.Giohang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="UTF-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin/>
    <link rel="stylesheet" href="./css/chitietsp.css">
    <link rel="stylesheet" href="./css/giohang.css">
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@500&display=swap" rel="stylesheet"/>
    <title>Giỏ hàng</title>    
  
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
            <li><a href="TrangChu.aspx">Trang chủ</a></li>
            <li><a href="GioiThieu.aspx">Giới thiệu</a></li>
            <li style="background-color:cadetblue"><a href="Giohang.aspx">Giỏ hàng</a></li>
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
            <button id="btnSearch" name="btnSearch" runat="server" onserverclick="btnSearch_Click">Tìm kiếm</button>
         </div>
     </form>

   <div class="main">
        <div class="price-all">
			<div class="cart--right">
                 <h2 class="title">Đơn hàng<br></h2>
                    <p class="sogiohang" id="sogiohang" runat="server"></p>
                    <div class="tong-tien">
                        <span>Tổng tiền phải trả</span>
                        <span runat="server" id="products_price" style="font-weight: bold;"> 0</span>
                    </div><br />
                   <hr />
                    <div class="address-user">
                        <h3 style="margin: 10px 10px;">Thông tin cá nhân</h3>
                        <input id="txtTen" type="text" placeholder=" Nhập tên..." required /><br />
                        <input id="txtDiachi" type="text" placeholder=" Nhập địa chỉ..." required /><br />
                        <input id="txtSDT" type="text" placeholder=" Nhập số điện thoại..." required /><br />
                        <span style="margin-left:15%;">Thanh toán: </span>
                        <select id="select-bank">
                            <option value="bank">Ngân hàng</option>
                            <option value="vidientu">Ví điện tử</option>                            
                            <option value="">Khi nhận hàng</option>
                        </select>   
                    </div>
                    <div class="cart__button">
                        <button id="purchase-button" type="button">Đặt hàng</button>
                    </div>
                </div>
		</div>
		
		<div class="cart_product">
			<table class="bang" >
						<tr>
							<th>Ảnh</th>
							<th>Tên sản phẩm</th>
							<th>Giá</th>    
                            <th>Số lượng</th>
							<th>Tác vụ</th>
						</tr> 

                        <%= HienGioHang() %>

			</table>
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
    <%--<script >
        let quantity = parseInt(document.getElementById("quantity").innerHTML);
        let sumPrice = parseInt(document.getElementById("products_price").innerHTML);


        let price = parseInt(document.getElementById("price").innerHTML);
        let tang = document.getElementById("tang");
        let giam = document.getElementById("giam");

        console.log(quantity); console.log(price); console.log(sumPrice);
        tang.onclick = function () {
            quantity++;
            document.getElementById("quantity").innerHTML = quantity;

            sumPrice = quantity * price;
            document.getElementById("products_price").innerHTML = sumPrice;

        }
        giam.onclick = function () {
            if (quantity <= 1) {
                alert("Số lượng nhỏ nhất bằng 1");
                quantity = 1;
                document.getElementById("quantity").innerHTML = 1;
            }
            quantity--;
            document.getElementById("quantity").innerHTML = quantity;

            sumPrice = quantity * price;
            document.getElementById("products_price").innerHTML = sumPrice;
        }
    </script>--%>
    <script src="./js/giohang.js" type="text/javascript" >
       

    </script>
</body>
</html>

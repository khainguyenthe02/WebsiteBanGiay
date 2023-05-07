<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThemGiay.aspx.cs" Inherits="BTLW.ThemGiay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
     <div class="login">
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
    <form id="form1" runat="server"  method="post" enctype="multipart/form-data">
        <span>Nhập mã giày:</span>
        <input type="text" id="txtID" runat="server" /> <br />

        <span>Nhập tên giày:</span>
        <input type="text" id="txtName" runat="server" /> <br />

        <span>Nhập giá tiền:</span>
        <input type="number" id="txtPrice" runat="server"  /> <br />

        <span>Nhập số lượng:</span>
        <input type="number" id="txtQuan" runat="server" /> <br />

        <span>Tải ảnh lên</span>
        <input type="file" id="txtFile" runat="server" /> <br />

        <span>Nhập loại:</span>
        <input type="text" id="txtLoai" runat="server" /> <br />

        <span>Nhập mô tả:</span>
        <input type="text" id="txtMoTa" runat="server" /> <br />
        <br />
        <button runat="server" type="submit" onserverclick="btnThem" value="Submit">Thêm</button>
    </form>
</body>
</html>

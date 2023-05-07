let txtTen = document.getElementById("txtTen");
let txtDiachi = document.getElementById("txtDiachi");
let txtSDT = document.getElementById("txtSDT");
let btnDH = document.getElementById("purchase-button");
let user = document.getElementsByClassName("user");
let select = document.getElementById("select-bank");


btnDH.onclick = function () {

    if (txtDiachi.value.trim().length == 0 || txtSDT.value.trim().length == 0 || txtTen.value.trim().length == 0) {
        alert('Bạn chưa điền đầy đủ thông tin');
    }
    if (!/[a-z]/.test(txtSDT) || !/[A-Z]/.test(txtSDT)) {
        alert('Bạn chưa điền đầy đủ thông tin');
    }
    else {
        alert('Đặt hàng thành công' + "\n" +
            "Khách hàng: " + txtTen.value + "\n" +
            "Địa chỉ: " + txtDiachi.value + "\n" +
            "SĐT: " + txtSDT.value + "\n" +
            "Đã thanh toán qua : " + select.options[select.selectedIndex].text);

    }
    txtDiachi.value = txtSDT.value = txtTen.value = "";
}


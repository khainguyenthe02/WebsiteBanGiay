var saimk = 0;
btnLogin.onclick = function (e) {
     
    var valid = true;
    if (!(usernameL.value.trim() && passwordL.value.trim())) {
        valid = false;
    }
    if (!valid) {
        saimk++;
        e.preventDefault();
        btn_error = document.getElementById("errorL");
        btn_error.innerHTML = "Điền đầy đủ tài khoản và mật khẩu";       
    }
    if (saimk == 3) {
        alert("Bạn đã nhập sai 3 lần");
    }
    console.log(saimk);
}
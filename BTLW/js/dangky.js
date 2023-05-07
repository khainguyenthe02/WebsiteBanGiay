let form = document.querySelector('.auth__form');
let username = document.getElementById('username');
let email = document.getElementById('email');
let password = document.getElementById('password');
let repassword = document.getElementById('re-password');
let inputs = form.querySelectorAll('.input');
let btnReg = document.getElementById("btnReg");

// CHECK TRƯỜNG BỎ TRỐNG
for (var i = 0; i < inputs.length; i++) {
    inputs[i].onblur = inputs[i].oninput = new function () {
        if (inputs[i].value.trim() == 0) {
            setSuccessFor(inputs[i]);
        } else {
            setErrorFor(inputs[i], 'Trường này không được bỏ trống');
        }
    }
}
//  XỬ LÝ XẢY RA LỖI
function setErrorFor(input, message) {
    const formControl = input.parentElement;
    const p = formControl.querySelector('p');
    p.innerText = message;
    formControl.className = 'form-control invalid';
    input.focus();
}
//  XỬ LÝ THÀNH CÔNG
function setSuccessFor(input) {
    const formControl = input.parentElement;
    const p = formControl.querySelector('p');
    p.innerText = '';
    formControl.className = 'form-control valid';
}
// CHECK TRÙNG MẬT KHẨU 
repassword.onblur = repassword.oninput = function () {
    if (repassword.value.trim() === password.value.trim()) {
        setSuccessFor(repassword);
    } else {

        setErrorFor(repassword, 'Mật khẩu chưa trùng khớp');
    }
}
//   CLICK BUTTON ĐĂNG KÝ
btnReg.onclick = function (e) {
    var valid = true;
    if (!(username.value.trim() || email.value.trim() || password.value.trim() || repassword.value.trim())) {
        alert("Hãy điền đầy đủ các trường");
        valid = false;
    }
    if (!username.value.trim()) {
        setErrorFor(username, 'Vui lòng nhập tài khoản');
        valid = false;
        console.log(valid);
    }
    else {
        setSuccessFor(username);
    }
    if (!email.value.trim()) {
        setErrorFor(email, 'Vui lòng nhập email');
        valid = false;
        console.log(valid);
    } else {
        setSuccessFor(email);
    }
    if (!password.value.trim()) {
        setErrorFor(password, 'Vui lòng nhập mật khẩu');
        valid = false;
        console.log(valid);
    } else {
        setSuccessFor(password);
    }
    if (!repassword.value.trim()) {
        setErrorFor(repassword, 'Vui lòng nhập lại mật khẩu');
        valid = false;
        console.log(valid);
    }
    else {
        setSuccessFor(repassword);
    }
    if (!valid) {
        e.preventDefault();
    }
}
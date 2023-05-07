//Banner
var i = 0;
function chuyenhinh() {
    var hinh = ["img/banner1.png", "img/banner2.png", "img/banner3.png"];
    document.getElementById('banner').src = hinh[i];
    i++;
    if (i > 2) {
        i = 0;
    }
    setTimeout(chuyenhinh, 2 * 1000);
}
chuyenhinh()

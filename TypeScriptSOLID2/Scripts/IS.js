var Robot = (function () {
    function Robot() {
    }
    Robot.prototype.Calis = function () { alert("Robot Çalışıyor"); };
    Robot.prototype.Dur = function () { alert("Robot Duruyor"); };
    return Robot;
})();
var Isci = (function () {
    function Isci() {
    }
    Isci.prototype.Calis = function () { alert("İşçi Çalışıyor"); };
    Isci.prototype.Dur = function () { alert("İşçi Duruyor"); };
    Isci.prototype.YemekYe = function () { alert("İşçi YemekYe yiyor"); };
    return Isci;
})();
var rbt = new Robot();
var isc = new Isci();
rbt.Calis();
rbt.Dur();
isc.Calis();
isc.Dur();
isc.YemekYe();

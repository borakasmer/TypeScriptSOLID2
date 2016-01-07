interface IRobot {
    Calis();
    Dur();
}

interface ICalisan extends IRobot
{
    YemekYe();
}

class Robot implements IRobot
{
    Calis() { alert("Robot Çalışıyor"); }
    Dur() { alert("Robot Duruyor"); }       
}

class Isci implements ICalisan
{
        public Calis() { alert("İşçi Çalışıyor"); }
        public Dur() { alert("İşçi Duruyor"); }
        public YemekYe() { alert("İşçi YemekYe yiyor"); }
}

var rbt = new Robot();
var isc = new Isci();
rbt.Calis();
rbt.Dur();
isc.Calis();
isc.Dur();
isc.YemekYe();
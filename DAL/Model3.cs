using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICalisan
    {
        void Calis();
        void Dur();
        void YemekYe();
    }
    public class Robot : ICalisan
    {
        public void Calis() { Console.Write("Robot Çalışıyor"); }
        public void Dur() { Console.Write("Robot Duruyor"); }
        public void YemekYe() { Console.Write("Robot YemekYe yiyor"); }
    }
    public class Isci : ICalisan
    {
        public void Calis() { Console.Write("İşçi Çalışıyor"); }
        public void Dur() { Console.Write("İşçi Duruyor"); }
        public void YemekYe() { Console.Write("İşçi YemekYe yiyor"); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL2
{
    public interface IRobot
    {
        void Calis();
        void Dur();
    }
    
    public interface ICalisan:IRobot
    {        
        void YemekYe();
    }
    public class Robot : IRobot
    {
        public void Calis() { Console.Write("Robot Çalışıyor"); }
        public void Dur() { Console.Write("Robot Duruyor"); }        
    }
    public class Isci : ICalisan
    {
        public void Calis() { Console.Write("İşçi Çalışıyor"); }
        public void Dur() { Console.Write("İşçi Duruyor"); }
        public void YemekYe() { Console.Write("İşçi YemekYe yiyor"); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL3
{
    public interface IAdvertisment
    {
        void Show();
    }
    public class Banner: IAdvertisment
    {
        public void Show() { }
    }
    public class Video: IAdvertisment
    {
        public void Show() { }
    }

    public class Advertisment
    {
        IAdvertisment _advertisment;
        public Advertisment(IAdvertisment advertisment)
        {
            _advertisment = advertisment;
        }
        public void Show()
        {
            _advertisment.Show();
        }
    }
}

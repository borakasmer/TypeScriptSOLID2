using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManageAdvertisement
    {
        Banner bnr;
        Video vid;
        public ManageAdvertisement()
        {
            bnr = new Banner();
            vid = new Video();
        }
        public void Show() {            
            bnr.ShowBanner();
            vid.ShowVideo();
        }        
    }

    public class Banner
    {
        public void ShowBanner() { }
    }
    public class Video
    {
        public void ShowVideo() { }
    }
}

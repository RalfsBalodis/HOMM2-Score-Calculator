using System;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HOMM_2_Score_Calculator
{
    class ImageProcesor
    {
        internal static ImageSource GetImage(string imagename)
        {
            return new BitmapImage(new Uri(Directory.GetCurrentDirectory() + $@"\Images\{imagename}.bmp"));
        }
    }
}

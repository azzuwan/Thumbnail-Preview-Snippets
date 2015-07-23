using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace ThumbnailGeneratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            ShellFile shellFile = ShellFile.FromFilePath(args[0]);
            Bitmap shellThumb = shellFile.Thumbnail.ExtraLargeBitmap;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            shellThumb.Save(path + @"\Test", ImageFormat.Png);

        }
    }
}

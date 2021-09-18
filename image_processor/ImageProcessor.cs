using System;
using System.IO;
using System.Threading;
using System.Drawing;

class ImageProcessor{
    public static void Inverse(string[] filenames) {
        for(int i = 0; i < filenames.Length; i++) {
            Thread t = new Thread(new ParameterizedThreadStart(ImageThread));
            t.Start(filenames[i]);
        }
    }

    public static void ImageThread(object fn) {
        string filename = (string) fn;
        Bitmap bmp;
            bmp = new Bitmap(filename);
            string[] file = filename.Split(".");
            string[] location = file[0].Split("/");
            Bitmap newbmp = (Bitmap)bmp.Clone();
            Color col;
            for (int k = 0; k < newbmp.Width; k++)  
            {  
                for (int j = 0; j < newbmp.Height; j++)  
                {  
                    col = newbmp.GetPixel(k, j);  
                    newbmp.SetPixel(k, j,  
      Color.FromArgb(255 - col.R, 255 - col.G, 255 - col.B));  
                }  
            }  
            newbmp.Save(location[1]+ ".inversed." + file[1]);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] filenames;

        if (args.Length > 1)
            filenames = args;
        else
            filenames = Directory.GetFiles("images/", "*.jpg");

        ImageProcessor.Inverse(filenames);
    }
}
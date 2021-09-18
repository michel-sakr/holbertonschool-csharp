using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;



class ImageProcessor{
    /// <summary>
    /// Function that creates a new thread for every image to be processed.
    /// </summary>
    /// <param name="filenames">String with all file names</param>
    public static void Inverse(string[] filenames) {
        Parallel.ForEach(filenames, (file) => {
            var filename = Path.GetFileNameWithoutExtension(file);
            var extention = Path.GetExtension(file);
            filename = filename + "_inverse" + extention;

            Bitmap bmp;
            bmp = new Bitmap(file);
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
            newbmp.Save(filename);            
        });
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
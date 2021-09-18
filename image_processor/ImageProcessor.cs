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
    // public static void Inverse(string[] filenames) {
    //     Parallel.ForEach(filenames, (file) => {
    //         var filename = Path.GetFileNameWithoutExtension(file);
    //         var extention = Path.GetExtension(file);
    //         filename = filename + "_inverse" + extention;

    //         Bitmap bmp;
    //         bmp = new Bitmap(file);
    //         Bitmap newbmp = (Bitmap)bmp.Clone();
    //         Color col;
    //         for (int k = 0; k < newbmp.Width; k++)  
    //         {  
    //             for (int j = 0; j < newbmp.Height; j++)  
    //             {  
    //                 col = newbmp.GetPixel(k, j);  
    //                 newbmp.SetPixel(k, j,  
    //                 Color.FromArgb(255 - col.R, 255 - col.G, 255 - col.B));  
    //             }  
    //         }  
    //         newbmp.Save(filename);            
    //     });
    // }
     public static void Inverse(string[] filenames)
    {

        Parallel.ForEach(filenames, (myFile) =>
        {
            var ext = Path.GetExtension(myFile);
            var fName = Path.GetFileNameWithoutExtension(myFile);
            fName += "_inverse" + ext;

            Bitmap bmp = new Bitmap(myFile);

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length; i++)
                rgbValues[i] = (byte)(255 - rgbValues[i]);

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            bmp.UnlockBits(bmpData);

            bmp.Save($"{fName}");
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
using System;
using System.Windows.Media.Imaging;

namespace Amos.Core
{
    public class Class1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private static BitmapImage BytesToBitmap(byte[] bytes)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.StreamSource = new System.IO.MemoryStream(bytes);
            bitmap.EndInit();
            return bitmap;
        }
    }
}

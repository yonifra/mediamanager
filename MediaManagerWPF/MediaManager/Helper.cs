using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Media.Imaging;
using System.IO;

namespace MediaManager
{
    static public class Helper
    {
        public static BitmapImage GetImageFromUri(Uri uri)
        {
            var image = new BitmapImage();
            int bytesToRead = 100;

            try
            {
                WebRequest request = WebRequest.Create(uri);
                request.Timeout = -1;
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                BinaryReader reader = new BinaryReader(responseStream);
                MemoryStream memoryStream = new MemoryStream();

                byte[] bytebuffer = new byte[bytesToRead];
                int bytesRead = reader.Read(bytebuffer, 0, bytesToRead);

                while (bytesRead > 0)
                {
                    memoryStream.Write(bytebuffer, 0, bytesRead);
                    bytesRead = reader.Read(bytebuffer, 0, bytesToRead);
                }

                image.BeginInit();
                memoryStream.Seek(0, SeekOrigin.Begin);

                image.StreamSource = memoryStream;
                image.EndInit();

                return image;
            }
            catch
            {
                return new BitmapImage();
            }
        }
    }
}

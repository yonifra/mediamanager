using System;
using System.Net;
using System.Windows.Media.Imaging;
using System.IO;
using System.Threading.Tasks;

namespace MediaManager
{
    static public class Helper
    {
        public static async Task<BitmapImage> GetImageFromUri(Uri uri)
        {
            var image = new BitmapImage();
            const int bytesToRead = 100;

            try
            {
                var request = WebRequest.Create(uri);
                request.Timeout = -1;
                
                var response = await GetWebResponse(request);
                var responseStream = response.GetResponseStream();
                var reader = new BinaryReader(responseStream);
                var memoryStream = new MemoryStream();

                var bytebuffer = new byte[bytesToRead];
                var bytesRead = reader.Read(bytebuffer, 0, bytesToRead);

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

        private static async Task<WebResponse> GetWebResponse(WebRequest request)
        {
            return await Task.Run(() => request.GetResponse());
        }
    }
}

using Proxy;
using ProxyDesignPatternSample;

namespace Proxy
{
    //using Proxy
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileDownloader fileDownloader = new FileDownloaderProxy();
            //اولین دانلود:اجرای کامل عملیات
            fileDownloader.DownloadFile("https://example.com/file1.txt");
            //دومین دانلود:استفاده از کش
            fileDownloader.DownloadFile("https://example.com/file1.txt");
            //دانلود فابل دیگر :اجرای عملیات جدید
            fileDownloader.DownloadFile("https://example.com/file2.txt");
        }
    }
}
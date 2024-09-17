using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    //واسط Subject
    public interface IFileDownloader
    {
        void DownloadFile(string url);
    }
}
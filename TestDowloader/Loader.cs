using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TestDowloader
{
    class Loader
    {

        public void Loaded(string uri, Label l, ProgressBar p, string name)
        {
            using (WebClient wc = new WebClient())
            {
                wc.OpenRead(uri);
                string size = (Convert.ToDouble(wc.ResponseHeaders["Content-Length"]) / 1048576).ToString("#.#");

                wc.DownloadProgressChanged += (s, a) =>
                {
                    l.Content = $"Размер файла: {size} \n Загружено {a.ProgressPercentage}%({((double)a.BytesReceived / 1048576).ToString("#.#")} Mb)";
                    p.Value = a.ProgressPercentage;
                };
                wc.DownloadFileAsync(new Uri(uri), $@"C:\Users\vaseok\Desktop\{name}.exe");
            }
        }
    }
}

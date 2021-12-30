using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.IO;

namespace QuackCrypt_DOTNET.Core
{
    class Uploader
    {
        public static string Upload(byte[] data, string filename)
        {
            var webClient = new WebClient();
            string boundary = "------------------------" + DateTime.Now.Ticks.ToString("x");
            webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + boundary);
            var fileData = webClient.Encoding.GetString(data);
            var package = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"files[]\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", boundary, filename, "text/plain", fileData);

            var nfile = webClient.Encoding.GetBytes(package);

            //Get response parsed
            byte[] resp = webClient.UploadData("https://uguu.se/upload.php", "POST", nfile);
            string sRes = Encoding.Default.GetString(resp);
            var parsed = (JObject.Parse(sRes)["files"]);
            var dest = "" + parsed.ToString();
            foreach (JToken token in parsed)
            {
                dest = (string)token["url"];
            }
            return dest;
        }

    }
}


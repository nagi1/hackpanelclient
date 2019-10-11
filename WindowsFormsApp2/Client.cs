using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace Tools
{
    public class Client
    {

        public static bool GetProcessesByName(string pName, out Process process)
        {
            Process[] pList = Process.GetProcessesByName(pName);
            process = pList.Length > 0 ? pList[0] : null;
            return process != null;
        }
        public static string getver()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            return version;
        }
        public static string getnewver(string ver)
        {
            WebClient _webClient = new WebClient();
            return _webClient.DownloadString(new Uri(ver));
        }
        public static string gethash(string ver)
        {
            WebClient _webClient = new WebClient();
            return _webClient.DownloadString(new Uri(ver));
        }
        public static string CalculateMD5(string path) 
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
        private static string GetHexString(byte[] bt)
        {
            string s = string.Empty;
            for (int i = 0; i < bt.Length; i++)
            {
                byte b = bt[i];
                int n, n1, n2;
                n = (int)b;
                n1 = n & 15;
                n2 = (n >> 4) & 15;
                if (n2 > 9)
                    s += ((char)(n2 - 10 + (int)'A')).ToString();
                else
                    s += n2.ToString();
                if (n1 > 9)
                    s += ((char)(n1 - 10 + (int)'A')).ToString();
                else
                    s += n1.ToString();
                if ((i + 1) != bt.Length && (i + 1) % 2 == 0) s += "-";
            }
            return s;
        }
        private static string GetHash(string s)
        {
            MD5 sec = new MD5CryptoServiceProvider();
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] bt = enc.GetBytes(s);
            return GetHexString(sec.ComputeHash(bt));
        }
        public static string prod()
        {       
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            return GetHash(CalculateMD5(assembly.Location));
            
        }
    }
}

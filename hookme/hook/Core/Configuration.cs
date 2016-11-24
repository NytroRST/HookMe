using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace hook.Core
{
    class Configuration
    {
        private string _key = @"SOFTWARE\hooker";

        public string urlSponsor = "http://www.itsm3.com/hookme/sponsor/sponsor.html";

        /* Hooks a las apis */
        public bool recv;
        public bool recvfrom;
        public bool send;
        public bool sendto;
        public bool wsasend;
        public bool wsarecv;
        public bool encryptmessage;
        public bool decryptmessage;

        public string deviareLicenseBase64 = string.Empty;
        public List<string> lstPluginsSearchPath = new List<string>();

        public void SaveConfiguration()
        {
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(_key);

            // licencia
            rk.SetValue("deviareLicensePath", deviareLicenseBase64);

            // plugins
            string fullPluginSearchPath = string.Empty;
            foreach (string path in lstPluginsSearchPath)
            {
                if (!string.IsNullOrEmpty(path))
                    fullPluginSearchPath += path + ";";
            }
            rk.SetValue("lstPluginsSearchPath", fullPluginSearchPath);

            // hooks
            rk.SetValue("recv",             recv);
            rk.SetValue("recvfrom",         recvfrom);
            rk.SetValue("send",             send);
            rk.SetValue("sendto",           sendto);
            rk.SetValue("wsasend",          wsasend);
            rk.SetValue("wsarecv",          wsarecv);
            rk.SetValue("encryptmessage",   encryptmessage);
            rk.SetValue("decryptmessage",   decryptmessage);


        }

        public void LoadConfiguration()
        {
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(_key);

            // licencia
            if (string.IsNullOrEmpty(deviareLicenseBase64))
                deviareLicenseBase64 = (string)rk.GetValue("deviareLicensePath", string.Empty);

            // plugins
            string fullPluginSearchPath = (string)rk.GetValue("lstPluginsSearchPath", @"C:\Python26\Lib;C:\Python27\Lib;");
            for (int i = 0 ; i < fullPluginSearchPath.Split(new char[] { ';' }).Length; i++)
            {
                string path = fullPluginSearchPath.Split(new char[] { ';' })[i];

                if (!string.IsNullOrEmpty(path))
                    lstPluginsSearchPath.Add(path);
            }

            // hooks
            recv = bool.Parse((string)rk.GetValue("recv", "true"));
            recvfrom = bool.Parse((string)rk.GetValue("recvfrom", "true"));
            send = bool.Parse((string)rk.GetValue("send", "true"));
            sendto = bool.Parse((string)rk.GetValue("sendto", "true"));
            wsasend = bool.Parse((string)rk.GetValue("wsasend", "true"));
            wsarecv = bool.Parse((string)rk.GetValue("wsarecv", "true"));
            encryptmessage = bool.Parse((string)rk.GetValue("encryptmessage", "true"));
            decryptmessage = bool.Parse((string)rk.GetValue("decryptmessage","true"));
        }

    }
}

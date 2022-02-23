using System.Configuration;
using System.IO.Ports;
using System.Management;
using System.Text.RegularExpressions;

namespace DDE2S
{
    public class Settings
    {
        public Dictionary<string, string> sp = new Dictionary<string, string>();

        public void GetSerialPort()
        {
            ManagementClass device = new ManagementClass("Win32_PnPEntity");
            string[] PortList = SerialPort.GetPortNames();
            var reg1 = new Regex("COM[1-9][0-9]?[0-9]?");
            var reg2 = new Regex(".*(COM[1-9][0-9]?[0-9]?).*");

            foreach (string Port in PortList)
            {
                sp.Add(Port, "");
            }
            foreach (ManagementObject port in device.GetInstances())
            {
                var nameValue = (string)port.GetPropertyValue("Name");
                if (nameValue == null)
                {
                    continue;
                }
                else
                {
                    String name = nameValue.ToString();
                    if (reg1.IsMatch(name))
                    {
                        String pname = reg2.Replace(name, "$1");
                        sp[pname] = name;
                    }
                }
            }

            var nullCom = new List<string>();
            foreach (var (key, value) in sp)
            {
                if (value == "")
                {
                    nullCom.Add(key);
                }
            }

            foreach (var key in nullCom)
            {
                String nvalue = String.Format("Virtual Serial Port ({0})", key);
                sp[key] = nvalue;
            }
        }

        Configuration AppConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        
        public void UpdateCnnf(String key, String value)
        {
            AppConf.AppSettings.Settings[key].Value = value;
            AppConf.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
        public String GetString(String key) => ConfigurationManager.AppSettings[key];
        public int GetInt(string key) => int.Parse(GetString(key));
    }
}


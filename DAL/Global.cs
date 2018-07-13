using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace DAL
{
    public class Global
    {
        public string ReadReg(string KeyName, string DefaultValue)
        {
            RegistryKey regKey1 = Registry.CurrentUser;
            regKey1 = regKey1.CreateSubKey("BitCalls");

            try
            {
                return (string)regKey1.GetValue(KeyName, DefaultValue);
            }
            catch (Exception e)
            {
                return DefaultValue;
            }
        }
    }
}

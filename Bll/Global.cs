using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bll
{
    public class Global
    {
        public string ReadReg(string KeyName, string DefaultValue)
        {
            return new DAL.Global().ReadReg(KeyName, DefaultValue);
        }
    }
}

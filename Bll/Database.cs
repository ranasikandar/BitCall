using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bll
{
    public class Database
    {
        public string ReadReg(string KeyName, string DefaultValue)
        {
            return new DAL.Database().ReadReg(KeyName, DefaultValue);
        }
    }
}

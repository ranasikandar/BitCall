using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Bll
{
    public class CallRecords
    {
        public DataTable GetGrideData(string where)
        {
            try
            {
                return new DAL.CallRecords().GetGrideData(where);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void InsertCallRecords(Obj.CallRecords obj)
        {
            try
            {
                new DAL.CallRecords().InsertCallRecords(obj);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void UpdateCallRecords(Obj.CallRecords obj)
        {
            try
            {
                new DAL.CallRecords().UpdateCallRecords(obj);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public DataTable GetPersons(string where)
        {
            try
            {
                return new DAL.CallRecords().GetPersons(where);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(string vWhere)
        {
            try
            {
                new DAL.CallRecords().Delete(vWhere);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}

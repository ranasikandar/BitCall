using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Bll
{
    public class AddressBook
    {
        public DataTable GetAllCatagories(string where)
        {
            try
            {
                string strQuery = "select CategoryID, CategoryName from Category where 1=1 "+where+"";
                return new DAL.AddressBook().GetAllCatagories(strQuery);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void InsertContacts(Obj.AddressBook obj)
        {
            try
            {
                new DAL.AddressBook().InsertContacts(obj);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void UpdateContacts(Obj.AddressBook obj)
        {
            try
            {
                new DAL.AddressBook().UpdateContacts(obj);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public DataTable GetGrideData(string where)
        {
            try
            {
                return new DAL.AddressBook().GetGrideData(where);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public DataTable GetGridSearch(string where)
        {
            try
            {
                return new DAL.AddressBook().GetGridSearch(where);
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
                new DAL.AddressBook().Delete(vWhere);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public DataTable GetCity(string where)
        {
            try
            {
                return new DAL.AddressBook().GetCity(where);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetCompany(string where)
        {
            try
            {
                return new DAL.AddressBook().GetCompany(where);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}

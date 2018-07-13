using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.Specialized;
using System.Data.SqlClient;

namespace DAL
{
    public class AddressBook
    {
        ListDictionary parameters = new ListDictionary();

        public DataTable GetAllCatagories(string strQuery)
        {
            try
            {
                return new Database().ExecuteForDataTable(strQuery);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void InsertContacts(Obj.AddressBook obj)
        {
            try
            {
                parameters.Add(new SqlParameter("@CategoryID", SqlDbType.TinyInt), obj.cboCatagoryId);
                parameters.Add(new SqlParameter("@PersonName", SqlDbType.VarChar,50), obj.txtPersonName);
                parameters.Add(new SqlParameter("@CompanyName", SqlDbType.VarChar, 50), obj.txtCompanyName);
                parameters.Add(new SqlParameter("@MobileNo1", SqlDbType.VarChar, 20), obj.txtMobileNo1);
                parameters.Add(new SqlParameter("@MobileNo2", SqlDbType.VarChar, 20), obj.txtMobileNo2);
                parameters.Add(new SqlParameter("@LandlineNo1", SqlDbType.VarChar, 20), obj.txtLandlineNo1);
                parameters.Add(new SqlParameter("@LandlineNo2", SqlDbType.VarChar, 20), obj.txtLandlineNo2);
                parameters.Add(new SqlParameter("@HomeAddress", SqlDbType.VarChar, 200), obj.txtHomeAddress);
                parameters.Add(new SqlParameter("@OfficeAddress", SqlDbType.VarChar, 200), obj.txtOfficeAddress);

                if (obj.City == "")
                {
                    parameters.Add(new SqlParameter("@City", SqlDbType.VarChar, 50), null);
                }
                else
                {
                    parameters.Add(new SqlParameter("@City", SqlDbType.VarChar, 50), obj.City);
                }
                

                new Database().ExecuteNonQueryOnly("Sp_Insert_Contact", parameters);
            }
            catch (Exception ex)
            {
                //Sp_Update_Contact   
                throw ex;
            }
        }

        public void UpdateContacts(Obj.AddressBook obj)
        {
            try
            {
                parameters.Add(new SqlParameter("@ContactID", SqlDbType.TinyInt), obj.txtContactId);
                parameters.Add(new SqlParameter("@CategoryID", SqlDbType.TinyInt), obj.cboCatagoryId);
                parameters.Add(new SqlParameter("@PersonName", SqlDbType.VarChar, 50), obj.txtPersonName);
                parameters.Add(new SqlParameter("@CompanyName", SqlDbType.VarChar, 50), obj.txtCompanyName);
                parameters.Add(new SqlParameter("@MobileNo1", SqlDbType.VarChar, 20), obj.txtMobileNo1);
                parameters.Add(new SqlParameter("@MobileNo2", SqlDbType.VarChar, 20), obj.txtMobileNo2);
                parameters.Add(new SqlParameter("@LandlineNo1", SqlDbType.VarChar, 20), obj.txtLandlineNo1);
                parameters.Add(new SqlParameter("@LandlineNo2", SqlDbType.VarChar, 20), obj.txtLandlineNo2);
                parameters.Add(new SqlParameter("@HomeAddress", SqlDbType.VarChar, 200), obj.txtHomeAddress);
                parameters.Add(new SqlParameter("@OfficeAddress", SqlDbType.VarChar, 200), obj.txtOfficeAddress);

                parameters.Add(new SqlParameter("@City", SqlDbType.VarChar, 50), obj.City);

                new Database().ExecuteNonQueryOnly("Sp_Update_Contact", parameters);
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
                string query = string.Format(@"select con.* ,cat.CategoryName from Contacts con
                                                inner join Category cat on con.CategoryID=cat.CategoryID
                                                WHERE 1 = 1 {0}", where);
                return new Database().ExecuteForDataTable(query);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public DataTable GetGridSearch(string where)
        {
            try
            {
                return new Database().ExecuteForDataTable(where);
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
                string query = string.Format(@"delete from Contacts where ContactID=  {0}", vWhere);
                new Database().ExecuteScalerOnly(query);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public DataTable GetCity(string where)
        {
            try
            {
                string query = string.Format(@"select City from Contacts where 1=1 {0}", where);
                return new Database().ExecuteForDataTable(query);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public DataTable GetCompany(string where)
        {
            try
            {
                string query = string.Format(@"select CompanyName from Contacts where 1=1 {0}", where);
                return new Database().ExecuteForDataTable(query);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}

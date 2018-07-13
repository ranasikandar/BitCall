using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.Specialized;
using System.Data.SqlClient;

namespace DAL
{
    public class CallRecords
    {
        ListDictionary parameters = new ListDictionary();

        public DataTable GetGrideData(string where)
        {
            try
            {
                string query = string.Format(@"select car.* ,cat.CategoryName from CallRecords car 
                                                inner join Category cat on car.CategoryID=cat.CategoryID
                                                where 1=1 {0}", where);
                return new Database().ExecuteForDataTable(query);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void InsertCallRecords(Obj.CallRecords obj)
        {
            try
            {
                parameters.Add(new SqlParameter("@CallDateTime", SqlDbType.DateTime), obj.CallDateTime);
                parameters.Add(new SqlParameter("@ContactID", SqlDbType.Int), obj.ContactID);
                parameters.Add(new SqlParameter("@CallingPerson", SqlDbType.VarChar, 50), obj.CallingPerson);
                parameters.Add(new SqlParameter("@CompanyName", SqlDbType.VarChar, 50), obj.CompanyName);

                parameters.Add(new SqlParameter("@CallingNo", SqlDbType.VarChar, 20), obj.CallingNo);
                parameters.Add(new SqlParameter("@CategoryID", SqlDbType.TinyInt), obj.CategoryID);
                parameters.Add(new SqlParameter("@CallDetail", SqlDbType.VarChar, 200), obj.CallDetail);
                parameters.Add(new SqlParameter("@IsOutgoing", SqlDbType.Bit), obj.IsOutgoing);

                if (obj.City == "")
                {
                    parameters.Add(new SqlParameter("@City", SqlDbType.VarChar, 50), null);
                }
                else
                {
                    parameters.Add(new SqlParameter("@City", SqlDbType.VarChar, 50), obj.City);
                }

                parameters.Add(new SqlParameter("@CallStatus", SqlDbType.VarChar, 20), obj.CallStaus);

                new Database().ExecuteNonQueryOnly("Sp_Insert_CallRecords", parameters);
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
                parameters.Add(new SqlParameter("@CallID", SqlDbType.BigInt), obj.CallID);

                parameters.Add(new SqlParameter("@CallDateTime", SqlDbType.DateTime), obj.CallDateTime);
                parameters.Add(new SqlParameter("@ContactID", SqlDbType.Int), obj.ContactID);
                parameters.Add(new SqlParameter("@CallingPerson", SqlDbType.VarChar, 50), obj.CallingPerson);
                parameters.Add(new SqlParameter("@CompanyName", SqlDbType.VarChar, 50), obj.CompanyName);

                parameters.Add(new SqlParameter("@CallingNo", SqlDbType.VarChar, 20), obj.CallingNo);
                parameters.Add(new SqlParameter("@CategoryID", SqlDbType.TinyInt), obj.CategoryID);
                parameters.Add(new SqlParameter("@CallDetail", SqlDbType.VarChar, 200), obj.CallDetail);
                parameters.Add(new SqlParameter("@IsOutgoing", SqlDbType.Bit), obj.IsOutgoing);

                parameters.Add(new SqlParameter("@City", SqlDbType.VarChar, 50), obj.City);
                parameters.Add(new SqlParameter("@CallStatus", SqlDbType.VarChar, 20), obj.CallStaus);

                new Database().ExecuteNonQueryOnly("Sp_Update_CallRecords", parameters);
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
                return new Database().ExecuteForDataTable("select ContactID,PersonName from Contacts where 1=1 "+where+"");
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
                string query = string.Format(@"delete from CallRecords where CallID={0}", vWhere);
                new Database().ExecuteScalerOnly(query);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}

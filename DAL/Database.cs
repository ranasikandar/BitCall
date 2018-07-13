using System;
using System.Collections.Generic;
using System.Globalization;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Data.Odbc;
using System.Data.OleDb;
using Microsoft.Win32;

namespace DAL
{
    public class Database
    {
        public string ConnectionString = "Server=" + new DAL.Global().ReadReg("BitCallsDBSN", "(Local)") + ";Uid=" + new DAL.Global().ReadReg("BitCallsUN", "sa") + ";Pwd=" + new DAL.Global().ReadReg("BitCallsPD", "") + ";Database=" + new DAL.Global().ReadReg("BitCallsDB", "bitCalls") + ";";

        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;


        public bool ExecuteNonQueryOnly(string strQry)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd;
            con.ConnectionString = ConnectionString;

            try
            {
                con.Open();
                cmd = new SqlCommand(strQry);
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 1000;
                cmd.ExecuteNonQuery();
                return (true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public bool ExecuteNonQueryOnly(string proName, System.Collections.Specialized.ListDictionary Parameters)
        {
            int rowsAffected = 0;
            SqlConnection con = new SqlConnection();
            SqlCommand cmd;
            con.ConnectionString = ConnectionString;
            try
            {
                con.Open();
                cmd = new SqlCommand(proName);
                cmd.CommandType = CommandType.StoredProcedure;
                IDataParameter p;
                if (Parameters != null)
                {
                    foreach (System.Collections.DictionaryEntry param in Parameters)
                    {
                        p = param.Key as IDataParameter;
                        if (null == p)
                        {
                            p.ParameterName = (string)param.Key;
                            p.Value = param.Value;
                        }
                        else
                        {
                            p.Value = param.Value;
                        }
                        cmd.Parameters.Add(p);
                    }
                }
                cmd.Connection = con;
                cmd.CommandTimeout = 1000;
                rowsAffected = cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }


        public Object ExecuteScalerOnly(string strQuery)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd;
            con.ConnectionString = ConnectionString;
            object id = 0;

            try
            {
                con.Open();

                cmd = new SqlCommand(strQuery);
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 1000;
                id = cmd.ExecuteScalar();

                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet ExecuteForDataSet(string strQuery)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd;
            con.ConnectionString = ConnectionString;
            try
            {
                con.Open();
                cmd = new SqlCommand(strQuery);
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                myAdapter.SelectCommand = cmd;
                cmd.CommandTimeout = 1000;
                myAdapter.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ExecuteForDataTable(string strQuery)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd;
            con.ConnectionString = ConnectionString;
            try
            {
                con.Open();
                cmd = new SqlCommand(strQuery, con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }


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

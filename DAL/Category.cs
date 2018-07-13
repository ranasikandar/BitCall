using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Category
    {
        public void InsertCategory(string newCategory)
        {
            string strQuery = "insert into Category values ('"+newCategory+"')";
            new Database().ExecuteNonQueryOnly(strQuery);
        }

        public void UpdateCategory(string categoryName, int categoryID)
        {
            string strQuery = "update Category set CategoryName='"+categoryName+"' where CategoryID="+categoryID+"";
            new Database().ExecuteNonQueryOnly(strQuery);
        }

        public void Delete(string vWhere)
        {
            try
            {
                string query = string.Format(@"delete from Category where CategoryID={0}", vWhere);
                new Database().ExecuteScalerOnly(query);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}

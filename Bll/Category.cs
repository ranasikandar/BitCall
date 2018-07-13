using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bll
{
    public class Category
    {
        public void InsertCategory(string newCategory)
        {
            new DAL.Category().InsertCategory(newCategory);
        }

        public void UpdateCategory(string categoryName, int categoryID)
        {
            new DAL.Category().UpdateCategory(categoryName, categoryID);
        }

        public void Delete(string vWhere)
        {
            new DAL.Category().Delete(vWhere);
        }
    }


}

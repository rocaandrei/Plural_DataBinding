using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToDataSets
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Category(int id, string name)
        {
            CategoryID = id;
            CategoryName = name;
        }
    }
}

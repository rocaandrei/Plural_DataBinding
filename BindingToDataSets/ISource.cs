using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingToDataSets
{
    interface ISource
    {
        object GetCategories();//TO DO: cum il fac pe tipul asta generic nu stiu? l-am facut, put si simplu in override specific tipul obiectului => in origini List<> apartine tot de clasa object,e tip referinta
        object GetProducts(int categoryID);
        void DeleteProduct(BindingSource bidingSource, int productID);
        void AddProduct(BindingSource bidingSource, Product product);
        void Save();
    }
}

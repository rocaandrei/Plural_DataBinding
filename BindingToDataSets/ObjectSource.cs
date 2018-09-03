using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingToDataSets
{
    public class ObjectSource : ISource
    {
        List<Category> _categories = new List<Category>();
        List<Product> _products = new List<Product>();

        public ObjectSource()
        {
            #region Categories
            _categories.Add(new Category(1, "Beverages"));
            _categories.Add(new Category(2, "Condiments"));
            _categories.Add(new Category(3, "Confections"));
            _categories.Add(new Category(4, "Dairy Products"));
            _categories.Add(new Category(5, "Grains/Cerials"));
            _categories.Add(new Category(6, "Meat/Poultry"));
            _categories.Add(new Category(7, "Produce"));
            _categories.Add(new Category(8, "Seafood"));
            #endregion
            #region Products
            _products.Add(new Product(1, "Chai", 1, "10 boxes x 20 bars", 22.5m, 234, 2));
            _products.Add(new Product(2, "Chang", 2, "56 boxes x 77 bars", 43.5m, 10, 2));
            _products.Add(new Product(3, "Aniseed Syrup", 3, "65 boxes x 9 bars", 65.5m, 23, 2));
            _products.Add(new Product(4, "Chef Anton's cajun", 4, "67 boxes x 9 bars", 67.5m, 44, 232));
            _products.Add(new Product(5, "Chef Anton's combo mix", 5, "443 boxes x 77 bars", 22.5m, 77, 332));
            _products.Add(new Product(6, "Grandma's ass", 6, "123 boxes x 20 bars", 57.5m, 555009, 2));
            _products.Add(new Product(7, "Pavlova", 8, "232 boxes x 678 bars", 25.5m, 10, 600));
            _products.Add(new Product(8, "Sex pristols", 7, "56 boxes x 1 bars", 77.5m, 5677, 2));
            _products.Add(new Product(9, "Chaitex", 1, "789 boxes x 45 bars", 65.5m, 34, 3232));
            _products.Add(new Product(10, "MC clever", 2, "55 boxes x 6 bars", 63.5m, 3450, 2));
            _products.Add(new Product(11, "Borax", 3, "7 boxes x 44 bars", 38.5m, 10, 254));
            _products.Add(new Product(12, "Ementaler", 4, "46 boxes x 43 bars", 78.5m, 333, 2));
            _products.Add(new Product(13, "Nessquick", 5, "34 boxes x 48 bars", 88.5m, 8975, 2));
            _products.Add(new Product(14, "Star chips", 6, "325 boxes x 67 bars", 21.5m, 56, 2));
            _products.Add(new Product(15, "Cora", 7, "98 boxes x 43 bars", 15.5m, 322, 2));
            _products.Add(new Product(16, "Metro", 8, "100 boxes x 55 bars", 14.5m, 345, 2));
            _products.Add(new Product(17, "Ray ban", 1, "5 boxes x 54 bars", 16.5m, 43, 2));
            #endregion
        }
        public object GetCategories()
        {
            return _categories;
        }
        public object GetProducts(int categoryId)
        {
            var result = from p in _products
                         where p.CategoryId == categoryId
                         select p;

            return result.ToList();
        }
        public void AddProduct(BindingSource bidingSource, Product product)
        {
            var productID = _products.Max(p => p.ProductID);
           product.ProductID = productID + 1;//adauga urmatorul id produsului, dupa cel mai mare id din serie
            bidingSource.Add(product);
        }

        public void DeleteProduct(BindingSource bidingSource, int productID)
        {
            var query = from prod in _products
                        where prod.ProductID == productID
                        select prod;
            Product productToRemove = query.Single();
            bidingSource.Remove(productToRemove);
        }
        public void Save()//cand e vorba de obiecte din memorie (adica category si product din clasa asta ) nu trebuie sa implementezi aceasta metoda, dar cu DataSet si Linq to SQL trebuie sa salvezi orice inainte de a adauga in proiect 
        {
            MessageBox.Show("You don't need implementation");
        }
    }
}

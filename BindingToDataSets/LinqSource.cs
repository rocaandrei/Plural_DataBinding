using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingToDataSets
{
    public class LinqSource : ISource
    {

        public void AddProduct(BindingSource bidingSource, Product product)
        {
            using (NorthwindDataContext _context = new NorthwindDataContext())
            {
                LinqProduct linqProd = new LinqProduct();
                //copiem valorile din produs in produsul linq
                linqProd.CategoryId = product.CategoryId;//TO DO: asta mai are 
                int _idNext = GetNextID(_context);
                linqProd.ProductID = _idNext;
                linqProd.Discontinued = product.Discontinued;
                linqProd.ProductName = product.ProductName;
                linqProd.QuantityPerUnit = product.QuantityPerUnit;
                linqProd.UnitPrice = product.UnitPrice;
                linqProd.UnitsInStock = product.UnitsInStock;
                linqProd.UnitsOnOrder = product.UnitsOnOrder;
                //acum adaugam in contextul nostru/in tabelul nostru, produsul
                _context.LinqProducts.InsertOnSubmit(linqProd);
                bidingSource.Add(linqProd);
                Save(_context);
            }

        }
        /// <summary>
        /// metoda asta va avea grija sa nu iterez acelasi id in mai multe produse 
        /// </summary>
        /// <param name="_context"></param>
        /// <returns></returns>
        private static int GetNextID(NorthwindDataContext _context)
        {
            int _idNext = _context.LinqProducts.Count() + 1;
            foreach (var item in _context.LinqProducts)
            {
                if (_idNext <= item.CategoryId)
                {
                    _idNext++;
                }
            }

            return _idNext;
        }

        /// <summary>
        /// trebuie sa salvam automat dupa ce adaugam un produs, altfel using o sa cheme metoda Dispose si nu va fi salbat produsul 
        /// </summary>
        /// <param name="_context"></param>
        private void Save(NorthwindDataContext _context)
        {
            try
            {
                _context.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
               throw;
            }
        }

        public void DeleteProduct(BindingSource bidingSource, int productID)
        {
            using (NorthwindDataContext _context = new NorthwindDataContext())
            {
                var querryProduct = from p in _context.LinqProducts
                                    where p.ProductID == productID
                                    select p;

                LinqProduct linqProd = querryProduct.Single();

                _context.LinqProducts.DeleteOnSubmit(linqProd);
                Save(_context);
               // bidingSource.Remove(linqProd);
            }
           
        }

        public object GetCategories()
        {
            object result;
            using (NorthwindDataContext _context = new NorthwindDataContext())
            {
                var categoryTbl = _context.LinqCategories;
                result = categoryTbl.ToList();//<= ideea este ca atunci cand folosim context-ul asa in using, la final cheama metoda Dispose si atunci ca sa ne ramana contextul in salvam intr-un obiect lista ce il vom returna
            }

            return result;
        }

        public object GetProducts(int categoryID)
        {
            object result;
            using (NorthwindDataContext _context = new NorthwindDataContext())
            {
                var productsTbl = from p in _context.LinqProducts
                                  where p.CategoryId == categoryID
                                  select p;

                result = productsTbl.ToList();
            }
            return result;
        }

        public void Save()
        {
            using (NorthwindDataContext _context = new NorthwindDataContext())
            {
                try
                {
                    _context.SubmitChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    throw;
                }
            }
        }
    }
}

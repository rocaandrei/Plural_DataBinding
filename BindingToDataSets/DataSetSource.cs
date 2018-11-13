using BindingToDataSets.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingToDataSets
{
    //facem conexiunea cu un DataSet din SQL - ne legam la anumite tabele din SQL si le manipulam in Windows Form
    public class DataSetSource : ISource
    {
        DataSet _dataSet;//= ne creeaza tiparul nostru, un sablon pentru a stoca datele in tabelul SQL
        SqlDataAdapter _productsDataAdapter;
        public DataSetSource()//in constructor creem si populam _dataSet cu tabelele din SQL
        {
            _dataSet = new DataSet();//aici vor fi stocate datele noastre 

            var connectionSQL = new SqlConnection(Settings.Default.NorthwindConnection);//in paranteza treci connectionString-ul catre baza ta de date -> unde se afla baza de date 
            #region Conexiune cu DB Category
            var categoryDataAdapter = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM Category ", connectionSQL);//dupa ne facem un DataAdapter si mentionam ce vrem sa ne selecteze din baza noastra SQL

            categoryDataAdapter.Fill(_dataSet, "Category");//ne stocam datele in _dataSet
            #endregion

            #region Conexiune cu DB Product
            _productsDataAdapter = new SqlDataAdapter("SELECT * FROM Product ", connectionSQL);
            var builder = new SqlCommandBuilder(_productsDataAdapter);//ASTA IMI VA FACE INSERTURILE DE SAVE SAU DELETE BAZAT PE selectul de sus 
            _productsDataAdapter.Fill(_dataSet, "Product");
            #endregion
        }

        public object GetCategories()
        {
            var categoriesTable = _dataSet.Tables["Category"];

            return categoriesTable;
        }

        public object GetProducts(int categoryID)
        {
            var productsTable = _dataSet.Tables["Product"];
            productsTable.DefaultView.RowFilter = "CategoryID = " + categoryID;
            return productsTable;
        }

        public void AddProduct(BindingSource bidingSource, Product product)
        {
            Save();
            DataTable productsTable = _dataSet.Tables["Product"];
            DataRow row = productsTable.NewRow();
            int _nextId = productsTable.Rows.Count + 2;
            foreach (DataRow item in productsTable.Rows)//am pus iteratia asta ca sa imi dea urmatorul nr de ProductID, mai mare ca ultimul egal
            {
                if (_nextId == (int)item["ProductID"])
                {
                    _nextId++;
                }
            }
            //si mai jos populam randul cu obiectul nou 
            row["ProductID"] = _nextId;//este o valoare temporara, cand e trimis in SQL ii da id-ul automat 
            row["ProductName"] = product.ProductName;
            row["CategoryId"] = product.CategoryId;
            row["QuantityPerUnit"] = product.QuantityPerUnit;
            row["UnitPrice"] = product.UnitPrice;
            row["UnitsInStock"] = product.UnitsInStock;
            row["UnitsOnOrder"] = product.UnitsOnOrder;

            productsTable.Rows.Add(row);//si am adaugat un rand nou in Produse 
            //!! nota cand facem legatura cu DataSet nu avem nevoie de BindingSource cum am facut la obiect, vezi exemplu ObjectSource, pentru ca iti face automat
        }

        public void DeleteProduct(BindingSource bidingSource, int productId)
        {
            using (SqlConnection connectionDataSet = new SqlConnection(Settings.Default.NorthwindConnection))
            {
                var productsTable = _dataSet.Tables["Product"];
                var querryProducts = from prod in productsTable.AsEnumerable()
                                     where prod.RowState != DataRowState.Deleted
                                     where//daca randul nu este sters...
                                     prod.Field<int>("ProductID") == productId
                                     select prod;
                var productRow = querryProducts.Single();
                //     bidingSource.Remove(productRow);
                productRow.Delete();
               // Save();//am pus asta aici sa-mi salveze dupa delete ca altfel imi da o eroare dupa ce sterg un obiect si incerc sa mai sterg unul[Additional information: Deleted row information cannot be accessed through the row.] - daca folosesc using imi salveaza automat 
            }
        }

        public void Save()
        {
            using (SqlConnection connectionDataSet = new SqlConnection(Settings.Default.NorthwindConnection))
            {
                 _productsDataAdapter = new SqlDataAdapter("SELECT * FROM Product ", connectionDataSet);
                var builder = new SqlCommandBuilder(_productsDataAdapter);//ASTA IMI VA FACE INSERTURILE DE SAVE SAU DELETE BAZAT PE selectul de sus 
                _productsDataAdapter.Update(_dataSet, "Product");
            }
        }
    }
}

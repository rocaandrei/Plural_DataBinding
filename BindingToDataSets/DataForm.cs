using BindingToDataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingExample
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }
        BindingSource _categoriesBindingSource = new BindingSource();
        BindingSource _productBindingSource = new BindingSource();

        ISource _currentSource;// pentru ca avem trei tipuri de date returnate: Object, DataSet si Linq to SQL, prop asta va puncta catre tipul curent selectat de noi 
        ObjectSource _objectSource;
        DataSetSource _dataSetSource;

        private void DataForm_Load(object sender, EventArgs e)
        {
            SourceToolStripComboBox.SelectedIndex = 0; //la start pleaca de la indice 0 din Source
            SetSource();
            BindCategories();

            _categoriesBindingSource.DataSource = _currentSource.GetCategories();

            CategoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName";
            CategoryToolStripComboBox.ComboBox.ValueMember = "CategoryID";
            CategoryToolStripComboBox.ComboBox.DataSource = _categoriesBindingSource;

            ProductsDataGridView.DataSource = _productBindingSource;
            ProductsListBox.DisplayMember = "ProductName";
            ProductsListBox.ValueMember = "ProductID";
            ProductsListBox.DataSource = _productBindingSource;

            NameTextBox.DataBindings.Add("Text", _productBindingSource, "ProductName");
            QuantitiyPerUnitTextBox.DataBindings.Add("Text", _productBindingSource, "QuantityPerUnit");
            PriceTextBox.DataBindings.Add("Text", _productBindingSource, "UnitPrice");
            StockTextBox.DataBindings.Add("Text", _productBindingSource, "UnitsInStock");
            UnitsInOrderTextBox.DataBindings.Add("Text", _productBindingSource, "UnitsOnOrder");
            //DiscontinuedCheckBox.DataBindings.Add("Checked", _productBindingSource, "Discontinued"); Comentez asta ca imi da eroare cu DataBingind-ul cand ia din baza de date Discontinued asta il ia ca Bit si nu stiu sa-i fac conversia

        }

        private void SourceToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSource();
            BindCategories();
            BindProducts();
        }
        private void CategoryToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindProducts();
        }

        private void BindProducts()
        {
            var categoryID = CategoryToolStripComboBox.ComboBox.SelectedValue;//aflam categoria selectata
            if (CategoryToolStripComboBox.ComboBox.SelectedValue == null)
            {
                categoryID = 5;//am nevoie de linia asta ca vad ca imi da eroare la prima complilare, ca nu stie ce categorie e initiala, ca e nula
            }

            _productBindingSource.DataSource = _currentSource.GetProducts((int)categoryID);
        }
        private void BindCategories()
        {
            _categoriesBindingSource.DataSource = _currentSource.GetCategories();
        }

        private void SetSource()
        {
            switch (SourceToolStripComboBox.SelectedIndex)
            {
                case 0://Objects
                    if (_objectSource == null)
                    {
                        _objectSource = new ObjectSource();
                    }
                    _currentSource = _objectSource;
                    break;
                case 1://DataSet
                    if (_dataSetSource == null)
                    {
                        _dataSetSource = new DataSetSource();
                    }
                    _currentSource = _dataSetSource;
                    break;
            }
        }

        private void AddStripButton_Click(object sender, EventArgs e)
        {
            var id = (int)CategoryToolStripComboBox.ComboBox.SelectedValue;
            var name = CategoryToolStripComboBox.Text;

            var category = new Category(id, name);//ca sa mearga biding-ul dintre category si data set ne generam aici obiectul
            var productFormAdd = new AddProductForm(category);//si-l adaugam in constructor

            var result = productFormAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                _currentSource.AddProduct(_productBindingSource, productFormAdd.Product);
            }
        }

        private void DeletetoolStripButton_Click(object sender, EventArgs e)
        {

            var productID = (int)ProductsListBox.SelectedValue;
            _currentSource.DeleteProduct(_productBindingSource, productID);

        }

        private void BackToolStripButton_Click(object sender, EventArgs e)
        {
            _productBindingSource.MovePrevious();
        }

        private void ForwardToolStripButton_Click(object sender, EventArgs e)
        {
            _productBindingSource.MoveNext();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            _currentSource.Save();
        }
    }
}

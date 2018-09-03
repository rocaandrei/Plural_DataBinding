using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingToDataSets
{
    public partial class AddProductForm : Form
    {
        Category _category;

        public AddProductForm()
        {
            InitializeComponent();
        }
        public AddProductForm(Category category)
        {
            InitializeComponent();
            _category = category;
            CategoryTextBoxAddProduct.Text = _category.CategoryName;
        }
        public Product Product
        {
            get
            {
                var result = new Product(0, NameTextBoxAddProduct.Text, _category.CategoryID, QuantitiyPerUnitTextBoxAddProduct.Text,
                    decimal.Parse(PriceTextBoxAddProduct.Text), int.Parse(StockTextBoxAddProduct.Text),
                    int.Parse(UnitsInOrderTextBoxAddProduct.Text));
                return result;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}

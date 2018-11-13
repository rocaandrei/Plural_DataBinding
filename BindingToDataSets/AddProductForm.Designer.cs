using System.Windows.Forms;

namespace BindingToDataSets
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.label7 = new System.Windows.Forms.Label();
            this.CategoryTextBoxAddProduct = new System.Windows.Forms.TextBox();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.QuantitiyPerUnitTextBoxAddProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UnitsInOrderTextBoxAddProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StockTextBoxAddProduct = new System.Windows.Forms.TextBox();
            this.PriceTextBoxAddProduct = new System.Windows.Forms.TextBox();
            this.NameTextBoxAddProduct = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Category";
            // 
            // CategoryTextBoxAddProduct
            // 
            this.CategoryTextBoxAddProduct.Enabled = false;
            this.CategoryTextBoxAddProduct.Location = new System.Drawing.Point(106, 45);
            this.CategoryTextBoxAddProduct.Name = "CategoryTextBoxAddProduct";
            this.CategoryTextBoxAddProduct.Size = new System.Drawing.Size(156, 20);
            this.CategoryTextBoxAddProduct.TabIndex = 31;
            this.CategoryTextBoxAddProduct.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton1.Location = new System.Drawing.Point(135, 183);
            this.CancelButton1.Name = "CancelButton";
            this.CancelButton1.Size = new System.Drawing.Size(127, 23);
            this.CancelButton1.TabIndex = 38;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Location = new System.Drawing.Point(16, 183);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(105, 23);
            this.AddButton.TabIndex = 37;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Quantity Per Unit";
            // 
            // QuantitiyPerUnitTextBoxAddProduct
            // 
            this.QuantitiyPerUnitTextBoxAddProduct.Location = new System.Drawing.Point(106, 70);
            this.QuantitiyPerUnitTextBoxAddProduct.Name = "QuantitiyPerUnitTextBoxAddProduct";
            this.QuantitiyPerUnitTextBoxAddProduct.Size = new System.Drawing.Size(156, 20);
            this.QuantitiyPerUnitTextBoxAddProduct.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Units in Order";
            // 
            // UnitsInOrderTextBoxAddProduct
            // 
            this.UnitsInOrderTextBoxAddProduct.Location = new System.Drawing.Point(106, 148);
            this.UnitsInOrderTextBoxAddProduct.Name = "UnitsInOrderTextBoxAddProduct";
            this.UnitsInOrderTextBoxAddProduct.Size = new System.Drawing.Size(156, 20);
            this.UnitsInOrderTextBoxAddProduct.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Units in Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Name";
            // 
            // StockTextBoxAddProduct
            // 
            this.StockTextBoxAddProduct.Location = new System.Drawing.Point(107, 122);
            this.StockTextBoxAddProduct.Name = "StockTextBoxAddProduct";
            this.StockTextBoxAddProduct.Size = new System.Drawing.Size(156, 20);
            this.StockTextBoxAddProduct.TabIndex = 34;
            // 
            // PriceTextBoxAddProduct
            // 
            this.PriceTextBoxAddProduct.Location = new System.Drawing.Point(106, 96);
            this.PriceTextBoxAddProduct.Name = "PriceTextBoxAddProduct";
            this.PriceTextBoxAddProduct.Size = new System.Drawing.Size(156, 20);
            this.PriceTextBoxAddProduct.TabIndex = 33;
            // 
            // NameTextBoxAddProduct
            // 
            this.NameTextBoxAddProduct.Location = new System.Drawing.Point(106, 19);
            this.NameTextBoxAddProduct.Name = "NameTextBoxAddProduct";
            this.NameTextBoxAddProduct.Size = new System.Drawing.Size(156, 20);
            this.NameTextBoxAddProduct.TabIndex = 30;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 219);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CategoryTextBoxAddProduct);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.QuantitiyPerUnitTextBoxAddProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UnitsInOrderTextBoxAddProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StockTextBoxAddProduct);
            this.Controls.Add(this.PriceTextBoxAddProduct);
            this.Controls.Add(this.NameTextBoxAddProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CategoryTextBoxAddProduct;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QuantitiyPerUnitTextBoxAddProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UnitsInOrderTextBoxAddProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StockTextBoxAddProduct;
        private System.Windows.Forms.TextBox PriceTextBoxAddProduct;
        private System.Windows.Forms.TextBox NameTextBoxAddProduct;

        public Button CancelButton1
        {
            get
            {
                return CancelButton;
            }

            set
            {
                CancelButton = value;
            }
        }
    }
}
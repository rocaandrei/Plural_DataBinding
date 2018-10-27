namespace DataBindingExample
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.CategoryToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.SourceToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.BackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeletetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.FormTabPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.QuantitiyPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UnitsInOrderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.GridTabPage = new System.Windows.Forms.TabPage();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.FormTabPage.SuspendLayout();
            this.GridTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.CategoryToolStripComboBox,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.SourceToolStripComboBox,
            this.BackToolStripButton,
            this.ForwardToolStripButton,
            this.toolStripSeparator2,
            this.AddStripButton,
            this.DeletetoolStripButton,
            this.toolStripSeparator3,
            this.SaveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(841, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Category:";
            // 
            // CategoryToolStripComboBox
            // 
            this.CategoryToolStripComboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CategoryToolStripComboBox.Name = "CategoryToolStripComboBox";
            this.CategoryToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.CategoryToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryToolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel2.Text = "Source:";
            // 
            // SourceToolStripComboBox
            // 
            this.SourceToolStripComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Objects"});
            this.SourceToolStripComboBox.Items.AddRange(new object[] {
            "Object",
            "DataSet",
            "Linq to SQL"});
            this.SourceToolStripComboBox.Name = "SourceToolStripComboBox";
            this.SourceToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.SourceToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.SourceToolStripComboBox_SelectedIndexChanged);
            // 
            // BackToolStripButton
            // 
            this.BackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackToolStripButton.Image = global::BindingToDataSets.Properties.Resources.back_icon;
            this.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackToolStripButton.Name = "BackToolStripButton";
            this.BackToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BackToolStripButton.Text = "Back";
            this.BackToolStripButton.Click += new System.EventHandler(this.BackToolStripButton_Click);
            // 
            // ForwardToolStripButton
            // 
            this.ForwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardToolStripButton.Image = global::BindingToDataSets.Properties.Resources.forward_icon;
            this.ForwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardToolStripButton.Name = "ForwardToolStripButton";
            this.ForwardToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ForwardToolStripButton.Text = "Forward";
            this.ForwardToolStripButton.Click += new System.EventHandler(this.ForwardToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // AddStripButton
            // 
            this.AddStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddStripButton.Image = global::BindingToDataSets.Properties.Resources.math_add_icon;
            this.AddStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddStripButton.Name = "AddStripButton";
            this.AddStripButton.Size = new System.Drawing.Size(23, 22);
            this.AddStripButton.Text = "Add";
            this.AddStripButton.Click += new System.EventHandler(this.AddStripButton_Click);
            // 
            // DeletetoolStripButton
            // 
            this.DeletetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeletetoolStripButton.Image = global::BindingToDataSets.Properties.Resources.delete_icon;
            this.DeletetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeletetoolStripButton.Name = "DeletetoolStripButton";
            this.DeletetoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DeletetoolStripButton.Text = "Delete";
            this.DeletetoolStripButton.Click += new System.EventHandler(this.DeletetoolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = global::BindingToDataSets.Properties.Resources.floppy_icon;
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "Save";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.FormTabPage);
            this.TabControl.Controls.Add(this.GridTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 25);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(841, 384);
            this.TabControl.TabIndex = 1;
            // 
            // FormTabPage
            // 
            this.FormTabPage.Controls.Add(this.label6);
            this.FormTabPage.Controls.Add(this.QuantitiyPerUnitTextBox);
            this.FormTabPage.Controls.Add(this.label4);
            this.FormTabPage.Controls.Add(this.UnitsInOrderTextBox);
            this.FormTabPage.Controls.Add(this.label3);
            this.FormTabPage.Controls.Add(this.label2);
            this.FormTabPage.Controls.Add(this.label1);
            this.FormTabPage.Controls.Add(this.StockTextBox);
            this.FormTabPage.Controls.Add(this.PriceTextBox);
            this.FormTabPage.Controls.Add(this.NameTextBox);
            this.FormTabPage.Controls.Add(this.ProductsListBox);
            this.FormTabPage.Location = new System.Drawing.Point(4, 22);
            this.FormTabPage.Name = "FormTabPage";
            this.FormTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FormTabPage.Size = new System.Drawing.Size(833, 358);
            this.FormTabPage.TabIndex = 0;
            this.FormTabPage.Text = "Form";
            this.FormTabPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantity Per Unit";
            // 
            // QuantitiyPerUnitTextBox
            // 
            this.QuantitiyPerUnitTextBox.Location = new System.Drawing.Point(383, 51);
            this.QuantitiyPerUnitTextBox.Name = "QuantitiyPerUnitTextBox";
            this.QuantitiyPerUnitTextBox.Size = new System.Drawing.Size(156, 20);
            this.QuantitiyPerUnitTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Units in Order";
            // 
            // UnitsInOrderTextBox
            // 
            this.UnitsInOrderTextBox.Location = new System.Drawing.Point(383, 129);
            this.UnitsInOrderTextBox.Name = "UnitsInOrderTextBox";
            this.UnitsInOrderTextBox.Size = new System.Drawing.Size(156, 20);
            this.UnitsInOrderTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Units in Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(384, 103);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(156, 20);
            this.StockTextBox.TabIndex = 4;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(383, 77);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(156, 20);
            this.PriceTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Location = new System.Drawing.Point(384, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(156, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.Location = new System.Drawing.Point(17, 21);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(243, 303);
            this.ProductsListBox.TabIndex = 1;
            // 
            // GridTabPage
            // 
            this.GridTabPage.Controls.Add(this.ProductsDataGridView);
            this.GridTabPage.Location = new System.Drawing.Point(4, 22);
            this.GridTabPage.Name = "GridTabPage";
            this.GridTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GridTabPage.Size = new System.Drawing.Size(833, 358);
            this.GridTabPage.TabIndex = 1;
            this.GridTabPage.Text = "Grid";
            this.GridTabPage.UseVisualStyleBackColor = true;
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.Size = new System.Drawing.Size(827, 352);
            this.ProductsDataGridView.TabIndex = 0;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 409);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataForm";
            this.Text = "Data Binding";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataForm_FormClosing);
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.FormTabPage.ResumeLayout(false);
            this.FormTabPage.PerformLayout();
            this.GridTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage FormTabPage;
        private System.Windows.Forms.TabPage GridTabPage;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox CategoryToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox SourceToolStripComboBox;
        private System.Windows.Forms.ToolStripButton BackToolStripButton;
        private System.Windows.Forms.ToolStripButton ForwardToolStripButton;
        private System.Windows.Forms.ToolStripButton AddStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DeletetoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UnitsInOrderTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QuantitiyPerUnitTextBox;
    }
}


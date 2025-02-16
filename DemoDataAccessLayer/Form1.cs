﻿using DemoDataAccessLayer.BLL;
using DemoDataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoDataAccessLayer
{
    public partial class Form1 : Form
    {
        List<Category> listCategory = new List<Category>();
        public Form1()
        {
            InitializeComponent();
            loadCategoriesName();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = (Category)comboBox1.SelectedItem;
            loadProductToComboBox(category.CategoryID);
            loadProductToListView(category.CategoryID);
            loadProductToDataGridView(category.CategoryID);
        }
        private void loadProductToDataGridView(int categoryID)
        {
            ProductBLL productBLL = new ProductBLL();
            DataTable dataTable = productBLL.GetDataTableProductByCategoryID(categoryID);
            dataGridView1.DataSource = dataTable;
        }
        private void loadProductToListView(int categoryID)
        {
            ProductBLL productBLL = new ProductBLL();
            List<Product> listProduct = productBLL.GetListProductByCategoryID(categoryID);
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantity Per Unit", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Unit Price", -2, HorizontalAlignment.Center);
            foreach (Product product in listProduct)
            {
                ListViewItem viewItem = new ListViewItem(product.ProductID.ToString());
                viewItem.SubItems.Add(product.ProductName);
                viewItem.SubItems.Add(product.QuantityPerUnit);
                viewItem.SubItems.Add(product.UnitPrice.ToString());
                listView1.Items.Add(viewItem);
            }
        }
        private void loadProductToComboBox(int categoryID)
        {
            ProductBLL productBLL = new ProductBLL();
            comboBox2.DataSource = productBLL.GetListProductByCategoryID(categoryID);
            comboBox2.DisplayMember = "ProductName";
        }
        private void loadCategoriesName()
        {
            CategoryBLL categoryBLL = new CategoryBLL();
            listCategory = categoryBLL.GetCategories();
            comboBox1.DataSource = listCategory;
            comboBox1.DisplayMember = "CategoryName";
        }


        private void listView1_Click(object sender, EventArgs e)
        {
           //MessageBox.Show(listView1.SelectedItems[0].ToString());
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.SelectedItem.ToString());
        }
    }
}

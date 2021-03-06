﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodDemo.data;
using FastFoodDemo.Model;

namespace FastFoodDemo
{
    public partial class SellCustomControl : UserControl
    {
        private readonly ProductService _productService;
        public SellCustomControl()
        {
            InitializeComponent();
           _productService = new ProductService();
           
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SellCustomControl_Load(object sender, EventArgs e)
        {
            try
            {

                List<CategoryModel> category = new List<CategoryModel>{new CategoryModel{ Id=1,Name="Medicine"},
                                     new CategoryModel{ Id=2,Name="Syrup"},
                                     new CategoryModel{ Id=3,Name="General"} };
                drpCategory.DisplayMember = "Name";
                drpCategory.ValueMember = "Id";
                drpCategory.DataSource = category;
            }
            catch (Exception ex)
            {

                
            }
           

        }

        private void drpProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //var check = drpProduct.SelectedValue.ToString();
                if (drpProduct.SelectedValue.ToString() != "0")
                {
                    int productId = Convert.ToInt32(drpProduct.SelectedValue.ToString());
                    var product = _productService.GetProductById(productId);
                    txtSp.Text = product.SoldPricePerUnit.ToString();
                    if (product.CategoryId == 1)
                    {
                        txtStock.Text = product.TotalTabletStock.ToString();
                    }
                    else
                    {
                        txtStock.Text = product.Quantity.ToString();
                    }
                }
                else
                {
                    txtSp.Text = "";
                    txtStock.Text = "";
                }

            }
            catch (Exception)
            {


            }

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {

                int qty = 1;
                decimal price = 1;
                if (txtAp.Text == "")
                {
                    price = Convert.ToDecimal(txtSp.Text.ToString());
                }
                else
                {
                    price = Convert.ToDecimal(txtAp.Text.ToString());
                }
               
                qty = Convert.ToInt32(txtQty.Text.ToString());
                decimal totalUnitPrice = price * qty;
                lblUnitPrice.Text = Convert.ToString(totalUnitPrice);


            }
            catch (Exception ex)
            {

                lblUnitPrice.Text = "";
            }
        }

        private void drpCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int categoryId = Convert.ToInt32(drpCategory.SelectedValue.ToString());

                var product = _productService.GetProductByCategory(categoryId);
                List<ProductModel> model = product.Select(x => new ProductModel { ProductName = x.ProductName + "-" + x.Formula, Id = x.Id }).ToList();
                //model.Insert(0, new ProductModel { Id = 0, ProductName = "please select" });
                drpProduct.DisplayMember = "ProductName";
                drpProduct.ValueMember = "Id";
                drpProduct.DataSource = model;
                drpProduct.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

            }
            
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = ((ProductModel)drpProduct.SelectedItem).ProductName;
                string category = ((CategoryModel)drpCategory.SelectedItem).Name;


                int rowIndex = cartGrid.NewRowIndex;

                DataGridViewRow row = (DataGridViewRow)cartGrid.Rows[0].Clone();
                row.Cells[0].Value = productName;
                row.Cells[1].Value = category;
                row.Cells[2].Value = txtQty.Text;
                row.Cells[3].Value = txtSp.Text;
                row.Cells[4].Value = lblUnitPrice.Text;
                cartGrid.Rows.Add(row);

                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in cartGrid.Columns)
                {
                    dt.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row1 in cartGrid.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row1.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dRow);
                }

                double totalPrice = dt.AsEnumerable().Select(x => Convert.ToDouble(x[4] == DBNull.Value ? 0 : x[4])).Sum();
                lblNetBill.Text = totalPrice.ToString();
            }
            catch (Exception ex)
            {

         
            }
           
        }

        private void txtAp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int qty = 1;
                decimal price = 1;
                price = Convert.ToDecimal(txtAp.Text.ToString());
                qty = Convert.ToInt32(txtQty.Text.ToString());
                decimal totalUnitPrice = price * qty;
                lblUnitPrice.Text = Convert.ToString(totalUnitPrice);
            }
            catch (Exception ex)
            {

                
            }
            
        }

        private void lblUnitPrice_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodDemo.Model;
using FastFoodDemo.data;

namespace FastFoodDemo
{
    public partial class AddProductCustmControl : UserControl
    {
        private readonly ProductService _productService;
        public AddProductCustmControl()
        {
            _productService = new ProductService();
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ProductModel model = new ProductModel();
                int tablet = 1;

                decimal purchasePrice = Convert.ToDecimal(txtRetailPrice.Text);
                decimal soldPrice = Convert.ToDecimal(txtSoldPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);

                model.ProductName = txtProductName.Text.ToString();
                model.Formula = txtFormula.Text.ToString();
                model.CategoryId = Convert.ToInt32(drpCategory.SelectedValue.ToString());
                model.Quantity = quantity;



                if (model.CategoryId == 1)
                {

                    tablet = Convert.ToInt32(txtTablet.Text);
                    model.TotalQuantityPerPacket = tablet;
                    model.SoldPricePerUnit = soldPrice / tablet;
                    model.RetailPricePerUnit = purchasePrice / tablet;
                    model.TotalTabletStock = quantity * tablet;
                }
                else
                {
                    model.SoldPricePerUnit = soldPrice;
                    model.RetailPricePerUnit = purchasePrice;
                }
                model.TotalSoldPrice = soldPrice * quantity;
                model.TotalPurchasePrice = purchasePrice * quantity;

                bool isSave = _productService.AddProduct(model);
                if (isSave)
                {
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "Product Save";
                    lblMessage.Show();
                    var t = new Timer();
                    t.Interval = 3000; // it will Tick in 3 seconds
                    t.Tick += (s, x) =>
                    {
                        lblMessage.Hide();
                        t.Stop();
                    };
                    t.Start();
                    AddProductCustmControl_Load(sender, e);
                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Some error Occured while adding the record...";
                    lblMessage.Show();
                    var t = new Timer();
                    t.Interval = 3000; // it will Tick in 3 seconds
                    t.Tick += (s, x) =>
                    {
                        lblMessage.Hide();
                        t.Stop();
                    };
                    t.Start();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void AddProductCustmControl_Load(object sender, EventArgs e)
        {
            List<CategoryModel> category = new List<CategoryModel>{new CategoryModel{ Id=1,Name="Medicine"},
                                     new CategoryModel{ Id=2,Name="Syrup"},
                                     new CategoryModel{ Id=3,Name="General"} };

            drpCategory.DataSource = category;
            drpCategory.DisplayMember = "Name";
            drpCategory.ValueMember = "Id";
            txtFormula.Text = "";
            txtProductName.Text = "";
            txtQuantity.Text = "";
            txtRetailPrice.Text = "";
            txtSoldPrice.Text = "";
            txtTablet.Text = "";
            txtProductName.Focus();
        }

        private void DrpCategory_onItemSelected(object sender, EventArgs e)
        {

        }

        private void drpCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = drpCategory.SelectedValue.ToString();
            if (value == "2" || value == "3")
            {
                txtTablet.Enabled = false;
                txtTablet.BackColor = Color.Gray;
            }
            else
            {
                txtTablet.Enabled = true;
                txtTablet.BackColor = txtProductName.BackColor;
            }
        }
    }
}

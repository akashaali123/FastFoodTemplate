using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class AddProductCustmControl : UserControl
    {
        public AddProductCustmControl()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            decimal purchasePrice = Convert.ToDecimal(txtRetailPrice.Text);
            decimal soldPrice = Convert.ToDecimal(txtSoldPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int tablet = Convert.ToInt32(txtTablet.Text);
            decimal spPerTablet = soldPrice / tablet;
            decimal rpPerTablet = purchasePrice / tablet;

        }

        private void AddProductCustmControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}

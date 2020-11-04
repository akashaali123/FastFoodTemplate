using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnDashboard.Height;
            SidePanel.Top = btnDashboard.Top;
            firstCustomControl1.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDashboard.Height;
            SidePanel.Top = btnDashboard.Top;
            firstCustomControl1.BringToFront();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Height = addPrdouct.Height;
            SidePanel.Top = addPrdouct.Top;
            mySecondCustmControl1.BringToFront();

            //Thanks for watching Friends...
            //Please dont forget to Subscribe... :) :) :) 
        }
    }
}

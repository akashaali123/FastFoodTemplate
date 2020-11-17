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
            //SidePanel.Height = btnDashboard.Height;
            //SidePanel.Top = btnDashboard.Top;
            //dashboardCustomControl.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDashboard.Height;
            SidePanel.Top = btnDashboard.Top;
            dashboardCustomControl.BringToFront();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Height = addPrdouct.Height;
            SidePanel.Top = addPrdouct.Top;
            addProductCustmControl.BringToFront();

            //Thanks for watching Friends...
            //Please dont forget to Subscribe... :) :) :) 
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SidePanel.Height = btnDashboard.Height;
            SidePanel.Top = btnDashboard.Top;
            dashboardCustomControl.BringToFront();
            
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSell.Height;
            SidePanel.Top = btnSell.Top;
            sellCustomControl1.BringToFront();
           
        }

        private void btnAllProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSell.Height;
            SidePanel.Top = btnSell.Top;
            allProductControl1.BringToFront();
        }

        //private void sellCustomControl1_Load(object sender, EventArgs e)
        //{


        //}
    }
}

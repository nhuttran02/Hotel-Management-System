using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Controller
{
    public partial class UC_Services : UserControl
    {
        function fn = new function();
        String query;
        public UC_Services()
        {
            InitializeComponent();
        }

        private void UC_Services_Load(object sender, EventArgs e)
        {
            query = "Select * from Services";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text != "" && txtPrice.Text != "")
            {
                String sname = txtServiceName.Text;
                float sprice = float.Parse(txtPrice.Text);


                query = "insert into Services(sname, sprice) values ('" + sname + "','" + sprice + "')";
                fn.setData(query, "Adding Successfully");

                UC_Services_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Please fill in the information", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtServiceName.Clear();
            txtPrice.Clear();

        }

        private void UC_Services_Enter(object sender, EventArgs e)
        {
            UC_Services_Load(this, null);
        }

        private void txtServiceName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

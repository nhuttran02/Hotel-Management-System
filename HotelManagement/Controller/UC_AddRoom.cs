using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagement.Controller
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "Select * from Room";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomType.Text != "" && txtRoomNo.Text != "" && txtPrice.Text != "")
            {
                String roomtype = txtRoomType.Text;
                String roomnumber = txtRoomNo.Text;
                float price = float.Parse(txtPrice.Text);


                query = "insert into Room(roomtype, roomnumber, price) values ('"+ roomtype +"','" + roomnumber + "','" + price + "')";
                fn.setData(query, "Adding Successfully");

                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Please fill in the information", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }

        public void clearAll()
        {
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Clear();
            txtPrice.Clear();

        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
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
    public partial class UC_Payment : UserControl
    {
        function fn = new function();
        String query;
        public UC_Payment()
        {
            InitializeComponent();
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomNumber.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtTotal.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

         

        private void UC_Payment_Load(object sender, EventArgs e)
        {
            query = "select Customer.cid, Customer.cname, Customer.cphone, Customer.caddress, Customer.cgender, Customer.cbirth, Customer.cidnumber, Customer.ccheckin, Customer.cservicesfee, Customer.finalprice, Room.roomtype, Room.roomnumber, Room.price from Customer inner join Room on Customer.croomid = Room.roomid where cchekout = 'NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select Customer.cid, Customer.cname, Customer.cphone, Customer.caddress, Customer.cgender, Customer.cbirth, Customer.cidnumber, Customer.ccheckin, Customer.cservicesfee, Customer.finalprice, Room.roomtype, Room.roomnumber, Room.price from Customer inner join Room on Customer.croomid = Room.roomid where cname like '" + txtName.Text + "%' and cchekout = 'NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(txtCName.Text != null)
            {
                if (MessageBox.Show("Are you sure?", "Comfirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckoutDate.Text;
                    query = "update Customer set cchekout = 'YES', ccheckout = '" + cdate + "' where cid = " + id + " update Room SET status = 'AVAILABLE' where roomnumber = '" + txtRoomNumber.Text + "'";
                    fn.setData(query, "Payment success");
                    UC_Payment_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("There are no customers to choose from", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtName.Clear();
            txtRoomNumber.Clear();
            txtCheckoutDate.ResetText();
            txtTotal.Clear();
        }

        private void UC_Payment_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_Payment_Click(object sender, EventArgs e)
        {
            
        }

        private void txtRoomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

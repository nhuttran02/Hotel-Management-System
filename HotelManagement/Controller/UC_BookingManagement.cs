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
    public partial class UC_BookingManagement : UserControl
    {
        function fn = new function();
        String query;
        public UC_BookingManagement()
        {
            InitializeComponent();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0)
            {
                query = "select Customer.cid, Customer.cname, Customer.cphone, Customer.caddress, Customer.cgender, Customer.cbirth, Customer.cidnumber, Customer.ccheckin, Customer.cservicesfee, Customer.finalprice, Room.roomtype, Room.roomnumber, Room.price from Customer inner join Room on Customer.croomid = Room.roomid";
                getRecord(query);
            }
            else if (txtSearchBy.SelectedIndex == 1)
            {
                query = "select Customer.cid, Customer.cname, Customer.cphone, Customer.caddress, Customer.cgender, Customer.cbirth, Customer.cidnumber, Customer.ccheckin, Customer.cservicesfee, Customer.finalprice, Room.roomtype, Room.roomnumber, Room.price from Customer inner join Room on Customer.croomid = Room.roomid where ccheckout is null";
                getRecord(query);
            }
            else if (txtSearchBy.SelectedIndex == 2)
            {
                query = "select Customer.cid, Customer.cname, Customer.cphone, Customer.caddress, Customer.cgender, Customer.cbirth, Customer.cidnumber, Customer.ccheckin, Customer.cservicesfee, Customer.finalprice, Room.roomtype, Room.roomnumber, Room.price from Customer inner join Room on Customer.croomid = Room.roomid where ccheckout is not null";
                getRecord(query);
            }
        }

        private void getRecord(String query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_BookingManagement_Load(object sender, EventArgs e)
        {

        }
    }
}

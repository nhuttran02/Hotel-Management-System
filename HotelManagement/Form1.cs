using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select eusername, epassword from Employee where eusername = '" + txtUsername.Text + "' and epassword = '" + txtPassword.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                Dashboard dss = new Dashboard();
                this.Hide();
                dss.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid account");
                txtPassword.Clear();
            }
        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }
    }
}

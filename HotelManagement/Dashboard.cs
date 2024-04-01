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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRegister1.Visible = false;
            uC_Payment1.Visible = false;
            uC_BookingManagement1.Visible = false;
            uC_Employee1.Visible = false;
            uC_Services1.Visible = false;
            btnAddroom.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddroom_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnAddroom.Left + 60;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        

        private void btnCustomerRegistion_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCustomerRegistion.Left + 63;
            uC_CustomerRegister1.Visible = true;
            uC_CustomerRegister1.BringToFront();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnPayment.Left + 62;
            uC_Payment1.Visible = true;
            uC_Payment1.BringToFront();
        }

        private void btnBookingManagement_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnBookingManagement.Left + 62;
            uC_BookingManagement1.Visible = true;
            uC_BookingManagement1.BringToFront();
        }

        private void btnEmployeee_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnEmployeee.Left + 63;
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 dss = new Form1();
            this.Hide();
            dss.Show();
        }

        private void PanelMoving_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnServices.Left + 62;
            uC_Services1.Visible = true;
            uC_Services1.BringToFront();
        }
    }
}

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

namespace HotelManagement.Controller
{
    public partial class UC_CustomerRegister : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerRegister()
        {
            InitializeComponent();
            //InitializeComboBox();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);

            while (sdr.Read())
            {
                combo.Items.Add(sdr.GetValue(2).ToString());
            }
            sdr.Close();
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNumber.Items.Clear();
            txtPrice.Clear();
            query = "select * from Room where roomtype = '" + txtRoomType.Text + "' and status = 'AVAILABLE'";
            setComboBox(query, txtRoomNumber);
        }

        //private void UpdatePrice(string roomNumber)
        //{
        //    // Chuỗi kết nối tới cơ sở dữ liệu
        //    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\NHUT\\OneDrive\\Documents\\dbHotelMS.mdf;Integrated Security=True;Connect Timeout=30";

        //    // Tạo câu lệnh truy vấn SQL để lấy giá tiền dựa trên roomnumber được chọn
        //    string query = "SELECT price FROM Room WHERE roomnumber = @RoomNumber";

        //    // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@RoomNumber", roomNumber);

        //        try
        //        {
        //            connection.Open();
        //            object result = command.ExecuteScalar();
        //            if (result != null)
        //            {
        //                // Cập nhật giá trị của txtPrice với giá tiền đã lấy được từ cơ sở dữ liệu
        //                txtPrice.Text = result.ToString();
        //            }
        //            else
        //            {
        //                // Xử lý trường hợp không tìm thấy giá tiền cho roomnumber được chọn
        //                // (ví dụ: hiển thị một giá trị mặc định hoặc thông báo lỗi)
        //                txtPrice.Text = "N/A";
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            // Xử lý ngoại lệ nếu có
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //    }
        //}

        int rid;
        private void txtRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //query = "select price, roomid from Room where roomnumber = '" + txtRoomNumber + "'";
            //DataSet ds = fn.getData(query);
            //rid = int.Parse(ds.Tables[0].Rows[0][2].ToString());
            query = "select price, roomid from Room where roomnumber = '" + txtRoomNumber.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                // Kiểm tra nếu có dữ liệu từ bảng Room
                txtPrice.Text = ds.Tables[0].Rows[0]["price"].ToString();
                rid = Convert.ToInt32(ds.Tables[0].Rows[0]["roomid"]);
            }
            else
            {
                // Xử lý trường hợp không tìm thấy dữ liệu từ bảng Room
                txtPrice.Text = "N/A";
                rid = -1; // Đặt rid về -1 để chỉ ra rằng không có dữ liệu hợp lệ
            }



            //UpdatePrice(txtRoomNumber.Text);

        }
        float finalprice;

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhonenumber.Text != "" && txtAddress.Text != "" && txtGender.Text != "" && birthday.Text != "" && txtIDNumber.Text != "" && CheckinTime.Text != "" && txtPrice.Text != "" && txtServicefee.Text != "")
            {
                String cname = txtName.Text;
                Int64 cphone = int.Parse(txtPhonenumber.Text);
                String caddress = txtAddress.Text;
                String cgender = txtGender.Text;
                String cbirth = birthday.Text;
                String cidnumber = txtIDNumber.Text;
                String ccheckin = CheckinTime.Text;
                float cservicesfee = float.Parse(txtServicefee.Text);
                float rprice = float.Parse(txtPrice.Text);
                finalprice = cservicesfee + rprice;

                query = "insert into Customer (cname,cphone,caddress,cgender,cbirth,cidnumber,ccheckin,cservicesfee,finalprice,croomid) values (N'" + cname + "', '" + cphone + "', N'" + caddress + "', '" + cgender + "', '" + cbirth + "', '" + cidnumber + "', '" + ccheckin + "','"+ cservicesfee + "',"+ finalprice + ", " + rid + ") update Room set status = 'BOOKED' where roomnumber = '" + txtRoomNumber.Text + "'";
                fn.setData(query, "Customer" + txtName.Text + " successfully registered for room " + txtRoomNumber.Text + " !");
                clearAll();
            }
            else
            {
                MessageBox.Show("Please fill in information","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtPhonenumber.Clear();
            txtAddress.Clear();
            txtGender.SelectedIndex = -1;
            birthday.ResetText();
            txtIDNumber.Clear();
            CheckinTime.ResetText();
            txtRoomType.SelectedIndex = -1;
            txtRoomNumber.Items.Clear();
            txtPrice.Clear();
        }

        private void UC_CustomerRegister_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_CustomerRegister_Load(object sender, EventArgs e)
        {
        }
        void LoadData(string Data)
        {
            txtServicefee.Text = "";
            txtServicefee.Text = Data;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SelectServiceForm ss = new SelectServiceForm();
            ss.truyenData = new SelectServiceForm.TruyenChoCha(LoadData);
            ss.ShowDialog();
        }

        private void txtServicefee_TextChanged(object sender, EventArgs e)
        {

        }

        //private void InitializeComboBox()
        //{
        //    txtServices.SelectionMode = SelectionMode.MultiSimple; // Cho phép chọn nhiều mục
        //    //Thêm dữ liệu vào ComboBox từ cơ sở dữ liệu của bạn
        //}
        //int sfee;
        //private void txtServices_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    query = "select sprice, sid from Services where sname = '" + txtServices.Text + "'";
        //    DataSet ds = fn.getData(query);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        // Kiểm tra nếu có dữ liệu từ bảng Services
        //        txtServicefee.Text = ds.Tables[0].Rows[0]["sprice"].ToString();
        //        sfee = Convert.ToInt32(ds.Tables[0].Rows[0]["sid"]);
        //    }
        //    else
        //    {
        //        // Xử lý trường hợp không tìm thấy dữ liệu từ bảng Services
        //        txtServicefee.Text = "N/A";
        //        sfee = -1; // Đặt sfee về -1 để chỉ ra rằng không có dữ liệu hợp lệ
        //    }

        //}


    }
}

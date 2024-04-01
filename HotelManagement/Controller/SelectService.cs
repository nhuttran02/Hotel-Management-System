using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Controller
{
    public partial class SelectServiceForm : Form
    {
        public delegate void TruyenChoCha(string text);
        public TruyenChoCha truyenData;

        function fn = new function();
        String query;
        //private int totalPrice;
        private int totalPrice = 0;
        public SelectServiceForm()
        {
            InitializeComponent();

            // Cách 1
            //foreach (Guna2TextBox textBox in this.Controls.OfType<Guna2TextBox>())
            //{
            //    textBox.TextChanged += CalculateTotal;
            //}

            //Cách 2
            // Add the new textboxes for quantities
            for (int i = 1; i <= 8; i++)
            {
                string quantityTextBoxName = $"q{i}";
                Guna2TextBox quantityTextBox = new Guna2TextBox();
                quantityTextBox.Name = quantityTextBoxName;
                // Set appropriate location and size for the textbox
                this.Controls.Add(quantityTextBox);
                quantityTextBox.TextChanged += CalculateTotal;
            }

            // Attach CalculateTotal event handler to all textboxes
            foreach (Guna2TextBox textBox in this.Controls.OfType<Guna2TextBox>())
            {
                textBox.TextChanged += CalculateTotal;
            }
        }


        //private void s1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    query = "select * from Services where sname = '" + s1.Text + "'";
        //    DataSet ds = fn.getData(query);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        // Kiểm tra nếu có dữ liệu từ bảng Room
        //        p1.Text = ds.Tables[0].Rows[0]["sprice"].ToString();
        //    }
        //    else
        //    {
        //        // Xử lý trường hợp không tìm thấy dữ liệu từ bảng Room
        //        p1.Text = "N/A";
        //    }
        //}



        private void SelectServiceForm_Load(object sender, EventArgs e)
        {
            LoadServiceNames();
            LoadServiceNames2();
            LoadServiceNames3();
            LoadServiceNames4();
            LoadServiceNames5();
            LoadServiceNames6();
            LoadServiceNames7();
            LoadServiceNames8();
        }



        private void LoadServiceNames()
        {
            query = "SELECT sname FROM Services";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    s1.Items.Add(row["sname"].ToString());
                }
            }
        }

        private void LoadServiceNames2()
        {
            query = "SELECT sname FROM Services";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    s2.Items.Add(row["sname"].ToString());
                }
            }
        }

        private void LoadServiceNames3()
        {
            query = "SELECT sname FROM Services";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    s3.Items.Add(row["sname"].ToString());
                }
            }
        }

        private void LoadServiceNames4()
        {
            query = "SELECT sname FROM Services";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    s4.Items.Add(row["sname"].ToString());
                }
            }
        }

        private void LoadServiceNames5()
        {
            query = "SELECT sname FROM Services";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    s5.Items.Add(row["sname"].ToString());
                }
            }
        }

        private void LoadServiceNames6()
        {
            query = "SELECT sname FROM Services";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    s6.Items.Add(row["sname"].ToString());
                }
            }
        }

        private void LoadServiceNames7()
        {
            query = "SELECT sname FROM Services";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    s7.Items.Add(row["sname"].ToString());
                }
            }
        }

        private void LoadServiceNames8()
        {
            query = "SELECT sname FROM Services";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    s8.Items.Add(row["sname"].ToString());
                }
            }
        }


        //public class DatabaseManager
        //{
        //    public SqlConnection getConnection()
        //    {
        //        SqlConnection con = new SqlConnection();
        //        con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\NHUT\\OneDrive\\Documents\\dbHotelMS.mdf;Integrated Security=True;Connect Timeout=30";
        //        return con;
        //    }
        //}


        private void s1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s1.SelectedItem != null)
            {
                string selectedServiceName = s1.SelectedItem.ToString();
                query = "SELECT sprice FROM Services WHERE sname = '" + selectedServiceName + "'";
                SqlDataReader dr = fn.getForCombo(query);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        p1.Text = dr["sprice"].ToString();
                    }
                }
                else
                {
                    p1.Text = "N/A";
                }
                dr.Close();

            }

            //---------------------------------------------------------------------------------------------------------------
            //double price = 0;
            //double quantity = 0;

            //if (s1.SelectedItem != null)
            //{
            //    string selectedServiceName = s1.SelectedItem.ToString();
            //    query = "SELECT sprice FROM Services WHERE sname = '" + selectedServiceName + "'";
            //    SqlDataReader dr = fn.getForCombo(query);
            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //            // Chuyển đổi giá trị sprice từ database sang kiểu double và gán vào biến price
            //            if (double.TryParse(dr["sprice"].ToString(), out price))
            //            {
            //                // Giá trị sprice hợp lệ và đã được chuyển đổi sang double
            //            }
            //            else
            //            {
            //                // Xử lý trường hợp không chuyển đổi được sprice sang double
            //                p1.Text = "Invalid price format";
            //                return;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        p1.Text = "N/A";
            //        return;
            //    }
            //    dr.Close();
            //}

            //// Gán giá trị quantity từ q1.Text, nếu q1.Text không phải là số hoặc là chuỗi rỗng, mặc định quantity = 0
            //if (!double.TryParse(q1.Text, out quantity))
            //{
            //    quantity = 0; // Nếu q1.Text không phải là số, mặc định quantity sẽ là 0
            //}

            //// Tính toán và in ra giá trị
            //p1.Text = (quantity * price).ToString();
        }

        //---------------------------------------------------------------------------------------------

        // Tạo một đối tượng DatabaseManager
        //DatabaseManager dbManager = new DatabaseManager();

        //if (s1.SelectedItem != null)
        //{
        //    string selectedServiceName = s1.SelectedItem.ToString();
        //    string query = "SELECT sprice FROM Services WHERE sname = @serviceName";

        //    // Gọi phương thức getConnection() từ đối tượng dbManager
        //    using (SqlConnection con = dbManager.getConnection())
        //    {
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.Parameters.AddWithValue("@serviceName", selectedServiceName);

        //        con.Open();

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.HasRows)
        //        {
        //            while (dr.Read())
        //            {
        //                if (decimal.TryParse(q1.Text, out decimal quantity))
        //                {
        //                    decimal sprice = decimal.Parse(dr["sprice"].ToString());
        //                    decimal totalPrice = quantity * sprice;
        //                    p1.Text = totalPrice.ToString();
        //                }
        //                else
        //                {
        //                    p1.Text = "N/A"; // Xử lý khi q1.Text không phải số
        //                }
        //            }
        //        }
        //        else
        //        {
        //            p1.Text = "N/A";
        //        }
        //        dr.Close();
        //    }
        //}
        //}



        private void s2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string quantityText = q2.Text;
            //int quantity = int.Parse(quantityText);
            if (s2.SelectedItem != null)
            {
                string selectedServiceName = s2.SelectedItem.ToString();
                query = "SELECT sprice FROM Services WHERE sname = '" + selectedServiceName + "'";
                SqlDataReader dr = fn.getForCombo(query);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        p2.Text = dr["sprice"].ToString();
                    }
                }
                else
                {
                    p2.Text = "N/A";
                }
                dr.Close();
            }

        }

        private void s3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (s3.SelectedItem != null)
            {
                string selectedServiceName = s3.SelectedItem.ToString();
                query = "SELECT sprice FROM Services WHERE sname = '" + selectedServiceName + "'";
                SqlDataReader dr = fn.getForCombo(query);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        p3.Text = dr["sprice"].ToString();
                    }
                }
                else
                {
                    p3.Text = "N/A";
                }
                dr.Close();
                //CalculateTotalPrice();
            }

        }

        private void s4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s4.SelectedItem != null)
            {
                string selectedServiceName = s4.SelectedItem.ToString();
                query = "SELECT sprice FROM Services WHERE sname = '" + selectedServiceName + "'";
                SqlDataReader dr = fn.getForCombo(query);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        p4.Text = dr["sprice"].ToString();
                    }
                }
                else
                {
                    p4.Text = "N/A";
                }
                dr.Close();
                //CalculateTotalPrice();
            }

        }

        private void s5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s5.SelectedItem != null)
            {
                string selectedServiceName = s5.SelectedItem.ToString();
                query = "SELECT sprice FROM Services WHERE sname = '" + selectedServiceName + "'";
                SqlDataReader dr = fn.getForCombo(query);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        p5.Text = dr["sprice"].ToString();
                    }
                }
                else
                {
                    p5.Text = "N/A";
                }
                dr.Close();
                //CalculateTotalPrice();
            }
        }

        private void s6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s6.SelectedItem != null)
            {
                string selectedServiceName = s6.SelectedItem.ToString();
                query = "SELECT sprice FROM Services WHERE sname = '" + selectedServiceName + "'";
                SqlDataReader dr = fn.getForCombo(query);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        p6.Text = dr["sprice"].ToString();
                    }
                }
                else
                {
                    p6.Text = "N/A";
                }
                dr.Close();
                //CalculateTotalPrice();
            }
        }

        private void s7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s7.SelectedItem != null)
            {
                string selectedServiceName = s7.SelectedItem.ToString();
                query = "SELECT sprice FROM Services WHERE sname = '" + selectedServiceName + "'";
                SqlDataReader dr = fn.getForCombo(query);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        p7.Text = dr["sprice"].ToString();
                    }
                }
                else
                {
                    p7.Text = "N/A";
                }
                dr.Close();
                //CalculateTotalPrice();
            }
        }

        private void s8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s8.SelectedItem != null)
            {
                string selectedServiceName = s8.SelectedItem.ToString();
                query = "SELECT sprice FROM Services WHERE sname = '" + selectedServiceName + "'";
                SqlDataReader dr = fn.getForCombo(query);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        p8.Text = dr["sprice"].ToString();
                    }
                }
                else
                {
                    p8.Text = "N/A";
                }
                dr.Close();
                //CalculateTotalPrice();
            }
        }

        //private void CalculateTotalPrice()
        //{
        //    int price1, price2, price3, price4, price5, price6, price7, price8;
        //    if (int.TryParse(p1.Text, out price1) && int.TryParse(p2.Text, out price2) && int.TryParse(p3.Text, out price3) && int.TryParse(p4.Text, out price4) && int.TryParse(p5.Text, out price5) && int.TryParse(p6.Text, out price6) && int.TryParse(p7.Text, out price7) && int.TryParse(p8.Text, out price8))
        //    {
        //        totalPrice = price1 + price2 + price3 + price4 + price5 + price6 + price7 + price8;
        //        totalfee.Text = totalPrice.ToString();
        //    }
        //}

        private void totalfee_TextChanged(object sender, EventArgs e)
        {

        }

        //private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Guna2ComboBox comboBox = (Guna2ComboBox)sender;
        //    Guna2TextBox textBox = null;

        //    // Xác định TextBox tương ứng với ComboBox
        //    switch (comboBox.Name)
        //    {
        //        case "s1":
        //            textBox = p1;
        //            break;
        //        case "s2":
        //            textBox = p2;
        //            break;
        //        case "s3":
        //            textBox = p3;
        //            break;
        //        case "s4":
        //            textBox = p4;
        //            break;
        //        case "s5":
        //            textBox = p5;
        //            break;
        //        case "s6":
        //            textBox = p6;
        //            break;
        //        case "s7":
        //            textBox = p7;
        //            break;
        //        case "s8":
        //            textBox = p8;
        //            break;
        //    }

        //    if (comboBox.SelectedItem != null && textBox != null)
        //    {
        //        string selectedServiceName = comboBox.SelectedItem.ToString();
        //        string query = "SELECT sprice FROM Services WHERE sname = '" + selectedServiceName + "'";
        //        SqlDataReader dr = fn.getForCombo(query);
        //        if (dr.HasRows)
        //        {
        //            while (dr.Read())
        //            {
        //                textBox.Text = dr["sprice"].ToString();
        //            }
        //        }
        //        else
        //        {
        //            textBox.Text = "N/A";
        //        }
        //        dr.Close();
        //        //CalculateTotalPrice();
        //    }
        //}
        //--------------------------------------------------------------------------------------------------------
        //private void CalculateTotalPrice()
        //{
        //    int totalPrice = 0;
        //    Guna2TextBox[] textBoxes = { p1, p2, p3, p4, p5, p6, p7, p8 };

        //    foreach (Guna2TextBox textBox in textBoxes)
        //    {
        //        int price = 0;
        //        if (!string.IsNullOrEmpty(textBox.Text) && int.TryParse(textBox.Text, out price))
        //        {
        //            totalPrice += price;
        //        }
        //    }

        //    totalfee.Text = totalPrice.ToString();
        //}

        //-------------------------------------------------------------------------------------------------
        //private void CalculateTotalPrice()
        //{
        //    int[] prices = { 0, 0, 0, 0, 0, 0, 0, 0 };
        //    Guna2TextBox[] textBoxes = { p1, p2, p3, p4, p5, p6, p7, p8 };

        //    for (int i = 0; i < textBoxes.Length; i++)
        //    {
        //        int.TryParse(textBoxes[i].Text, out prices[i]);
        //    }

        //    totalPrice = prices.Sum();
        //    totalfee.Text = totalPrice.ToString();
        //}



        //------------------------------------------------------------------------------------------------

        //private void CalculateTotal(object sender, EventArgs e)
        //{
        //    float totalPrice = 0;

        //    // Duyệt qua 8 combobox và textbox
        //    for (int i = 1; i <= 8; i++)
        //    {
        //        // Lấy giá trị từ combobox
        //        string serviceName = $"s{i}".ToString();
        //        Guna2ComboBox comboBox = (Guna2ComboBox)this.Controls.Find(serviceName, true)[0];
        //        string selectedService = comboBox.Text;

        //        // Lấy giá trị từ textbox
        //        string priceText = $"p{i}".ToString();
        //        Guna2TextBox textBox = (Guna2TextBox)this.Controls.Find(priceText, true)[0];
        //        float price = float.Parse(textBox.Text);

        //        // Tính tổng tiền
        //        if (selectedService != "" && price > 0)
        //        {
        //            totalPrice += price;
        //        }
        //    }

        //    // Hiển thị tổng tiền lên textbox totalfee
        //    this.totalfee.Text = totalPrice.ToString("C2");
        //}



        //private void CalculateTotal(object sender, EventArgs e)
        //{
        //    float totalPrice = 0;

        //    // Duyệt qua 8 combobox và textbox
        //    for (int i = 1; i <= 8; i++)
        //    {
        //        // Lấy giá trị từ combobox
        //        string serviceName = $"s{i}".ToString();
        //        Guna2ComboBox comboBox = (Guna2ComboBox)this.Controls.Find(serviceName, true)[0];
        //        string selectedService = comboBox.Text;

        //        // Lấy giá trị từ textbox
        //        string priceText = $"p{i}".ToString();
        //        Guna2TextBox textBox = (Guna2TextBox)this.Controls.Find(priceText, true)[0];

        //        float price = 0;

        //        // Check if the text is a valid number using regular expression
        //        if (Regex.IsMatch(textBox.Text, @"^\d+(\.\d+)?$"))
        //        {
        //            price = float.Parse(textBox.Text);
        //        }
        //        else
        //        {
        //            // Handle the case where the text is not a number
        //            // You can display an error message to the user here
        //            MessageBox.Show("Vui lòng nhập số hợp lệ cho giá trong textbox " + priceText);
        //        }

        //        // Only add price to total if it was parsed successfully
        //        if (selectedService != "" && price > 0)
        //        {
        //            totalPrice += price;
        //        }
        //    }

        //    // Hiển thị tổng tiền lên textbox totalfee
        //    this.totalfee.Text = totalPrice.ToString("C2");
        //}

        //----------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------

        private void CalculateTotal(object sender, EventArgs e)
        {
            ////=============================================================================================================
            // Cách 2
            //totalPrice = 0; // Reset totalPrice
            float totalPrice = 0;
            // Duyệt qua 8 combobox và textbox
            for (int i = 1; i <= 8; i++)
            {
                // Lấy giá trị từ combobox
                string serviceName = $"s{i}".ToString();
                Guna2ComboBox comboBox = (Guna2ComboBox)this.Controls.Find(serviceName, true)[0];
                string selectedService = comboBox.Text;

                // Lấy giá trị từ textbox price
                string priceText = $"p{i}".ToString();
                Guna2TextBox priceTextBox = (Guna2TextBox)this.Controls.Find(priceText, true)[0];

                float price = 0;

                // Check if the text is empty or a valid number
                if (!string.IsNullOrEmpty(priceTextBox.Text) && Regex.IsMatch(priceTextBox.Text, @"^\d+(\.\d+)?$"))
                {
                    price = float.Parse(priceTextBox.Text);
                }
                else if (string.IsNullOrEmpty(priceTextBox.Text)) // Handle empty textbox
                {
                    // Optionally handle empty textboxes here, e.g., set price to 0
                    // price = 0; // Assuming empty textbox means no price
                }
                else // Handle invalid text (not empty or not a number)
                {
                    // Display error message (consider using a dedicated error message control)
                    MessageBox.Show("Vui lòng nhập số hợp lệ cho giá trong textbox " + priceText);
                }

                // Lấy giá trị từ textbox quantity
                string quantityText = $"q{i}".ToString();
                Guna2TextBox quantityTextBox = (Guna2TextBox)this.Controls.Find(quantityText, true)[0];
                int quantity = 0;

                // Check if the quantity is a valid number
                if (!string.IsNullOrEmpty(quantityTextBox.Text) && int.TryParse(quantityTextBox.Text, out quantity))
                {
                    // Tính giá trị tổng tiền cho từng sản phẩm
                    float totalPriceForProduct = price * quantity;
                    totalPrice += totalPriceForProduct;
                }
                else if (string.IsNullOrEmpty(quantityTextBox.Text)) // Handle empty textbox
                {
                    // Optionally handle empty quantity textboxes here
                }
                else // Handle invalid quantity
                {
                    // Display error message
                }
            }

            // Hiển thị tổng tiền lên textbox totalfee
            this.totalfee.Text = totalPrice.ToString();







            //// Cách 1
            //// Reset totalPrice
            //float totalPrice = 0;

            //// Duyệt qua 8 combobox và textbox
            //for (int i = 1; i <= 8; i++)
            //{
            //    // Lấy giá trị từ combobox
            //    string serviceName = $"s{i}".ToString();
            //    Guna2ComboBox comboBox = (Guna2ComboBox)this.Controls.Find(serviceName, true)[0];
            //    string selectedService = comboBox.Text;

            //    // Lấy giá trị từ textbox price
            //    string priceText = $"p{i}".ToString();
            //    Guna2TextBox priceTextBox = (Guna2TextBox)this.Controls.Find(priceText, true)[0];
            //    float price = 0;

            //    // Kiểm tra nếu giá trị từ textbox price là một số hợp lệ
            //    if (!string.IsNullOrEmpty(priceTextBox.Text) && Regex.IsMatch(priceTextBox.Text, @"^\d+(\.\d+)?$"))
            //    {
            //        price = float.Parse(priceTextBox.Text);
            //    }
            //    else if(string.IsNullOrEmpty(priceTextBox.Text)) // Xử lý khi textbox price trống
            //    {
            //        // Optionally handle empty price textboxes here
            //    }
            //    else // Xử lý khi giá trị từ textbox price không hợp lệ
            //    {
            //        // Hiển thị thông báo lỗi (có thể sử dụng một control thông báo lỗi riêng)
            //        MessageBox.Show("Vui lòng nhập số hợp lệ cho giá trong textbox " + priceText);
            //    }



            //    // Lấy giá trị từ textbox quantity
            //    string quantityText = $"q{i}".ToString();
            //    Guna2TextBox quantityTextBox = (Guna2TextBox)this.Controls.Find(quantityText, true)[0];
            //    int quantity = 0;

            //    // Kiểm tra nếu giá trị từ textbox quantity là một số hợp lệ
            //    if (!string.IsNullOrEmpty(quantityTextBox.Text) && int.TryParse(quantityTextBox.Text, out quantity))
            //    {
            //        // Tính giá trị tổng tiền cho từng sản phẩm
            //        float totalPriceForProduct = price * quantity;
            //        totalPrice += totalPriceForProduct;

            //        // Hiển thị giá trị tổng tiền cho mỗi sản phẩm lên các textbox p1, p2, ..., p8
            //        string totalPriceTextBoxName = $"p{i}".ToString();
            //        Guna2TextBox totalPriceTextBox = (Guna2TextBox)this.Controls.Find(totalPriceTextBoxName, true)[0];
            //        totalPriceTextBox.Text = totalPriceForProduct.ToString("C2");

            //    }
            //    else if (string.IsNullOrEmpty(quantityTextBox.Text)) // Xử lý khi textbox quantity trống
            //    {
            //        // Optionally handle empty quantity textboxes here
            //    }
            //    else // Xử lý khi giá trị từ textbox quantity không hợp lệ
            //    {
            //        // Hiển thị thông báo lỗi
            //    }



            //}


            ////Hiển thị tổng tiền lên textbox totalfee
            //this.totalfee.Text = totalPrice.ToString("C2");



            //-----------------------------------------------------------------------------------------------------------------------
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (totalfee.Text.Length > 0)
            {
                if (truyenData != null)
                    truyenData(totalfee.Text);
                MessageBox.Show("Select Services Successful");
            }
        }

        private void p8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void p7_TextChanged(object sender, EventArgs e)
        {

        }

        private void p6_TextChanged(object sender, EventArgs e)
        {

        }

        private void p5_TextChanged(object sender, EventArgs e)
        {

        }

        private void p4_TextChanged(object sender, EventArgs e)
        {

        }

        private void p3_TextChanged(object sender, EventArgs e)
        {

        }

        private void p2_TextChanged(object sender, EventArgs e)
        {

        }

        private void p1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            //UC_CustomerRegister uc = new UC_CustomerRegister();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


namespace HotelManagement
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmployeee = new Guna.UI2.WinForms.Guna2Button();
            this.btnBookingManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRegistion = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddroom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Employee1 = new HotelManagement.Controller.UC_Employee();
            this.uC_BookingManagement1 = new HotelManagement.Controller.UC_BookingManagement();
            this.uC_Payment1 = new HotelManagement.Controller.UC_Payment();
            this.uC_CustomerRegister1 = new HotelManagement.Controller.UC_CustomerRegister();
            this.uC_AddRoom1 = new HotelManagement.Controller.UC_AddRoom();
            this.uC_Services1 = new HotelManagement.Controller.UC_Services();
            this.btnServices = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(172)))), ((int)(((byte)(157)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnServices);
            this.panel1.Controls.Add(this.btnEmployeee);
            this.panel1.Controls.Add(this.btnBookingManagement);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.btnCustomerRegistion);
            this.panel1.Controls.Add(this.btnAddroom);
            this.panel1.Location = new System.Drawing.Point(81, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1764, 130);
            this.panel1.TabIndex = 1;
            // 
            // btnEmployeee
            // 
            this.btnEmployeee.BorderRadius = 5;
            this.btnEmployeee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployeee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployeee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployeee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(204)))), ((int)(((byte)(198)))));
            this.btnEmployeee.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeee.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeee.Location = new System.Drawing.Point(1517, 4);
            this.btnEmployeee.Name = "btnEmployeee";
            this.btnEmployeee.Size = new System.Drawing.Size(240, 116);
            this.btnEmployeee.TabIndex = 4;
            this.btnEmployeee.Text = "Employee";
            this.btnEmployeee.Click += new System.EventHandler(this.btnEmployeee_Click);
            // 
            // btnBookingManagement
            // 
            this.btnBookingManagement.BorderRadius = 5;
            this.btnBookingManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBookingManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookingManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookingManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookingManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookingManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(204)))), ((int)(((byte)(198)))));
            this.btnBookingManagement.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingManagement.ForeColor = System.Drawing.Color.Black;
            this.btnBookingManagement.Location = new System.Drawing.Point(909, 4);
            this.btnBookingManagement.Name = "btnBookingManagement";
            this.btnBookingManagement.Size = new System.Drawing.Size(240, 116);
            this.btnBookingManagement.TabIndex = 3;
            this.btnBookingManagement.Text = "Booking Management";
            this.btnBookingManagement.Click += new System.EventHandler(this.btnBookingManagement_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BorderRadius = 5;
            this.btnPayment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(204)))), ((int)(((byte)(198)))));
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Black;
            this.btnPayment.Location = new System.Drawing.Point(1215, 5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(240, 116);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Checkout";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnCustomerRegistion
            // 
            this.btnCustomerRegistion.BorderRadius = 5;
            this.btnCustomerRegistion.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRegistion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegistion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegistion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRegistion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRegistion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(204)))), ((int)(((byte)(198)))));
            this.btnCustomerRegistion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRegistion.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerRegistion.Location = new System.Drawing.Point(301, 4);
            this.btnCustomerRegistion.Name = "btnCustomerRegistion";
            this.btnCustomerRegistion.Size = new System.Drawing.Size(240, 116);
            this.btnCustomerRegistion.TabIndex = 1;
            this.btnCustomerRegistion.Text = "Customer Registration";
            this.btnCustomerRegistion.Click += new System.EventHandler(this.btnCustomerRegistion_Click);
            // 
            // btnAddroom
            // 
            this.btnAddroom.BorderRadius = 5;
            this.btnAddroom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddroom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(204)))), ((int)(((byte)(198)))));
            this.btnAddroom.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddroom.ForeColor = System.Drawing.Color.Black;
            this.btnAddroom.Location = new System.Drawing.Point(3, 5);
            this.btnAddroom.Name = "btnAddroom";
            this.btnAddroom.Size = new System.Drawing.Size(240, 116);
            this.btnAddroom.TabIndex = 0;
            this.btnAddroom.Text = "Room Management";
            this.btnAddroom.Click += new System.EventHandler(this.btnAddroom_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uC_Services1);
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.uC_BookingManagement1);
            this.panel2.Controls.Add(this.uC_Payment1);
            this.panel2.Controls.Add(this.uC_CustomerRegister1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(31, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1882, 854);
            this.panel2.TabIndex = 2;
            // 
            // PanelMoving
            // 
            this.PanelMoving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(117)))), ((int)(((byte)(103)))));
            this.PanelMoving.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PanelMoving.Location = new System.Drawing.Point(86, 148);
            this.PanelMoving.Name = "PanelMoving";
            this.PanelMoving.Size = new System.Drawing.Size(240, 7);
            this.PanelMoving.TabIndex = 3;
            this.PanelMoving.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMoving_Paint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 5;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 5;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 5;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 5;
            this.guna2Elipse5.TargetControl = this;
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(172)))), ((int)(((byte)(157)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(5, 56);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(43, 38);
            this.guna2Button2.TabIndex = 0;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 5;
            this.guna2Elipse6.TargetControl = this;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Location = new System.Drawing.Point(0, 1);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1878, 848);
            this.uC_Employee1.TabIndex = 4;
            // 
            // uC_BookingManagement1
            // 
            this.uC_BookingManagement1.BackColor = System.Drawing.Color.White;
            this.uC_BookingManagement1.Location = new System.Drawing.Point(1, 2);
            this.uC_BookingManagement1.Name = "uC_BookingManagement1";
            this.uC_BookingManagement1.Size = new System.Drawing.Size(1878, 848);
            this.uC_BookingManagement1.TabIndex = 3;
            // 
            // uC_Payment1
            // 
            this.uC_Payment1.BackColor = System.Drawing.Color.White;
            this.uC_Payment1.ForeColor = System.Drawing.Color.Black;
            this.uC_Payment1.Location = new System.Drawing.Point(0, 1);
            this.uC_Payment1.Name = "uC_Payment1";
            this.uC_Payment1.Size = new System.Drawing.Size(1878, 848);
            this.uC_Payment1.TabIndex = 2;
            // 
            // uC_CustomerRegister1
            // 
            this.uC_CustomerRegister1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRegister1.Location = new System.Drawing.Point(-1, 1);
            this.uC_CustomerRegister1.Name = "uC_CustomerRegister1";
            this.uC_CustomerRegister1.Size = new System.Drawing.Size(1878, 848);
            this.uC_CustomerRegister1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_AddRoom1.Location = new System.Drawing.Point(-1, 0);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1878, 848);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // uC_Services1
            // 
            this.uC_Services1.BackColor = System.Drawing.Color.White;
            this.uC_Services1.Location = new System.Drawing.Point(0, 0);
            this.uC_Services1.Name = "uC_Services1";
            this.uC_Services1.Size = new System.Drawing.Size(1878, 848);
            this.uC_Services1.TabIndex = 5;
            // 
            // btnServices
            // 
            this.btnServices.BorderRadius = 5;
            this.btnServices.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnServices.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServices.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServices.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServices.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(204)))), ((int)(((byte)(198)))));
            this.btnServices.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.Color.Black;
            this.btnServices.Location = new System.Drawing.Point(602, 5);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(240, 116);
            this.btnServices.TabIndex = 5;
            this.btnServices.Text = "Services";
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(172)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.PanelMoving);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAddroom;
        private Guna.UI2.WinForms.Guna2Button btnEmployeee;
        private Guna.UI2.WinForms.Guna2Button btnBookingManagement;
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegistion;
        private Guna.UI2.WinForms.Guna2Panel PanelMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Controller.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Controller.UC_CustomerRegister uC_CustomerRegister1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Controller.UC_Payment uC_Payment1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Controller.UC_BookingManagement uC_BookingManagement1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Controller.UC_Employee uC_Employee1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Controller.UC_Services uC_Services1;
        private Guna.UI2.WinForms.Guna2Button btnServices;
    }
}
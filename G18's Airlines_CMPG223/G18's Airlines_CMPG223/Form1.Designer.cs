
namespace G18_s_Airlines_CMPG223
{
    partial class Form1
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
            this.FlightsTab = new System.Windows.Forms.TabControl();
            this.ViewFlights = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComboBox_BookingNumber = new System.Windows.Forms.ComboBox();
            this.Btn_DeleteBooking = new System.Windows.Forms.Button();
            this.BtnMakeBooking = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBox_Flights = new System.Windows.Forms.ComboBox();
            this.Btn_AddFlights = new System.Windows.Forms.Button();
            this.Btn_DeleteFlights = new System.Windows.Forms.Button();
            this.DG_Bookings = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_View = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.FlightsTab.SuspendLayout();
            this.ViewFlights.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Bookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_View)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightsTab
            // 
            this.FlightsTab.Controls.Add(this.ViewFlights);
            this.FlightsTab.Controls.Add(this.tabPage2);
            this.FlightsTab.Location = new System.Drawing.Point(12, 12);
            this.FlightsTab.Name = "FlightsTab";
            this.FlightsTab.SelectedIndex = 0;
            this.FlightsTab.Size = new System.Drawing.Size(2028, 940);
            this.FlightsTab.TabIndex = 0;
            // 
            // ViewFlights
            // 
            this.ViewFlights.Controls.Add(this.groupBox2);
            this.ViewFlights.Controls.Add(this.groupBox1);
            this.ViewFlights.Controls.Add(this.DG_Bookings);
            this.ViewFlights.Controls.Add(this.label2);
            this.ViewFlights.Controls.Add(this.label1);
            this.ViewFlights.Controls.Add(this.DG_View);
            this.ViewFlights.Location = new System.Drawing.Point(4, 22);
            this.ViewFlights.Name = "ViewFlights";
            this.ViewFlights.Padding = new System.Windows.Forms.Padding(3);
            this.ViewFlights.Size = new System.Drawing.Size(2020, 914);
            this.ViewFlights.TabIndex = 0;
            this.ViewFlights.Text = "View Flights";
            this.ViewFlights.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ComboBox_BookingNumber);
            this.groupBox2.Controls.Add(this.Btn_DeleteBooking);
            this.groupBox2.Controls.Add(this.BtnMakeBooking);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1367, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 291);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bookings:";
            // 
            // ComboBox_BookingNumber
            // 
            this.ComboBox_BookingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_BookingNumber.FormattingEnabled = true;
            this.ComboBox_BookingNumber.Location = new System.Drawing.Point(6, 40);
            this.ComboBox_BookingNumber.Name = "ComboBox_BookingNumber";
            this.ComboBox_BookingNumber.Size = new System.Drawing.Size(149, 28);
            this.ComboBox_BookingNumber.TabIndex = 7;
            // 
            // Btn_DeleteBooking
            // 
            this.Btn_DeleteBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteBooking.Location = new System.Drawing.Point(6, 97);
            this.Btn_DeleteBooking.Name = "Btn_DeleteBooking";
            this.Btn_DeleteBooking.Size = new System.Drawing.Size(109, 53);
            this.Btn_DeleteBooking.TabIndex = 9;
            this.Btn_DeleteBooking.Text = "Delete Booking";
            this.Btn_DeleteBooking.UseVisualStyleBackColor = true;
            this.Btn_DeleteBooking.Click += new System.EventHandler(this.Btn_DeleteBooking_Click);
            // 
            // BtnMakeBooking
            // 
            this.BtnMakeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMakeBooking.Location = new System.Drawing.Point(6, 198);
            this.BtnMakeBooking.Name = "BtnMakeBooking";
            this.BtnMakeBooking.Size = new System.Drawing.Size(109, 53);
            this.BtnMakeBooking.TabIndex = 3;
            this.BtnMakeBooking.Text = "MakeBooking";
            this.BtnMakeBooking.UseVisualStyleBackColor = true;
            this.BtnMakeBooking.Click += new System.EventHandler(this.BtnMakeBooking_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBox_Flights);
            this.groupBox1.Controls.Add(this.Btn_AddFlights);
            this.groupBox1.Controls.Add(this.Btn_DeleteFlights);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 282);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flights:";
            // 
            // ComboBox_Flights
            // 
            this.ComboBox_Flights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Flights.FormattingEnabled = true;
            this.ComboBox_Flights.Location = new System.Drawing.Point(6, 40);
            this.ComboBox_Flights.Name = "ComboBox_Flights";
            this.ComboBox_Flights.Size = new System.Drawing.Size(149, 28);
            this.ComboBox_Flights.TabIndex = 2;
            // 
            // Btn_AddFlights
            // 
            this.Btn_AddFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddFlights.Location = new System.Drawing.Point(6, 196);
            this.Btn_AddFlights.Name = "Btn_AddFlights";
            this.Btn_AddFlights.Size = new System.Drawing.Size(93, 54);
            this.Btn_AddFlights.TabIndex = 5;
            this.Btn_AddFlights.Text = "Add Flights";
            this.Btn_AddFlights.UseVisualStyleBackColor = true;
            this.Btn_AddFlights.Click += new System.EventHandler(this.Btn_AddFlights_Click);
            // 
            // Btn_DeleteFlights
            // 
            this.Btn_DeleteFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteFlights.Location = new System.Drawing.Point(6, 95);
            this.Btn_DeleteFlights.Name = "Btn_DeleteFlights";
            this.Btn_DeleteFlights.Size = new System.Drawing.Size(93, 54);
            this.Btn_DeleteFlights.TabIndex = 6;
            this.Btn_DeleteFlights.Text = "Delete Flights";
            this.Btn_DeleteFlights.UseVisualStyleBackColor = true;
            this.Btn_DeleteFlights.Click += new System.EventHandler(this.Btn_DeleteFlights_Click);
            // 
            // DG_Bookings
            // 
            this.DG_Bookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Bookings.Location = new System.Drawing.Point(1456, 415);
            this.DG_Bookings.Name = "DG_Bookings";
            this.DG_Bookings.Size = new System.Drawing.Size(444, 412);
            this.DG_Bookings.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1452, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "All Bookings:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Flights:";
            // 
            // DG_View
            // 
            this.DG_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_View.Location = new System.Drawing.Point(16, 415);
            this.DG_View.Name = "DG_View";
            this.DG_View.Size = new System.Drawing.Size(820, 412);
            this.DG_View.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnLogin);
            this.tabPage2.Controls.Add(this.BtnClear);
            this.tabPage2.Controls.Add(this.Txt_Password);
            this.tabPage2.Controls.Add(this.Txt_UserName);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2020, 914);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin/Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(346, 386);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 31);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(524, 386);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 31);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(346, 328);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(253, 26);
            this.Txt_Password.TabIndex = 4;
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UserName.Location = new System.Drawing.Point(346, 265);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(253, 26);
            this.Txt_UserName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Admin/Management Login:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2052, 973);
            this.Controls.Add(this.FlightsTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FlightsTab.ResumeLayout(false);
            this.ViewFlights.ResumeLayout(false);
            this.ViewFlights.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Bookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_View)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FlightsTab;
        private System.Windows.Forms.TabPage ViewFlights;
        private System.Windows.Forms.DataGridView DG_View;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_Flights;
        private System.Windows.Forms.Button BtnMakeBooking;
        private System.Windows.Forms.Button Btn_DeleteFlights;
        private System.Windows.Forms.Button Btn_AddFlights;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DG_Bookings;
        private System.Windows.Forms.Button Btn_DeleteBooking;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ComboBox_BookingNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}


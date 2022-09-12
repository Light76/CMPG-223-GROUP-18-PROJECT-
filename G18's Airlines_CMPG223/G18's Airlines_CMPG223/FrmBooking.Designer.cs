
namespace G18_s_Airlines_CMPG223
{
    partial class FrmBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.Dg_Bookings = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_BookingNumber = new System.Windows.Forms.TextBox();
            this.Txt_MemberID = new System.Windows.Forms.TextBox();
            this.Txt_FLNumber = new System.Windows.Forms.TextBox();
            this.Txt_BookingDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Booking = new System.Windows.Forms.Button();
            this.ErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Bookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Booking:";
            // 
            // Dg_Bookings
            // 
            this.Dg_Bookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Bookings.Location = new System.Drawing.Point(730, 181);
            this.Dg_Bookings.Name = "Dg_Bookings";
            this.Dg_Bookings.Size = new System.Drawing.Size(461, 325);
            this.Dg_Bookings.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Booking Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Member ID, If Member:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Booking Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Flight Number:";
            // 
            // Txt_BookingNumber
            // 
            this.Txt_BookingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BookingNumber.Location = new System.Drawing.Point(326, 181);
            this.Txt_BookingNumber.Name = "Txt_BookingNumber";
            this.Txt_BookingNumber.Size = new System.Drawing.Size(203, 26);
            this.Txt_BookingNumber.TabIndex = 6;
            this.Txt_BookingNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_MemberID
            // 
            this.Txt_MemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_MemberID.Location = new System.Drawing.Point(326, 272);
            this.Txt_MemberID.Name = "Txt_MemberID";
            this.Txt_MemberID.Size = new System.Drawing.Size(203, 26);
            this.Txt_MemberID.TabIndex = 7;
            this.Txt_MemberID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_FLNumber
            // 
            this.Txt_FLNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FLNumber.Location = new System.Drawing.Point(326, 366);
            this.Txt_FLNumber.Name = "Txt_FLNumber";
            this.Txt_FLNumber.Size = new System.Drawing.Size(203, 26);
            this.Txt_FLNumber.TabIndex = 8;
            this.Txt_FLNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_BookingDate
            // 
            this.Txt_BookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BookingDate.Location = new System.Drawing.Point(326, 451);
            this.Txt_BookingDate.Name = "Txt_BookingDate";
            this.Txt_BookingDate.Size = new System.Drawing.Size(203, 26);
            this.Txt_BookingDate.TabIndex = 9;
            this.Txt_BookingDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(726, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "All Bookings:";
            // 
            // Btn_Booking
            // 
            this.Btn_Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Booking.Location = new System.Drawing.Point(317, 542);
            this.Btn_Booking.Name = "Btn_Booking";
            this.Btn_Booking.Size = new System.Drawing.Size(104, 56);
            this.Btn_Booking.TabIndex = 11;
            this.Btn_Booking.Text = "Make Booking";
            this.Btn_Booking.UseVisualStyleBackColor = true;
            this.Btn_Booking.Click += new System.EventHandler(this.Btn_Booking_Click);
            // 
            // ErrProvider
            // 
            this.ErrProvider.ContainerControl = this;
            // 
            // FrmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 835);
            this.Controls.Add(this.Btn_Booking);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_BookingDate);
            this.Controls.Add(this.Txt_FLNumber);
            this.Controls.Add(this.Txt_MemberID);
            this.Controls.Add(this.Txt_BookingNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dg_Bookings);
            this.Controls.Add(this.label1);
            this.Name = "FrmBooking";
            this.Text = "FrmBooking";
            this.Load += new System.EventHandler(this.FrmBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Bookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dg_Bookings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_BookingNumber;
        private System.Windows.Forms.TextBox Txt_MemberID;
        private System.Windows.Forms.TextBox Txt_FLNumber;
        private System.Windows.Forms.TextBox Txt_BookingDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Booking;
        private System.Windows.Forms.ErrorProvider ErrProvider;
    }
}
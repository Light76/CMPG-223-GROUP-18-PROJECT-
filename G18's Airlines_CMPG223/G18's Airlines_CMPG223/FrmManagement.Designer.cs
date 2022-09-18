
namespace G18_s_Airlines_CMPG223
{
    partial class FrmManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Members = new System.Windows.Forms.GroupBox();
            this.DG_Flights = new System.Windows.Forms.DataGridView();
            this.BtnDeleteFlight = new System.Windows.Forms.Button();
            this.CB_Flights = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_Booking = new System.Windows.Forms.DataGridView();
            this.CB_Booking = new System.Windows.Forms.ComboBox();
            this.Btn_DeleteBooking = new System.Windows.Forms.Button();
            this.DG_Member = new System.Windows.Forms.DataGridView();
            this.CB_Members = new System.Windows.Forms.ComboBox();
            this.Btn_DeleteMembers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Members.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Flights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Booking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Member)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_Flights);
            this.groupBox1.Controls.Add(this.BtnDeleteFlight);
            this.groupBox1.Controls.Add(this.DG_Flights);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1242, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flights";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_DeleteBooking);
            this.groupBox2.Controls.Add(this.CB_Booking);
            this.groupBox2.Controls.Add(this.DG_Booking);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 569);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 380);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bookings";
            // 
            // Members
            // 
            this.Members.Controls.Add(this.Btn_DeleteMembers);
            this.Members.Controls.Add(this.CB_Members);
            this.Members.Controls.Add(this.DG_Member);
            this.Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Members.Location = new System.Drawing.Point(953, 552);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(655, 397);
            this.Members.TabIndex = 1;
            this.Members.TabStop = false;
            this.Members.Text = "Members";
            // 
            // DG_Flights
            // 
            this.DG_Flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Flights.Location = new System.Drawing.Point(6, 42);
            this.DG_Flights.Name = "DG_Flights";
            this.DG_Flights.Size = new System.Drawing.Size(1230, 264);
            this.DG_Flights.TabIndex = 0;
            // 
            // BtnDeleteFlight
            // 
            this.BtnDeleteFlight.Location = new System.Drawing.Point(6, 395);
            this.BtnDeleteFlight.Name = "BtnDeleteFlight";
            this.BtnDeleteFlight.Size = new System.Drawing.Size(135, 42);
            this.BtnDeleteFlight.TabIndex = 1;
            this.BtnDeleteFlight.Text = "Delete Flight";
            this.BtnDeleteFlight.UseVisualStyleBackColor = true;
            this.BtnDeleteFlight.Click += new System.EventHandler(this.BtnDeleteFlight_Click);
            // 
            // CB_Flights
            // 
            this.CB_Flights.FormattingEnabled = true;
            this.CB_Flights.Location = new System.Drawing.Point(7, 333);
            this.CB_Flights.Name = "CB_Flights";
            this.CB_Flights.Size = new System.Drawing.Size(171, 28);
            this.CB_Flights.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Management Page:";
            // 
            // DG_Booking
            // 
            this.DG_Booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Booking.Location = new System.Drawing.Point(6, 25);
            this.DG_Booking.Name = "DG_Booking";
            this.DG_Booking.Size = new System.Drawing.Size(761, 264);
            this.DG_Booking.TabIndex = 3;
            // 
            // CB_Booking
            // 
            this.CB_Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Booking.FormattingEnabled = true;
            this.CB_Booking.Location = new System.Drawing.Point(6, 299);
            this.CB_Booking.Name = "CB_Booking";
            this.CB_Booking.Size = new System.Drawing.Size(171, 28);
            this.CB_Booking.TabIndex = 3;
            // 
            // Btn_DeleteBooking
            // 
            this.Btn_DeleteBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteBooking.Location = new System.Drawing.Point(6, 333);
            this.Btn_DeleteBooking.Name = "Btn_DeleteBooking";
            this.Btn_DeleteBooking.Size = new System.Drawing.Size(135, 42);
            this.Btn_DeleteBooking.TabIndex = 3;
            this.Btn_DeleteBooking.Text = "Delete Booking";
            this.Btn_DeleteBooking.UseVisualStyleBackColor = true;
            this.Btn_DeleteBooking.Click += new System.EventHandler(this.Btn_DeleteBooking_Click);
            // 
            // DG_Member
            // 
            this.DG_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Member.Location = new System.Drawing.Point(6, 25);
            this.DG_Member.Name = "DG_Member";
            this.DG_Member.Size = new System.Drawing.Size(643, 264);
            this.DG_Member.TabIndex = 4;
            // 
            // CB_Members
            // 
            this.CB_Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Members.FormattingEnabled = true;
            this.CB_Members.Location = new System.Drawing.Point(6, 304);
            this.CB_Members.Name = "CB_Members";
            this.CB_Members.Size = new System.Drawing.Size(171, 28);
            this.CB_Members.TabIndex = 4;
            // 
            // Btn_DeleteMembers
            // 
            this.Btn_DeleteMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteMembers.Location = new System.Drawing.Point(6, 349);
            this.Btn_DeleteMembers.Name = "Btn_DeleteMembers";
            this.Btn_DeleteMembers.Size = new System.Drawing.Size(135, 42);
            this.Btn_DeleteMembers.TabIndex = 4;
            this.Btn_DeleteMembers.Text = "Delete Members";
            this.Btn_DeleteMembers.UseVisualStyleBackColor = true;
            this.Btn_DeleteMembers.Click += new System.EventHandler(this.Btn_DeleteMembers_Click);
            // 
            // FrmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2074, 986);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmManagement";
            this.Text = "FrmManagement";
            this.Load += new System.EventHandler(this.FrmManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.Members.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Flights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Booking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Member)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Members;
        private System.Windows.Forms.Button BtnDeleteFlight;
        private System.Windows.Forms.DataGridView DG_Flights;
        private System.Windows.Forms.ComboBox CB_Flights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_DeleteBooking;
        private System.Windows.Forms.ComboBox CB_Booking;
        private System.Windows.Forms.DataGridView DG_Booking;
        private System.Windows.Forms.Button Btn_DeleteMembers;
        private System.Windows.Forms.ComboBox CB_Members;
        private System.Windows.Forms.DataGridView DG_Member;
    }
}
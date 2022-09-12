
namespace G18_s_Airlines_CMPG223
{
    partial class FrmAddFlight
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_FlightNumber = new System.Windows.Forms.TextBox();
            this.Txt_DestinationID = new System.Windows.Forms.TextBox();
            this.Txt_DepartureDate = new System.Windows.Forms.TextBox();
            this.Txt_PlaneNumber = new System.Windows.Forms.TextBox();
            this.Txt_GateNumber = new System.Windows.Forms.TextBox();
            this.Txt_Status = new System.Windows.Forms.TextBox();
            this.Txt_Price = new System.Windows.Forms.TextBox();
            this.Btn_InsertFlight = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plane Number:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gate Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 635);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Add New Flight";
            // 
            // Txt_FlightNumber
            // 
            this.Txt_FlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FlightNumber.Location = new System.Drawing.Point(311, 153);
            this.Txt_FlightNumber.Name = "Txt_FlightNumber";
            this.Txt_FlightNumber.Size = new System.Drawing.Size(320, 26);
            this.Txt_FlightNumber.TabIndex = 8;
            this.Txt_FlightNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_DestinationID
            // 
            this.Txt_DestinationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DestinationID.Location = new System.Drawing.Point(311, 236);
            this.Txt_DestinationID.Name = "Txt_DestinationID";
            this.Txt_DestinationID.Size = new System.Drawing.Size(320, 26);
            this.Txt_DestinationID.TabIndex = 9;
            this.Txt_DestinationID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_DepartureDate
            // 
            this.Txt_DepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DepartureDate.Location = new System.Drawing.Point(311, 313);
            this.Txt_DepartureDate.Name = "Txt_DepartureDate";
            this.Txt_DepartureDate.Size = new System.Drawing.Size(320, 26);
            this.Txt_DepartureDate.TabIndex = 10;
            this.Txt_DepartureDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_PlaneNumber
            // 
            this.Txt_PlaneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PlaneNumber.Location = new System.Drawing.Point(311, 402);
            this.Txt_PlaneNumber.Name = "Txt_PlaneNumber";
            this.Txt_PlaneNumber.Size = new System.Drawing.Size(320, 26);
            this.Txt_PlaneNumber.TabIndex = 11;
            this.Txt_PlaneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_GateNumber
            // 
            this.Txt_GateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_GateNumber.Location = new System.Drawing.Point(311, 481);
            this.Txt_GateNumber.Name = "Txt_GateNumber";
            this.Txt_GateNumber.Size = new System.Drawing.Size(320, 26);
            this.Txt_GateNumber.TabIndex = 12;
            this.Txt_GateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_Status
            // 
            this.Txt_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Status.Location = new System.Drawing.Point(311, 556);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Size = new System.Drawing.Size(320, 26);
            this.Txt_Status.TabIndex = 13;
            this.Txt_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_Price
            // 
            this.Txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Price.Location = new System.Drawing.Point(311, 629);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.Size = new System.Drawing.Size(320, 26);
            this.Txt_Price.TabIndex = 14;
            this.Txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_InsertFlight
            // 
            this.Btn_InsertFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_InsertFlight.Location = new System.Drawing.Point(311, 740);
            this.Btn_InsertFlight.Name = "Btn_InsertFlight";
            this.Btn_InsertFlight.Size = new System.Drawing.Size(116, 60);
            this.Btn_InsertFlight.TabIndex = 15;
            this.Btn_InsertFlight.Text = "Add New Flight";
            this.Btn_InsertFlight.UseVisualStyleBackColor = true;
            this.Btn_InsertFlight.Click += new System.EventHandler(this.Btn_InsertFlight_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FrmAddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 856);
            this.Controls.Add(this.Btn_InsertFlight);
            this.Controls.Add(this.Txt_Price);
            this.Controls.Add(this.Txt_Status);
            this.Controls.Add(this.Txt_GateNumber);
            this.Controls.Add(this.Txt_PlaneNumber);
            this.Controls.Add(this.Txt_DepartureDate);
            this.Controls.Add(this.Txt_DestinationID);
            this.Controls.Add(this.Txt_FlightNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddFlight";
            this.Text = "FrmAddFlight";
            this.Load += new System.EventHandler(this.FrmAddFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_FlightNumber;
        private System.Windows.Forms.TextBox Txt_DestinationID;
        private System.Windows.Forms.TextBox Txt_DepartureDate;
        private System.Windows.Forms.TextBox Txt_PlaneNumber;
        private System.Windows.Forms.TextBox Txt_GateNumber;
        private System.Windows.Forms.TextBox Txt_Status;
        private System.Windows.Forms.TextBox Txt_Price;
        private System.Windows.Forms.Button Btn_InsertFlight;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}
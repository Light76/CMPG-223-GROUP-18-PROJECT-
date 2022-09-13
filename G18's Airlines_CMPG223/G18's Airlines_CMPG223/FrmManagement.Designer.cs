
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DG_Flights = new System.Windows.Forms.DataGridView();
            this.BtnDeleteFlight = new System.Windows.Forms.Button();
            this.CB_Flights = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Flights)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(19, 569);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 380);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(953, 569);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 380);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
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
            this.BtnDeleteFlight.Text = "DeleteFlight";
            this.BtnDeleteFlight.UseVisualStyleBackColor = true;
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
            // FrmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2074, 986);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmManagement";
            this.Text = "FrmManagement";
            this.Load += new System.EventHandler(this.FrmManagement_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Flights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnDeleteFlight;
        private System.Windows.Forms.DataGridView DG_Flights;
        private System.Windows.Forms.ComboBox CB_Flights;
        private System.Windows.Forms.Label label1;
    }
}
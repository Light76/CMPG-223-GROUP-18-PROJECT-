
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
            this.Btn_DeleteFlights = new System.Windows.Forms.Button();
            this.Btn_AddFlights = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_No = new System.Windows.Forms.RadioButton();
            this.RB_Yes = new System.Windows.Forms.RadioButton();
            this.BtnMakeBooking = new System.Windows.Forms.Button();
            this.ComboBox_Flights = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_View = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.FlightsTab.SuspendLayout();
            this.ViewFlights.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_View)).BeginInit();
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
            this.ViewFlights.Controls.Add(this.Btn_DeleteFlights);
            this.ViewFlights.Controls.Add(this.Btn_AddFlights);
            this.ViewFlights.Controls.Add(this.groupBox1);
            this.ViewFlights.Controls.Add(this.ComboBox_Flights);
            this.ViewFlights.Controls.Add(this.label1);
            this.ViewFlights.Controls.Add(this.DG_View);
            this.ViewFlights.Location = new System.Drawing.Point(4, 22);
            this.ViewFlights.Name = "ViewFlights";
            this.ViewFlights.Padding = new System.Windows.Forms.Padding(3);
            this.ViewFlights.Size = new System.Drawing.Size(2020, 914);
            this.ViewFlights.TabIndex = 0;
            this.ViewFlights.Text = "tabPage1";
            this.ViewFlights.UseVisualStyleBackColor = true;
            // 
            // Btn_DeleteFlights
            // 
            this.Btn_DeleteFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteFlights.Location = new System.Drawing.Point(186, 625);
            this.Btn_DeleteFlights.Name = "Btn_DeleteFlights";
            this.Btn_DeleteFlights.Size = new System.Drawing.Size(93, 54);
            this.Btn_DeleteFlights.TabIndex = 6;
            this.Btn_DeleteFlights.Text = "Delete Flights";
            this.Btn_DeleteFlights.UseVisualStyleBackColor = true;
            this.Btn_DeleteFlights.Click += new System.EventHandler(this.Btn_DeleteFlights_Click);
            // 
            // Btn_AddFlights
            // 
            this.Btn_AddFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddFlights.Location = new System.Drawing.Point(57, 625);
            this.Btn_AddFlights.Name = "Btn_AddFlights";
            this.Btn_AddFlights.Size = new System.Drawing.Size(93, 54);
            this.Btn_AddFlights.TabIndex = 5;
            this.Btn_AddFlights.Text = "Add Flights";
            this.Btn_AddFlights.UseVisualStyleBackColor = true;
            this.Btn_AddFlights.Click += new System.EventHandler(this.Btn_AddFlights_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_No);
            this.groupBox1.Controls.Add(this.RB_Yes);
            this.groupBox1.Controls.Add(this.BtnMakeBooking);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(826, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 227);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Become Member?";
            // 
            // RB_No
            // 
            this.RB_No.AutoSize = true;
            this.RB_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_No.Location = new System.Drawing.Point(6, 100);
            this.RB_No.Name = "RB_No";
            this.RB_No.Size = new System.Drawing.Size(47, 24);
            this.RB_No.TabIndex = 1;
            this.RB_No.TabStop = true;
            this.RB_No.Text = "No";
            this.RB_No.UseVisualStyleBackColor = true;
            this.RB_No.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RB_Yes
            // 
            this.RB_Yes.AutoSize = true;
            this.RB_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Yes.Location = new System.Drawing.Point(6, 48);
            this.RB_Yes.Name = "RB_Yes";
            this.RB_Yes.Size = new System.Drawing.Size(55, 24);
            this.RB_Yes.TabIndex = 0;
            this.RB_Yes.TabStop = true;
            this.RB_Yes.Text = "Yes";
            this.RB_Yes.UseVisualStyleBackColor = true;
            // 
            // BtnMakeBooking
            // 
            this.BtnMakeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMakeBooking.Location = new System.Drawing.Point(6, 157);
            this.BtnMakeBooking.Name = "BtnMakeBooking";
            this.BtnMakeBooking.Size = new System.Drawing.Size(109, 53);
            this.BtnMakeBooking.TabIndex = 3;
            this.BtnMakeBooking.Text = "MakeBooking";
            this.BtnMakeBooking.UseVisualStyleBackColor = true;
            // 
            // ComboBox_Flights
            // 
            this.ComboBox_Flights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Flights.FormattingEnabled = true;
            this.ComboBox_Flights.Location = new System.Drawing.Point(826, 169);
            this.ComboBox_Flights.Name = "ComboBox_Flights";
            this.ComboBox_Flights.Size = new System.Drawing.Size(149, 28);
            this.ComboBox_Flights.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Flights";
            // 
            // DG_View
            // 
            this.DG_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_View.Location = new System.Drawing.Point(57, 169);
            this.DG_View.Name = "DG_View";
            this.DG_View.Size = new System.Drawing.Size(733, 412);
            this.DG_View.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2020, 914);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_View)).EndInit();
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FlightsTab;
        private System.Windows.Forms.TabPage ViewFlights;
        private System.Windows.Forms.DataGridView DG_View;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_Flights;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_No;
        private System.Windows.Forms.RadioButton RB_Yes;
        private System.Windows.Forms.Button BtnMakeBooking;
        private System.Windows.Forms.Button Btn_DeleteFlights;
        private System.Windows.Forms.Button Btn_AddFlights;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}


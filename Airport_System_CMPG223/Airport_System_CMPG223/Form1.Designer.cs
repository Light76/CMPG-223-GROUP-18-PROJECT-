
namespace Airport_System_CMPG223
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
            this.MakeBookings = new System.Windows.Forms.TabControl();
            this.Book = new System.Windows.Forms.TabPage();
            this.DG_View = new System.Windows.Forms.DataGridView();
            this.SearchBooking = new System.Windows.Forms.TabPage();
            this.Available_Fligts = new System.Windows.Forms.Label();
            this.MakeBookings.SuspendLayout();
            this.Book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_View)).BeginInit();
            this.SuspendLayout();
            // 
            // MakeBookings
            // 
            this.MakeBookings.Controls.Add(this.Book);
            this.MakeBookings.Controls.Add(this.SearchBooking);
            this.MakeBookings.Location = new System.Drawing.Point(12, 12);
            this.MakeBookings.Name = "MakeBookings";
            this.MakeBookings.SelectedIndex = 0;
            this.MakeBookings.Size = new System.Drawing.Size(2054, 956);
            this.MakeBookings.TabIndex = 0;
            // 
            // Book
            // 
            this.Book.Controls.Add(this.Available_Fligts);
            this.Book.Controls.Add(this.DG_View);
            this.Book.Location = new System.Drawing.Point(4, 22);
            this.Book.Name = "Book";
            this.Book.Padding = new System.Windows.Forms.Padding(3);
            this.Book.Size = new System.Drawing.Size(2046, 930);
            this.Book.TabIndex = 0;
            this.Book.Text = "tabPage1";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // DG_View
            // 
            this.DG_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_View.Location = new System.Drawing.Point(50, 415);
            this.DG_View.Name = "DG_View";
            this.DG_View.Size = new System.Drawing.Size(840, 425);
            this.DG_View.TabIndex = 0;
            // 
            // SearchBooking
            // 
            this.SearchBooking.Location = new System.Drawing.Point(4, 22);
            this.SearchBooking.Name = "SearchBooking";
            this.SearchBooking.Padding = new System.Windows.Forms.Padding(3);
            this.SearchBooking.Size = new System.Drawing.Size(2046, 930);
            this.SearchBooking.TabIndex = 1;
            this.SearchBooking.Text = "tabPage2";
            this.SearchBooking.UseVisualStyleBackColor = true;
            // 
            // Available_Fligts
            // 
            this.Available_Fligts.AutoSize = true;
            this.Available_Fligts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available_Fligts.Location = new System.Drawing.Point(54, 387);
            this.Available_Fligts.Name = "Available_Fligts";
            this.Available_Fligts.Size = new System.Drawing.Size(154, 25);
            this.Available_Fligts.TabIndex = 1;
            this.Available_Fligts.Text = "Available Flights";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2078, 989);
            this.Controls.Add(this.MakeBookings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MakeBookings.ResumeLayout(false);
            this.Book.ResumeLayout(false);
            this.Book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MakeBookings;
        private System.Windows.Forms.TabPage Book;
        private System.Windows.Forms.TabPage SearchBooking;
        private System.Windows.Forms.DataGridView DG_View;
        private System.Windows.Forms.Label Available_Fligts;
    }
}


namespace QL_QuanAn
{
    partial class Form_ThuNgan
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
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbmFood = new System.Windows.Forms.ComboBox();
            this.cbmFoodCategory = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cbmSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 25);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(511, 403);
            this.flpTable.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.cbmFood);
            this.panel4.Controls.Add(this.cbmFoodCategory);
            this.panel4.Location = new System.Drawing.Point(529, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 56);
            this.panel4.TabIndex = 25;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(272, 20);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(43, 20);
            this.nmFoodCount.TabIndex = 2;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(190, 5);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(76, 46);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // cbmFood
            // 
            this.cbmFood.FormattingEnabled = true;
            this.cbmFood.Location = new System.Drawing.Point(9, 32);
            this.cbmFood.Name = "cbmFood";
            this.cbmFood.Size = new System.Drawing.Size(175, 21);
            this.cbmFood.TabIndex = 0;
            // 
            // cbmFoodCategory
            // 
            this.cbmFoodCategory.FormattingEnabled = true;
            this.cbmFoodCategory.Location = new System.Drawing.Point(9, 5);
            this.cbmFoodCategory.Name = "cbmFoodCategory";
            this.cbmFoodCategory.Size = new System.Drawing.Size(175, 21);
            this.cbmFoodCategory.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.cbmSwitchTable);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Location = new System.Drawing.Point(529, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 65);
            this.panel3.TabIndex = 24;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(178, 11);
            this.nmDiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(66, 20);
            this.nmDiscount.TabIndex = 2;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtTotalPrice.Location = new System.Drawing.Point(102, 41);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(142, 20);
            this.txtTotalPrice.TabIndex = 2;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbmSwitchTable
            // 
            this.cbmSwitchTable.FormattingEnabled = true;
            this.cbmSwitchTable.Location = new System.Drawing.Point(3, 41);
            this.cbmSwitchTable.Name = "cbmSwitchTable";
            this.cbmSwitchTable.Size = new System.Drawing.Size(93, 21);
            this.cbmSwitchTable.TabIndex = 0;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(102, 3);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(70, 32);
            this.btnDiscount.TabIndex = 1;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(3, 3);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(93, 32);
            this.btnSwitchTable.TabIndex = 1;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(250, 3);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(65, 59);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(529, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 264);
            this.panel2.TabIndex = 23;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(312, 258);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 47;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 69;
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 445);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form_NhanVien";
            this.Text = "Form_NhanVien";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbmFood;
        private System.Windows.Forms.ComboBox cbmFoodCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ComboBox cbmSwitchTable;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
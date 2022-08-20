namespace WindowsFormsApp1
{
    partial class Table
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVouncher = new System.Windows.Forms.Button();
            this.TongTien = new System.Windows.Forms.TextBox();
            this.ThanhTien = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FoodCount = new System.Windows.Forms.NumericUpDown();
            this.ThemMon = new System.Windows.Forms.Button();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.cbbFoodType = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fplTable = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.bànĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodCount)).BeginInit();
            this.fplTable.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoanToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Chức Năng";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoanToolStripMenuItem
            // 
            this.thôngTinTàiKhoanToolStripMenuItem.Name = "thôngTinTàiKhoanToolStripMenuItem";
            this.thôngTinTàiKhoanToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thôngTinTàiKhoanToolStripMenuItem.Text = "Thông Tin Tài Khoan";
            this.thôngTinTàiKhoanToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoanToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phầnMềmToolStripMenuItem,
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // phầnMềmToolStripMenuItem
            // 
            this.phầnMềmToolStripMenuItem.Name = "phầnMềmToolStripMenuItem";
            this.phầnMềmToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.phầnMềmToolStripMenuItem.Text = "Phần Mềm";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng Dẫn Sử Dụng";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnChangeTable);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnVouncher);
            this.panel3.Controls.Add(this.TongTien);
            this.panel3.Controls.Add(this.ThanhTien);
            this.panel3.Location = new System.Drawing.Point(452, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 145);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnChangeTable.Location = new System.Drawing.Point(21, 81);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(119, 48);
            this.btnChangeTable.TabIndex = 6;
            this.btnChangeTable.Text = "Chuyển Bàn";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(271, 81);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnVouncher
            // 
            this.btnVouncher.Location = new System.Drawing.Point(146, 81);
            this.btnVouncher.Name = "btnVouncher";
            this.btnVouncher.Size = new System.Drawing.Size(119, 48);
            this.btnVouncher.TabIndex = 4;
            this.btnVouncher.Text = "Vouncher";
            this.btnVouncher.UseVisualStyleBackColor = true;
            // 
            // TongTien
            // 
            this.TongTien.BackColor = System.Drawing.Color.Lime;
            this.TongTien.Enabled = false;
            this.TongTien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongTien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TongTien.Location = new System.Drawing.Point(234, 31);
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Size = new System.Drawing.Size(164, 22);
            this.TongTien.TabIndex = 1;
            this.TongTien.Text = "0";
            this.TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TongTien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ThanhTien
            // 
            this.ThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThanhTien.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhTien.Location = new System.Drawing.Point(146, 28);
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Size = new System.Drawing.Size(87, 29);
            this.ThanhTien.TabIndex = 0;
            this.ThanhTien.Text = "Tổng Tiền";
            this.ThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ThanhTien.Click += new System.EventHandler(this.ThanhTien_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.FoodCount);
            this.panel4.Controls.Add(this.ThemMon);
            this.panel4.Controls.Add(this.cbbFood);
            this.panel4.Controls.Add(this.cbbFoodType);
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Location = new System.Drawing.Point(452, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 372);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(0, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Món Ăn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh Mục";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FoodCount
            // 
            this.FoodCount.Location = new System.Drawing.Point(336, 20);
            this.FoodCount.Name = "FoodCount";
            this.FoodCount.Size = new System.Drawing.Size(54, 20);
            this.FoodCount.TabIndex = 4;
            this.FoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ThemMon
            // 
            this.ThemMon.Location = new System.Drawing.Point(252, 6);
            this.ThemMon.Name = "ThemMon";
            this.ThemMon.Size = new System.Drawing.Size(75, 49);
            this.ThemMon.TabIndex = 3;
            this.ThemMon.Text = "Thêm Món";
            this.ThemMon.UseVisualStyleBackColor = true;
            this.ThemMon.Click += new System.EventHandler(this.ThemMon_Click);
            // 
            // cbbFood
            // 
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(76, 34);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(157, 21);
            this.cbbFood.TabIndex = 2;
            // 
            // cbbFoodType
            // 
            this.cbbFoodType.FormattingEnabled = true;
            this.cbbFoodType.Location = new System.Drawing.Point(76, 7);
            this.cbbFoodType.Name = "cbbFoodType";
            this.cbbFoodType.Size = new System.Drawing.Size(157, 21);
            this.cbbFoodType.TabIndex = 1;
            this.cbbFoodType.SelectedIndexChanged += new System.EventHandler(this.cbbFoodType_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idFood,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(0, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(395, 322);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idFood
            // 
            this.idFood.Text = "   Tên Món Ăn";
            this.idFood.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số Lượng";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn Giá";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giảm Giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 90;
            // 
            // fplTable
            // 
            this.fplTable.AutoScroll = true;
            this.fplTable.Controls.Add(this.menuStrip2);
            this.fplTable.Location = new System.Drawing.Point(0, 47);
            this.fplTable.Name = "fplTable";
            this.fplTable.Size = new System.Drawing.Size(449, 495);
            this.fplTable.TabIndex = 7;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bànĂnToolStripMenuItem,
            this.mónĂnToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(247, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.Visible = false;
            // 
            // bànĂnToolStripMenuItem
            // 
            this.bànĂnToolStripMenuItem.Name = "bànĂnToolStripMenuItem";
            this.bànĂnToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.bànĂnToolStripMenuItem.Text = "Bàn Ăn";
            // 
            // mónĂnToolStripMenuItem
            // 
            this.mónĂnToolStripMenuItem.Name = "mónĂnToolStripMenuItem";
            this.mónĂnToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.mónĂnToolStripMenuItem.Text = "Món Ăn";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(133, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 11;
            this.button4.Text = "Bàn Ăn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(224, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 12;
            this.button3.Text = "Món Ăn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 539);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fplTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Table";
            this.Text = "Danh Sách Bàn";
            this.Load += new System.EventHandler(this.Table_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FoodCount)).EndInit();
            this.fplTable.ResumeLayout(false);
            this.fplTable.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phầnMềmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FoodCount;
        private System.Windows.Forms.Button ThemMon;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.ComboBox cbbFoodType;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox TongTien;
        private System.Windows.Forms.Label ThanhTien;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnVouncher;
        private System.Windows.Forms.FlowLayoutPanel fplTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.ColumnHeader idFood;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem bànĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mónĂnToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}
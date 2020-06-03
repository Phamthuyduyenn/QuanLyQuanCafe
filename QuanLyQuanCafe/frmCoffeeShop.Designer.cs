namespace QuanLyQuanCafe
{
    partial class frmCoffeeShop
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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTTien = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sellingPrice";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tổng tiền:";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TTien";
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.Name = "Column4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 421);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Gọi Món";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "quantity";
            this.Column2.HeaderText = "Số Lượng";
            this.Column2.Name = "Column2";
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(-49, 26);
            this.flpTable.Margin = new System.Windows.Forms.Padding(2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(459, 509);
            this.flpTable.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "productId";
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.Name = "Column1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.supplierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // txtTTien
            // 
            this.txtTTien.Location = new System.Drawing.Point(493, 347);
            this.txtTTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTTien.Name = "txtTTien";
            this.txtTTien.Size = new System.Drawing.Size(152, 20);
            this.txtTTien.TabIndex = 11;
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvItem.Location = new System.Drawing.Point(414, 26);
            this.dgvItem.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowTemplate.Height = 24;
            this.dgvItem.Size = new System.Drawing.Size(316, 261);
            this.dgvItem.TabIndex = 8;
            // 
            // frmCoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtTTien);
            this.Controls.Add(this.dgvItem);
            this.Name = "frmCoffeeShop";
            this.Text = "Phần mềm quản lý quán Cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTTien;
        private System.Windows.Forms.DataGridView dgvItem;
    }
}
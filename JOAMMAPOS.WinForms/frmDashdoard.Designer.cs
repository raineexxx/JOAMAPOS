namespace JOAMAPOS.WinForms
{
    partial class frmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.lblTodayOrders = new System.Windows.Forms.Label();
            this.grpLow = new System.Windows.Forms.GroupBox();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.grpActive = new System.Windows.Forms.GroupBox();
            this.lblActiveProducts = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpSales.SuspendLayout();
            this.grpOrders.SuspendLayout();
            this.grpLow.SuspendLayout();
            this.grpActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInventory,
            this.mnuLogout,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnuInventory
            // 
            this.mnuInventory.Name = "mnuInventory";
            this.mnuInventory.Size = new System.Drawing.Size(69, 20);
            this.mnuInventory.Text = "Inventory";
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(57, 20);
            this.mnuLogout.Text = "Logout";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 17);
            // 
            // grpSales
            // 
            this.grpSales.Controls.Add(this.lblTodaySales);
            this.grpSales.Location = new System.Drawing.Point(20, 45);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(220, 90);
            this.grpSales.TabIndex = 2;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Today\'s Sales";
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.AutoSize = true;
            this.lblTodaySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTodaySales.Location = new System.Drawing.Point(15, 32);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(30, 31);
            this.lblTodaySales.TabIndex = 0;
            this.lblTodaySales.Text = "0";
            // 
            // grpOrders
            // 
            this.grpOrders.Controls.Add(this.lblTodayOrders);
            this.grpOrders.Location = new System.Drawing.Point(260, 45);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(220, 90);
            this.grpOrders.TabIndex = 3;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Today\'s Orders";
            // 
            // lblTodayOrders
            // 
            this.lblTodayOrders.AutoSize = true;
            this.lblTodayOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTodayOrders.Location = new System.Drawing.Point(15, 32);
            this.lblTodayOrders.Name = "lblTodayOrders";
            this.lblTodayOrders.Size = new System.Drawing.Size(30, 31);
            this.lblTodayOrders.TabIndex = 0;
            this.lblTodayOrders.Text = "0";
            // 
            // grpLow
            // 
            this.grpLow.Controls.Add(this.lblLowStock);
            this.grpLow.Location = new System.Drawing.Point(500, 45);
            this.grpLow.Name = "grpLow";
            this.grpLow.Size = new System.Drawing.Size(220, 90);
            this.grpLow.TabIndex = 4;
            this.grpLow.TabStop = false;
            this.grpLow.Text = "Low Stock Items";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblLowStock.Location = new System.Drawing.Point(15, 32);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(30, 31);
            this.lblLowStock.TabIndex = 0;
            this.lblLowStock.Text = "0";
            // 
            // grpActive
            // 
            this.grpActive.Controls.Add(this.lblActiveProducts);
            this.grpActive.Location = new System.Drawing.Point(740, 45);
            this.grpActive.Name = "grpActive";
            this.grpActive.Size = new System.Drawing.Size(220, 90);
            this.grpActive.TabIndex = 5;
            this.grpActive.TabStop = false;
            this.grpActive.Text = "Active Products";
            // 
            // lblActiveProducts
            // 
            this.lblActiveProducts.AutoSize = true;
            this.lblActiveProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblActiveProducts.Location = new System.Drawing.Point(15, 32);
            this.lblActiveProducts.Name = "lblActiveProducts";
            this.lblActiveProducts.Size = new System.Drawing.Size(30, 31);
            this.lblActiveProducts.TabIndex = 0;
            this.lblActiveProducts.Text = "0";
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblAlert.Location = new System.Drawing.Point(20, 155);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(113, 18);
            this.lblAlert.TabIndex = 6;
            this.lblAlert.Text = "Low Stock Alert";
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStock.Location = new System.Drawing.Point(20, 180);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.Size = new System.Drawing.Size(940, 400);
            this.dgvLowStock.TabIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(20, 590);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 30);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvLowStock);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.grpActive);
            this.Controls.Add(this.grpLow);
            this.Controls.Add(this.grpOrders);
            this.Controls.Add(this.grpSales);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDashboard";
            this.Text = "JOAMA POS - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpSales.ResumeLayout(false);
            this.grpSales.PerformLayout();
            this.grpOrders.ResumeLayout(false);
            this.grpOrders.PerformLayout();
            this.grpLow.ResumeLayout(false);
            this.grpLow.PerformLayout();
            this.grpActive.ResumeLayout(false);
            this.grpActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.Label lblTodayOrders;
        private System.Windows.Forms.GroupBox grpLow;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.GroupBox grpActive;
        private System.Windows.Forms.Label lblActiveProducts;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.Button btnRefresh;
    }
}
namespace JOAMAPOS.WinForms
{
    partial class frmProducts
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chkShowInactive = new System.Windows.Forms.CheckBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblSku = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblCost = new System.Windows.Forms.Label();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.lblReorder = new System.Windows.Forms.Label();
            this.numReorder = new System.Windows.Forms.NumericUpDown();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpAdjust = new System.Windows.Forms.GroupBox();
            this.lblAdjust = new System.Windows.Forms.Label();
            this.numAdjust = new System.Windows.Forms.NumericUpDown();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnAdjust = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorder)).BeginInit();
            this.grpAdjust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdjust)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(65, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // chkShowInactive
            // 
            this.chkShowInactive.AutoSize = true;
            this.chkShowInactive.Location = new System.Drawing.Point(360, 17);
            this.chkShowInactive.Name = "chkShowInactive";
            this.chkShowInactive.Size = new System.Drawing.Size(92, 17);
            this.chkShowInactive.TabIndex = 2;
            this.chkShowInactive.Text = "Show inactive";
            this.chkShowInactive.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(15, 45);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(640, 585);
            this.dgvProducts.TabIndex = 3;
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.lblSku);
            this.grpDetails.Controls.Add(this.txtSku);
            this.grpDetails.Controls.Add(this.lblBarcode);
            this.grpDetails.Controls.Add(this.txtBarcode);
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.lblCategory);
            this.grpDetails.Controls.Add(this.cboCategory);
            this.grpDetails.Controls.Add(this.lblPrice);
            this.grpDetails.Controls.Add(this.numPrice);
            this.grpDetails.Controls.Add(this.lblCost);
            this.grpDetails.Controls.Add(this.numCost);
            this.grpDetails.Controls.Add(this.lblStock);
            this.grpDetails.Controls.Add(this.numStock);
            this.grpDetails.Controls.Add(this.lblReorder);
            this.grpDetails.Controls.Add(this.numReorder);
            this.grpDetails.Controls.Add(this.chkActive);
            this.grpDetails.Controls.Add(this.btnAdd);
            this.grpDetails.Controls.Add(this.btnUpdate);
            this.grpDetails.Controls.Add(this.btnDelete);
            this.grpDetails.Controls.Add(this.btnClear);
            this.grpDetails.Location = new System.Drawing.Point(675, 15);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(390, 395);
            this.grpDetails.TabIndex = 4;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Product Details";
            // 
            // lblSku
            // 
            this.lblSku.AutoSize = true;
            this.lblSku.Location = new System.Drawing.Point(15, 30);
            this.lblSku.Name = "lblSku";
            this.lblSku.Size = new System.Drawing.Size(29, 13);
            this.lblSku.TabIndex = 0;
            this.lblSku.Text = "SKU";
            // 
            // txtSku
            // 
            this.txtSku.Location = new System.Drawing.Point(130, 27);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(240, 20);
            this.txtSku.TabIndex = 1;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(15, 60);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(47, 13);
            this.lblBarcode.TabIndex = 2;
            this.lblBarcode.Text = "Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(130, 57);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(240, 20);
            this.txtBarcode.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 120);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(130, 117);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(240, 21);
            this.cboCategory.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 150);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(130, 147);
            this.numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(240, 20);
            this.numPrice.TabIndex = 9;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(15, 180);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost";
            // 
            // numCost
            // 
            this.numCost.DecimalPlaces = 2;
            this.numCost.Location = new System.Drawing.Point(130, 177);
            this.numCost.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(240, 20);
            this.numCost.TabIndex = 11;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(15, 210);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(52, 13);
            this.lblStock.TabIndex = 12;
            this.lblStock.Text = "Stock Qty";
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(130, 207);
            this.numStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(240, 20);
            this.numStock.TabIndex = 13;
            // 
            // lblReorder
            // 
            this.lblReorder.AutoSize = true;
            this.lblReorder.Location = new System.Drawing.Point(15, 240);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Size = new System.Drawing.Size(73, 13);
            this.lblReorder.TabIndex = 14;
            this.lblReorder.Text = "Reorder Level";
            // 
            // numReorder
            // 
            this.numReorder.Location = new System.Drawing.Point(130, 237);
            this.numReorder.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numReorder.Name = "numReorder";
            this.numReorder.Size = new System.Drawing.Size(240, 20);
            this.numReorder.TabIndex = 15;
            this.numReorder.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(130, 270);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 16;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 32);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(110, 310);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 32);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(205, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 32);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // grpAdjust
            // 
            this.grpAdjust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAdjust.Controls.Add(this.lblAdjust);
            this.grpAdjust.Controls.Add(this.numAdjust);
            this.grpAdjust.Controls.Add(this.lblReason);
            this.grpAdjust.Controls.Add(this.txtReason);
            this.grpAdjust.Controls.Add(this.btnAdjust);
            this.grpAdjust.Location = new System.Drawing.Point(675, 425);
            this.grpAdjust.Name = "grpAdjust";
            this.grpAdjust.Size = new System.Drawing.Size(390, 190);
            this.grpAdjust.TabIndex = 5;
            this.grpAdjust.TabStop = false;
            this.grpAdjust.Text = "Stock Adjustment";
            // 
            // lblAdjust
            // 
            this.lblAdjust.AutoSize = true;
            this.lblAdjust.Location = new System.Drawing.Point(15, 35);
            this.lblAdjust.Name = "lblAdjust";
            this.lblAdjust.Size = new System.Drawing.Size(73, 13);
            this.lblAdjust.TabIndex = 0;
            this.lblAdjust.Text = "Change (+/-)";
            // 
            // numAdjust
            // 
            this.numAdjust.Location = new System.Drawing.Point(130, 32);
            this.numAdjust.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numAdjust.Minimum = new decimal(new int[] { 100000, 0, 0, -2147483648 });
            this.numAdjust.Name = "numAdjust";
            this.numAdjust.Size = new System.Drawing.Size(240, 20);
            this.numAdjust.TabIndex = 1;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(15, 70);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(44, 13);
            this.lblReason.TabIndex = 2;
            this.lblReason.Text = "Reason";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(130, 67);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(240, 20);
            this.txtReason.TabIndex = 3;
            // 
            // btnAdjust
            // 
            this.btnAdjust.Location = new System.Drawing.Point(130, 110);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(140, 34);
            this.btnAdjust.TabIndex = 4;
            this.btnAdjust.Text = "Adjust Stock";
            this.btnAdjust.UseVisualStyleBackColor = true;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 646);
            this.Controls.Add(this.grpAdjust);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.chkShowInactive);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorder)).EndInit();
            this.grpAdjust.ResumeLayout(false);
            this.grpAdjust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdjust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkShowInactive;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.NumericUpDown numReorder;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpAdjust;
        private System.Windows.Forms.Label lblAdjust;
        private System.Windows.Forms.NumericUpDown numAdjust;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnAdjust;
    }
}
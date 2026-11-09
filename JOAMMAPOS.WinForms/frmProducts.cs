using System;
using System.Windows.Forms;
using JOAMAPOS.Domain;
using JOAMAPOS.Services;

namespace JOAMAPOS.WinForms
{
    public partial class frmProducts : Form
    {
        private readonly ProductService _svc = new ProductService();
        private int? _selectedId = null;

        public frmProducts()
        {
            InitializeComponent();
            Theme.Apply(this);

            // grid setup
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.MultiSelect = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // numeric setup
            numPrice.DecimalPlaces = 2; numPrice.Maximum = 1000000;
            numCost.DecimalPlaces = 2; numCost.Maximum = 1000000;
            numStock.Maximum = 1000000;
            numReorder.Maximum = 100000; numReorder.Value = 5;
            numAdjust.Minimum = -100000; numAdjust.Maximum = 100000;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            // events
            Load += frmProducts_Load;
            dgvProducts.CellClick += dgvProducts_CellClick;
            txtSearch.TextChanged += (s, e) => LoadGrid();
            chkShowInactive.CheckedChanged += (s, e) => LoadGrid();
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnAdjust.Click += btnAdjust_Click;
            btnClear.Click += (s, e) => ClearForm();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            try
            {
                cboCategory.DisplayMember = "Name";
                cboCategory.ValueMember = "CategoryId";
                cboCategory.DataSource = _svc.GetCategories();

                LoadGrid();
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        // ---------------- READ ----------------
        private void LoadGrid()
        {
            try
            {
                dgvProducts.DataSource = _svc.Search(txtSearch.Text, chkShowInactive.Checked);

                if (dgvProducts.Columns["ProductId"] != null)
                    dgvProducts.Columns["ProductId"].Visible = false;
                if (dgvProducts.Columns["CategoryId"] != null)
                    dgvProducts.Columns["CategoryId"].Visible = false;
                if (dgvProducts.Columns["CategoryName"] != null)
                    dgvProducts.Columns["CategoryName"].HeaderText = "Category";
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var p = dgvProducts.Rows[e.RowIndex].DataBoundItem as ProductDto;
            if (p == null) return;

            _selectedId = p.ProductId;
            txtSku.Text = p.Sku;
            txtBarcode.Text = p.Barcode;
            txtName.Text = p.Name;
            cboCategory.SelectedValue = p.CategoryId;
            numPrice.Value = p.Price;
            numCost.Value = p.Cost;
            numStock.Value = p.StockQty;
            numReorder.Value = p.ReorderLevel;
            chkActive.Checked = p.IsActive;

            numStock.Enabled = false;      // stock changes only through Stock Adjustment
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdjust.Enabled = true;
        }

        // ---------------- CREATE ----------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _svc.Add(BuildDto());
                Info("Product added.");
                LoadGrid();
                ClearForm();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        // ---------------- UPDATE ----------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == null) return;
            try
            {
                _svc.Update(BuildDto());
                Info("Product updated.");
                LoadGrid();
                ClearForm();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        // ---------------- DELETE (soft delete keeps sales history) ----------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId == null) return;

            if (MessageBox.Show("Deactivate this product?\n(Sales history will be kept.)",
                                "Confirm Delete", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                _svc.Deactivate(_selectedId.Value);
                Info("Product deactivated.");
                LoadGrid();
                ClearForm();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        // ---------------- STOCK ADJUSTMENT ----------------
        private void btnAdjust_Click(object sender, EventArgs e)
        {
            if (_selectedId == null) return;
            try
            {
                _svc.AdjustStock(_selectedId.Value, (int)numAdjust.Value, txtReason.Text);
                Info("Stock adjusted.");
                LoadGrid();
                ClearForm();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        // ---------------- helpers ----------------
        private ProductDto BuildDto()
        {
            return new ProductDto
            {
                ProductId = _selectedId ?? 0,
                Sku = txtSku.Text,
                Barcode = txtBarcode.Text,
                Name = txtName.Text,
                CategoryId = cboCategory.SelectedValue == null
                                ? 0 : Convert.ToInt32(cboCategory.SelectedValue),
                Price = numPrice.Value,
                Cost = numCost.Value,
                StockQty = (int)numStock.Value,
                ReorderLevel = (int)numReorder.Value,
                IsActive = chkActive.Checked
            };
        }

        private void ClearForm()
        {
            _selectedId = null;
            txtSku.Clear();
            txtBarcode.Clear();
            txtName.Clear();
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            numPrice.Value = 0;
            numCost.Value = 0;
            numStock.Value = 0;
            numReorder.Value = 5;
            numAdjust.Value = 0;
            txtReason.Clear();
            chkActive.Checked = true;

            numStock.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdjust.Enabled = false;
            dgvProducts.ClearSelection();
            txtSku.Focus();
        }

        private void Info(string msg)
        {
            MessageBox.Show(msg, "JOAMA POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowError(Exception ex)
        {
            if (ex is BusinessException)
                MessageBox.Show(ex.Message, "JOAMA POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Unexpected error:\n" + ex.Message, "JOAMA POS",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
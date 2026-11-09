using System;
using System.Windows.Forms;
using JOAMAPOS.Domain;
using JOAMAPOS.Services;

namespace JOAMAPOS.WinForms
{
    public partial class frmDashboard : Form
    {
        private readonly DashboardService _dash = new DashboardService();
        private readonly AuthService _auth = new AuthService();

        public bool LogoutRequested = false;

        public frmDashboard()
        {
            InitializeComponent();
            Theme.Apply(this);

            // four soft pastel cards
            Theme.Card(grpSales, "#EDE4F8");
            Theme.Card(grpOrders, "#E4DAF5");
            Theme.Card(grpLow, "#F3E3F3");
            Theme.Card(grpActive, "#E6E2F8");

            dgvLowStock.ReadOnly = true;
            dgvLowStock.AllowUserToAddRows = false;
            dgvLowStock.AllowUserToDeleteRows = false;
            dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLowStock.RowHeadersVisible = false;

            Load += frmDashboard_Load;
            btnRefresh.Click += (s, e) => LoadMetrics();
            mnuInventory.Click += mnuInventory_Click;
            mnuLogout.Click += mnuLogout_Click;
            mnuExit.Click += (s, e) => Close();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            var u = Session.CurrentUser;
            lblUser.Text = "User: " + u.FullName + "  |  Role: " + u.RoleName;

            // Cashiers are POS-only, so no Inventory access
            mnuInventory.Enabled = Session.IsInRole(Roles.Admin, Roles.Manager);

            LoadMetrics();
        }

        private void LoadMetrics()
        {
            try
            {
                DashboardDto m = _dash.GetMetrics();
                lblTodaySales.Text = m.TodaySales.ToString("N2");
                lblTodayOrders.Text = m.TodayOrders.ToString();
                lblLowStock.Text = m.LowStockCount.ToString();
                lblActiveProducts.Text = m.ActiveProducts.ToString();

                dgvLowStock.DataSource = _dash.GetLowStock();
                if (dgvLowStock.Columns["ProductId"] != null)
                    dgvLowStock.Columns["ProductId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load dashboard:\n" + ex.Message, "JOAMA POS",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuInventory_Click(object sender, EventArgs e)
        {
            using (var f = new frmProducts())
                f.ShowDialog(this);
            LoadMetrics();      // refresh cards after inventory changes
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            _auth.Logout();
            LogoutRequested = true;
            Close();
        }
    }
}
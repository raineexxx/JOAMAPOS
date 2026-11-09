using System;
using System.Drawing;
using System.Windows.Forms;
using JOAMAPOS.Domain;
using JOAMAPOS.Services;

namespace JOAMAPOS.WinForms
{
    public partial class frmLogin : Form
    {
        private readonly AuthService _auth = new AuthService();
        private CheckBox chkShowPassword;

        public frmLogin()
        {
            InitializeComponent();
            ApplyStyle();

            AcceptButton = btnLogin;
            btnLogin.Click += btnLogin_Click;
        }

        private void ApplyStyle()
        {
            Color accent = ColorTranslator.FromHtml("#7B4FC9");
            Color soft = ColorTranslator.FromHtml("#EDE4F8");
            Color text = ColorTranslator.FromHtml("#3B3552");

            Text = "JOAMA POS - Login";
            Font = new Font("Segoe UI", 10F);
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(400, 410);

            // Hide the old plain title and the old Username/Password labels, find them by text
            Label lblUserCaption = null, lblPassCaption = null;
            Button btnExit = null;
            foreach (Control c in Controls)
            {
                var lbl = c as Label;
                if (lbl != null)
                {
                    string t = (lbl.Text ?? "").Trim();
                    if (t.IndexOf("Enterprise", StringComparison.OrdinalIgnoreCase) >= 0) lbl.Visible = false;
                    else if (t.StartsWith("User", StringComparison.OrdinalIgnoreCase)) lblUserCaption = lbl;
                    else if (t.StartsWith("Pass", StringComparison.OrdinalIgnoreCase)) lblPassCaption = lbl;
                }
                var btn = c as Button;
                if (btn != null && (btn.Text ?? "").Trim().Equals("Exit", StringComparison.OrdinalIgnoreCase))
                    btnExit = btn;
            }

            // Header banner
            var header = new Panel { Dock = DockStyle.Top, Height = 110, BackColor = soft };
            header.Controls.Add(new Label
            {
                Text = "Enterprise POS Login",
                Dock = DockStyle.Bottom,
                Height = 34,
                TextAlign = ContentAlignment.TopCenter,
                Font = new Font("Segoe UI", 11F),
                ForeColor = text
            });
            header.Controls.Add(new Label
            {
                Text = "JOAMA POS",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.BottomCenter,
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = accent
            });
            Controls.Add(header);

            const int left = 50, width = 300;

            if (lblUserCaption != null)
            {
                lblUserCaption.Text = "Username";
                lblUserCaption.ForeColor = text;
                lblUserCaption.AutoSize = true;
                lblUserCaption.Location = new Point(left, 135);
            }

            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.SetBounds(left, 160, width, 30);

            if (lblPassCaption != null)
            {
                lblPassCaption.Text = "Password";
                lblPassCaption.ForeColor = text;
                lblPassCaption.AutoSize = true;
                lblPassCaption.Location = new Point(left, 205);
            }

            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.UseSystemPasswordChar = true;   // hides the password
            txtPassword.SetBounds(left, 230, width, 30);

            chkShowPassword = new CheckBox
            {
                Text = "Show password",
                AutoSize = true,
                ForeColor = text,
                Location = new Point(left, 270)
            };
            chkShowPassword.CheckedChanged += (s, e) =>
                txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            Controls.Add(chkShowPassword);

            StyleButton(btnLogin, accent, Color.White);
            btnLogin.SetBounds(left, 320, 145, 42);

            if (btnExit != null)
            {
                StyleButton(btnExit, soft, accent);
                btnExit.SetBounds(left + 155, 320, 145, 42);
                btnExit.DialogResult = DialogResult.Cancel;
                CancelButton = btnExit;
            }

            ActiveControl = txtUsername;
        }

        private static void StyleButton(Button b, Color back, Color fore)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = back;
            b.ForeColor = fore;
            b.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            b.Cursor = Cursors.Hand;
            b.UseVisualStyleBackColor = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserDto user = _auth.Login(txtUsername.Text.Trim(), txtPassword.Text);

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password.", "JOAMA POS",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed:\n" + ex.Message, "JOAMA POS",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
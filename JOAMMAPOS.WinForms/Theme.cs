using System;
using System.Drawing;
using System.Windows.Forms;

namespace JOAMAPOS.WinForms
{
    public static class Theme
    {
        // ---------- palette ----------
        public static readonly Color Background = ColorTranslator.FromHtml("#F6F1FB");
        public static readonly Color Surface = Color.White;
        public static readonly Color Soft = ColorTranslator.FromHtml("#EDE4F8");
        public static readonly Color Lilac = ColorTranslator.FromHtml("#E1D5F2");
        public static readonly Color Border = ColorTranslator.FromHtml("#D9CCEB");
        public static readonly Color Primary = ColorTranslator.FromHtml("#9B7FD1");
        public static readonly Color PrimaryHover = ColorTranslator.FromHtml("#8767C4");
        public static readonly Color PrimaryDark = ColorTranslator.FromHtml("#5B4590");
        public static readonly Color TextDark = ColorTranslator.FromHtml("#3F3358");
        public static readonly Color Rose = ColorTranslator.FromHtml("#F6D6E4");
        public static readonly Color RoseHover = ColorTranslator.FromHtml("#F0C0D5");
        public static readonly Color RoseText = ColorTranslator.FromHtml("#8C3B5E");
        public static readonly Color Error = ColorTranslator.FromHtml("#B5446E");

        // ---------- entry point ----------
        public static void Apply(Form form)
        {
            form.Font = new Font("Segoe UI", 9F);
            form.BackColor = Background;
            form.ForeColor = TextDark;
            StyleChildren(form);
        }

        private static void StyleChildren(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                StyleControl(c);
                if (!(c is DataGridView))
                    StyleChildren(c);
            }
        }

        private static void StyleControl(Control c)
        {
            if (c is Button)
            {
                var b = (Button)c;
                if (b.Name == "btnDelete") Danger(b);
                else if (b.Name == "btnExit" || b.Name == "btnClear") Secondary(b);
                else PrimaryButton(b);
            }
            else if (c is TextBox)
            {
                var t = (TextBox)c;
                t.BorderStyle = BorderStyle.FixedSingle;
                t.BackColor = Surface;
                t.ForeColor = TextDark;
            }
            else if (c is NumericUpDown)
            {
                var n = (NumericUpDown)c;
                n.BorderStyle = BorderStyle.FixedSingle;
                n.BackColor = Surface;
                n.ForeColor = TextDark;
            }
            else if (c is ComboBox)
            {
                c.BackColor = Surface;
                c.ForeColor = TextDark;
            }
            else if (c is CheckBox)
            {
                c.ForeColor = TextDark;
            }
            else if (c is Label)
            {
                var l = (Label)c;
                if (l.Font.Size > 10F)
                {
                    l.Font = new Font("Segoe UI", l.Font.Size, l.Font.Style);
                    l.ForeColor = PrimaryDark;
                }
                else
                {
                    l.ForeColor = TextDark;
                }
            }
            else if (c is GroupBox)
            {
                c.BackColor = Surface;
                c.ForeColor = PrimaryDark;
            }
            else if (c is DataGridView)
            {
                Grid((DataGridView)c);
            }
            else if (c is StatusStrip)
            {
                var s = (StatusStrip)c;
                s.Renderer = new ToolStripProfessionalRenderer(new PurpleColors());
                s.BackColor = Soft;
                s.ForeColor = PrimaryDark;
                foreach (ToolStripItem it in s.Items) it.ForeColor = PrimaryDark;
            }
            else if (c is MenuStrip)
            {
                var m = (MenuStrip)c;
                m.Renderer = new ToolStripProfessionalRenderer(new PurpleColors());
                m.BackColor = Primary;
                m.ForeColor = Color.White;
                m.Padding = new Padding(8, 4, 0, 4);
                foreach (ToolStripItem it in m.Items) it.ForeColor = Color.White;
            }
        }

        // ---------- buttons ----------
        public static void PrimaryButton(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = PrimaryHover;
            b.FlatAppearance.MouseDownBackColor = PrimaryDark;
            b.BackColor = Primary;
            b.ForeColor = Color.White;
            b.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            b.Cursor = Cursors.Hand;
        }

        public static void Secondary(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.BorderColor = Primary;
            b.FlatAppearance.MouseOverBackColor = Soft;
            b.FlatAppearance.MouseDownBackColor = Lilac;
            b.BackColor = Surface;
            b.ForeColor = PrimaryDark;
            b.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            b.Cursor = Cursors.Hand;
        }

        public static void Danger(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = RoseHover;
            b.FlatAppearance.MouseDownBackColor = RoseHover;
            b.BackColor = Rose;
            b.ForeColor = RoseText;
            b.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            b.Cursor = Cursors.Hand;
        }

        // ---------- dashboard cards ----------
        public static void Card(GroupBox g, string hexBackColor)
        {
            g.BackColor = ColorTranslator.FromHtml(hexBackColor);
            g.ForeColor = PrimaryDark;
            foreach (Control ch in g.Controls)
                if (ch is Label) ch.ForeColor = PrimaryDark;
        }

        // ---------- grids ----------
        public static void Grid(DataGridView g)
        {
            g.EnableHeadersVisualStyles = false;
            g.BorderStyle = BorderStyle.None;
            g.BackgroundColor = Surface;
            g.GridColor = Border;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.RowHeadersVisible = false;
            g.RowTemplate.Height = 28;

            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 36;
            g.ColumnHeadersDefaultCellStyle.BackColor = Lilac;
            g.ColumnHeadersDefaultCellStyle.ForeColor = PrimaryDark;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Lilac;
            g.ColumnHeadersDefaultCellStyle.SelectionForeColor = PrimaryDark;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            g.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            g.DefaultCellStyle.BackColor = Surface;
            g.DefaultCellStyle.ForeColor = TextDark;
            g.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#D8C9F0");
            g.DefaultCellStyle.SelectionForeColor = TextDark;
            g.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            g.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAF7FE");
        }

        // ---------- menu / status strip colors ----------
        private class PurpleColors : ProfessionalColorTable
        {
            public PurpleColors() { UseSystemColors = false; }

            public override Color MenuItemSelected { get { return PrimaryHover; } }
            public override Color MenuItemBorder { get { return PrimaryHover; } }
            public override Color MenuItemSelectedGradientBegin { get { return PrimaryHover; } }
            public override Color MenuItemSelectedGradientEnd { get { return PrimaryHover; } }
            public override Color MenuItemPressedGradientBegin { get { return PrimaryDark; } }
            public override Color MenuItemPressedGradientEnd { get { return PrimaryDark; } }
            public override Color MenuStripGradientBegin { get { return Primary; } }
            public override Color MenuStripGradientEnd { get { return Primary; } }
            public override Color MenuBorder { get { return Border; } }
            public override Color ToolStripDropDownBackground { get { return Surface; } }
            public override Color ImageMarginGradientBegin { get { return Surface; } }
            public override Color ImageMarginGradientMiddle { get { return Surface; } }
            public override Color ImageMarginGradientEnd { get { return Surface; } }
            public override Color StatusStripGradientBegin { get { return Soft; } }
            public override Color StatusStripGradientEnd { get { return Soft; } }
            public override Color ToolStripBorder { get { return Soft; } }
        }
    }
}
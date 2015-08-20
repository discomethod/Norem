using System;
using System.Drawing;
using System.Windows.Forms;

namespace Norem.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            ForgeLabel.Size = new Size(Size.Width / 2 - 8, ForgeLabel.Size.Height);
            SacrificeLabel.Size = new Size(Size.Width / 2 - 8, SacrificeLabel.Size.Height);
            SacrificeLabel.Location = new Point(Size.Width / 2 - 8, 0);
        }
    }
}

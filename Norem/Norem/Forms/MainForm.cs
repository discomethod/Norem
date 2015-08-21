using Norem.Controllers;
using System;
using System.Windows.Forms;

namespace Norem.Forms
{
    public partial class MainForm : Form
    {
        private SessionManager m_SesssionManager;
        public SessionManager SessionManager { set { m_SesssionManager = value; } }

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateAllButton_Click(object sender, EventArgs e)
        {
            // TODO: fetch all runes
            m_SesssionManager.FetchGlobalData();
        }
    }
}

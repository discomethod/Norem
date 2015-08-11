using Norem.Controllers;
using Norem.Forms;
using System;
using System.Windows.Forms;

namespace Norem
{
    public partial class LoginForm : Form
    {
        private SessionManager m_SessionManager;

        private void InitializeDefaultValues()
        {
            ActiveControl = WelcomeLabel;
            UsernameExtendedTextBox.Cue = Properties.Resources.DefaultUsernameTextBoxString;
            PasswordExtendedTextBox.Password = true;
            PasswordExtendedTextBox.Cue = Properties.Resources.DefaultPasswordTextBoxString;
        }
        public LoginForm()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // login logic
            if(UsernameExtendedTextBox.Text.Length > 16 || UsernameExtendedTextBox.Text.Length < 4 )
            {
                // username is invalid length
                return;
            }
            m_SessionManager = new SessionManager(UsernameExtendedTextBox.Text);
            if (m_SessionManager.DoLogin(PasswordExtendedTextBox.Text))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                mainForm.FormClosed += MainForm_FormClosed;
                this.Hide();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}

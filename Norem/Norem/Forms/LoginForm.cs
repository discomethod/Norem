﻿using Norem.Controllers;
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
            UsernameExtendedTextBox.Cue = Properties.Resources.DefaultUsernameTextBox;
            PasswordExtendedTextBox.Password = true;
            PasswordExtendedTextBox.Cue = Properties.Resources.DefaultPasswordTextBox;

            LoginErrorLabel.Text = Properties.Resources.LoginErrorLabel;
            LoginErrorLabel.Visible = false;
        }
        public LoginForm()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // hide the login error message
            LoginErrorLabel.Visible = false;
            // login logic
            if(UsernameExtendedTextBox.Text.Length > 16 || UsernameExtendedTextBox.Text.Length < 4 )
            {
                // username is invalid length
                LoginErrorLabel.Visible = true;
                return;
            }
            m_SessionManager = new SessionManager(UsernameExtendedTextBox.Text);
            if (m_SessionManager.DoLogin(PasswordExtendedTextBox.Text))
            {
                MainForm mainForm = new MainForm();
                mainForm.SessionManager = m_SessionManager;
                mainForm.Show();
                mainForm.FormClosed += MainForm_FormClosed;
                Hide();
            }
            else
            {
                LoginErrorLabel.Visible = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}

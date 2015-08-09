using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Norem
{
    public partial class MainForm : Form
    {
        private void InitializeDefaultValues()
        {
            ActiveControl = WelcomeLabel;
            UsernameExtendedTextBox.Cue = Properties.Resources.DefaultUsernameTextBoxString;
            PasswordExtendedTextBox.Password = true;
            PasswordExtendedTextBox.Cue = Properties.Resources.DefaultPasswordTextBoxString;
        }
        public MainForm()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Norem
{
    public partial class ExtendedTextBox : TextBox
    {

        private string m_Cue = "";
        private bool m_Password = false;

        public string Cue
        {
            get { return m_Cue; }
            set { m_Cue = value; UpdateCue(); }
        }

        public bool Password
        {
            get { return m_Password; }
            set { m_Password = value; }
        }

        public ExtendedTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if(m_Cue != String.Empty && this.Text == m_Cue) { this.RemoveCue(); }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if(m_Cue != String.Empty && this.Text == string.Empty) { this.AddCue(); }
        }

        private void UpdateCue()
        {
            // cue has been changed, update accordingly
            if(!this.Focused)
            {
                AddCue();
            }
        }

        private void RemoveCue()
        {
            // remove the cue text and change text color to normal
            Text = "";
            ForeColor = Color.FromArgb(33, Color.Black);
            PasswordChar = m_Password ? '*' : '\0';
        }

        private void AddCue()
        {
            // add cue text and change text color to cue
            this.Text = m_Cue;
            this.ForeColor = Color.FromArgb(103, Color.Black);
            PasswordChar = '\0';
        }
    }
}

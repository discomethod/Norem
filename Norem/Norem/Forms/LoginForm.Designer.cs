namespace Norem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordExtendedTextBox = new Norem.ExtendedTextBox();
            this.UsernameExtendedTextBox = new Norem.ExtendedTextBox();
            this.LoginErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.WelcomeLabel.Location = new System.Drawing.Point(6, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(104, 32);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Norem";
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.LoginButton.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LoginButton.Location = new System.Drawing.Point(12, 221);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(268, 33);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.TabStop = false;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordExtendedTextBox
            // 
            this.PasswordExtendedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordExtendedTextBox.Cue = "";
            this.PasswordExtendedTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordExtendedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordExtendedTextBox.Location = new System.Drawing.Point(12, 185);
            this.PasswordExtendedTextBox.Name = "PasswordExtendedTextBox";
            this.PasswordExtendedTextBox.Password = false;
            this.PasswordExtendedTextBox.Size = new System.Drawing.Size(268, 29);
            this.PasswordExtendedTextBox.TabIndex = 2;
            this.PasswordExtendedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsernameExtendedTextBox
            // 
            this.UsernameExtendedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameExtendedTextBox.Cue = "";
            this.UsernameExtendedTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameExtendedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UsernameExtendedTextBox.Location = new System.Drawing.Point(12, 148);
            this.UsernameExtendedTextBox.Name = "UsernameExtendedTextBox";
            this.UsernameExtendedTextBox.Password = false;
            this.UsernameExtendedTextBox.Size = new System.Drawing.Size(268, 29);
            this.UsernameExtendedTextBox.TabIndex = 1;
            this.UsernameExtendedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginErrorLabel
            // 
            this.LoginErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginErrorLabel.AutoSize = true;
            this.LoginErrorLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginErrorLabel.ForeColor = System.Drawing.Color.Brown;
            this.LoginErrorLabel.Location = new System.Drawing.Point(8, 124);
            this.LoginErrorLabel.Name = "LoginErrorLabel";
            this.LoginErrorLabel.Size = new System.Drawing.Size(266, 21);
            this.LoginErrorLabel.TabIndex = 4;
            this.LoginErrorLabel.Text = "There was a problem logging in.";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.LoginErrorLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordExtendedTextBox);
            this.Controls.Add(this.UsernameExtendedTextBox);
            this.Controls.Add(this.WelcomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Norem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private ExtendedTextBox UsernameExtendedTextBox;
        private ExtendedTextBox PasswordExtendedTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LoginErrorLabel;
    }
}


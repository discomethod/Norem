namespace Norem.Forms
{
    partial class MainForm
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
            this.ForgeLabel = new System.Windows.Forms.Label();
            this.SacrificeLabel = new System.Windows.Forms.Label();
            this.sacrificeControl1 = new Norem.Controls.SacrificeControl();
            this.SuspendLayout();
            // 
            // ForgeLabel
            // 
            this.ForgeLabel.BackColor = System.Drawing.Color.LightGray;
            this.ForgeLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgeLabel.Location = new System.Drawing.Point(0, 0);
            this.ForgeLabel.Name = "ForgeLabel";
            this.ForgeLabel.Size = new System.Drawing.Size(142, 30);
            this.ForgeLabel.TabIndex = 0;
            this.ForgeLabel.Text = "Forge";
            this.ForgeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SacrificeLabel
            // 
            this.SacrificeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SacrificeLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SacrificeLabel.Location = new System.Drawing.Point(142, 0);
            this.SacrificeLabel.Name = "SacrificeLabel";
            this.SacrificeLabel.Size = new System.Drawing.Size(142, 30);
            this.SacrificeLabel.TabIndex = 1;
            this.SacrificeLabel.Text = "Sacrifice";
            this.SacrificeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // sacrificeControl1
            // 
            this.sacrificeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sacrificeControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sacrificeControl1.Location = new System.Drawing.Point(6, 33);
            this.sacrificeControl1.Name = "sacrificeControl1";
            this.sacrificeControl1.Size = new System.Drawing.Size(266, 317);
            this.sacrificeControl1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.sacrificeControl1);
            this.Controls.Add(this.SacrificeLabel);
            this.Controls.Add(this.ForgeLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ForgeLabel;
        private System.Windows.Forms.Label SacrificeLabel;
        private Controls.SacrificeControl sacrificeControl1;
    }
}
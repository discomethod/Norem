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
            this.CraftLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sacrificeControl1 = new Norem.Controls.SacrificeControl();
            this.SuspendLayout();
            // 
            // CraftLabel
            // 
            this.CraftLabel.BackColor = System.Drawing.Color.LightGray;
            this.CraftLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CraftLabel.Location = new System.Drawing.Point(0, 0);
            this.CraftLabel.Name = "CraftLabel";
            this.CraftLabel.Size = new System.Drawing.Size(142, 30);
            this.CraftLabel.TabIndex = 0;
            this.CraftLabel.Text = "Forge";
            this.CraftLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sacrifice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // sacrificeControl1
            // 
            this.sacrificeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sacrificeControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sacrificeControl1.Location = new System.Drawing.Point(6, 33);
            this.sacrificeControl1.Name = "sacrificeControl1";
            this.sacrificeControl1.Size = new System.Drawing.Size(266, 217);
            this.sacrificeControl1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.sacrificeControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CraftLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CraftLabel;
        private System.Windows.Forms.Label label1;
        private Controls.SacrificeControl sacrificeControl1;
    }
}
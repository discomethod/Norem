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
            this.MainFormTabControl = new System.Windows.Forms.TabControl();
            this.ForgeTab = new System.Windows.Forms.TabPage();
            this.SacrificeTab = new System.Windows.Forms.TabPage();
            this.CollectionTab = new System.Windows.Forms.TabPage();
            this.UpdateAllButton = new System.Windows.Forms.Button();
            this.MainFormTabControl.SuspendLayout();
            this.CollectionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormTabControl
            // 
            this.MainFormTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormTabControl.Controls.Add(this.ForgeTab);
            this.MainFormTabControl.Controls.Add(this.SacrificeTab);
            this.MainFormTabControl.Controls.Add(this.CollectionTab);
            this.MainFormTabControl.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormTabControl.ItemSize = new System.Drawing.Size(42, 30);
            this.MainFormTabControl.Location = new System.Drawing.Point(2, 3);
            this.MainFormTabControl.Name = "MainFormTabControl";
            this.MainFormTabControl.SelectedIndex = 0;
            this.MainFormTabControl.Size = new System.Drawing.Size(280, 357);
            this.MainFormTabControl.TabIndex = 0;
            // 
            // ForgeTab
            // 
            this.ForgeTab.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgeTab.Location = new System.Drawing.Point(4, 34);
            this.ForgeTab.Name = "ForgeTab";
            this.ForgeTab.Padding = new System.Windows.Forms.Padding(3);
            this.ForgeTab.Size = new System.Drawing.Size(272, 319);
            this.ForgeTab.TabIndex = 0;
            this.ForgeTab.Text = "Forge";
            this.ForgeTab.UseVisualStyleBackColor = true;
            // 
            // SacrificeTab
            // 
            this.SacrificeTab.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SacrificeTab.Location = new System.Drawing.Point(4, 34);
            this.SacrificeTab.Name = "SacrificeTab";
            this.SacrificeTab.Padding = new System.Windows.Forms.Padding(3);
            this.SacrificeTab.Size = new System.Drawing.Size(272, 319);
            this.SacrificeTab.TabIndex = 1;
            this.SacrificeTab.Text = "Sacrifice";
            this.SacrificeTab.UseVisualStyleBackColor = true;
            // 
            // CollectionTab
            // 
            this.CollectionTab.Controls.Add(this.UpdateAllButton);
            this.CollectionTab.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionTab.Location = new System.Drawing.Point(4, 34);
            this.CollectionTab.Name = "CollectionTab";
            this.CollectionTab.Size = new System.Drawing.Size(272, 319);
            this.CollectionTab.TabIndex = 2;
            this.CollectionTab.Text = "Collection";
            this.CollectionTab.UseVisualStyleBackColor = true;
            // 
            // UpdateAllButton
            // 
            this.UpdateAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateAllButton.AutoSize = true;
            this.UpdateAllButton.Location = new System.Drawing.Point(188, 282);
            this.UpdateAllButton.Name = "UpdateAllButton";
            this.UpdateAllButton.Size = new System.Drawing.Size(78, 31);
            this.UpdateAllButton.TabIndex = 0;
            this.UpdateAllButton.Text = "Update";
            this.UpdateAllButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.MainFormTabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainFormTabControl.ResumeLayout(false);
            this.CollectionTab.ResumeLayout(false);
            this.CollectionTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainFormTabControl;
        private System.Windows.Forms.TabPage ForgeTab;
        private System.Windows.Forms.TabPage SacrificeTab;
        private System.Windows.Forms.TabPage CollectionTab;
        private System.Windows.Forms.Button UpdateAllButton;
    }
}
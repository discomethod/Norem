﻿namespace Norem.Forms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormTabControl = new System.Windows.Forms.TabControl();
            this.ForgeTab = new System.Windows.Forms.TabPage();
            this.SacrificeTab = new System.Windows.Forms.TabPage();
            this.SacrificeAllButton = new System.Windows.Forms.Button();
            this.SacrificeButton = new System.Windows.Forms.Button();
            this.SacrificeDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rarityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CollectionTab = new System.Windows.Forms.TabPage();
            this.UpdateAllButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainFormTabControl.SuspendLayout();
            this.SacrificeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SacrificeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runeBindingSource)).BeginInit();
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
            this.MainFormTabControl.Size = new System.Drawing.Size(369, 483);
            this.MainFormTabControl.TabIndex = 0;
            // 
            // ForgeTab
            // 
            this.ForgeTab.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgeTab.Location = new System.Drawing.Point(4, 34);
            this.ForgeTab.Name = "ForgeTab";
            this.ForgeTab.Padding = new System.Windows.Forms.Padding(3);
            this.ForgeTab.Size = new System.Drawing.Size(361, 445);
            this.ForgeTab.TabIndex = 0;
            this.ForgeTab.Text = "Forge";
            this.ForgeTab.UseVisualStyleBackColor = true;
            // 
            // SacrificeTab
            // 
            this.SacrificeTab.Controls.Add(this.SacrificeAllButton);
            this.SacrificeTab.Controls.Add(this.SacrificeButton);
            this.SacrificeTab.Controls.Add(this.SacrificeDataGridView);
            this.SacrificeTab.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SacrificeTab.Location = new System.Drawing.Point(4, 34);
            this.SacrificeTab.Name = "SacrificeTab";
            this.SacrificeTab.Padding = new System.Windows.Forms.Padding(3);
            this.SacrificeTab.Size = new System.Drawing.Size(361, 445);
            this.SacrificeTab.TabIndex = 1;
            this.SacrificeTab.Text = "Sacrifice";
            this.SacrificeTab.UseVisualStyleBackColor = true;
            // 
            // SacrificeAllButton
            // 
            this.SacrificeAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SacrificeAllButton.AutoSize = true;
            this.SacrificeAllButton.Location = new System.Drawing.Point(148, 411);
            this.SacrificeAllButton.Name = "SacrificeAllButton";
            this.SacrificeAllButton.Size = new System.Drawing.Size(112, 31);
            this.SacrificeAllButton.TabIndex = 2;
            this.SacrificeAllButton.Text = "Sacrifice All";
            this.SacrificeAllButton.UseVisualStyleBackColor = true;
            // 
            // SacrificeButton
            // 
            this.SacrificeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SacrificeButton.AutoSize = true;
            this.SacrificeButton.Location = new System.Drawing.Point(266, 411);
            this.SacrificeButton.Name = "SacrificeButton";
            this.SacrificeButton.Size = new System.Drawing.Size(89, 31);
            this.SacrificeButton.TabIndex = 1;
            this.SacrificeButton.Text = "Sacrifice";
            this.SacrificeButton.UseVisualStyleBackColor = true;
            // 
            // SacrificeDataGridView
            // 
            this.SacrificeDataGridView.AllowUserToAddRows = false;
            this.SacrificeDataGridView.AllowUserToDeleteRows = false;
            this.SacrificeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SacrificeDataGridView.AutoGenerateColumns = false;
            this.SacrificeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SacrificeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.RuneTypeDataGridViewTextBoxColumn,
            this.rarityDataGridViewTextBoxColumn});
            this.SacrificeDataGridView.DataSource = this.runeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SacrificeDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.SacrificeDataGridView.Location = new System.Drawing.Point(7, 7);
            this.SacrificeDataGridView.Name = "SacrificeDataGridView";
            this.SacrificeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SacrificeDataGridView.Size = new System.Drawing.Size(348, 398);
            this.SacrificeDataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 82;
            // 
            // RuneTypeDataGridViewTextBoxColumn
            // 
            this.RuneTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RuneTypeDataGridViewTextBoxColumn.DataPropertyName = "RuneType";
            this.RuneTypeDataGridViewTextBoxColumn.HeaderText = "RuneType";
            this.RuneTypeDataGridViewTextBoxColumn.Name = "RuneTypeDataGridViewTextBoxColumn";
            this.RuneTypeDataGridViewTextBoxColumn.Width = 118;
            // 
            // rarityDataGridViewTextBoxColumn
            // 
            this.rarityDataGridViewTextBoxColumn.DataPropertyName = "Rarity";
            this.rarityDataGridViewTextBoxColumn.HeaderText = "Rarity";
            this.rarityDataGridViewTextBoxColumn.Name = "rarityDataGridViewTextBoxColumn";
            this.rarityDataGridViewTextBoxColumn.Width = 105;
            // 
            // runeBindingSource
            // 
            this.runeBindingSource.DataSource = typeof(Norem.Models.Rune);
            // 
            // CollectionTab
            // 
            this.CollectionTab.Controls.Add(this.UpdateAllButton);
            this.CollectionTab.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionTab.Location = new System.Drawing.Point(4, 34);
            this.CollectionTab.Name = "CollectionTab";
            this.CollectionTab.Size = new System.Drawing.Size(361, 445);
            this.CollectionTab.TabIndex = 2;
            this.CollectionTab.Text = "Collection";
            this.CollectionTab.UseVisualStyleBackColor = true;
            // 
            // UpdateAllButton
            // 
            this.UpdateAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateAllButton.AutoSize = true;
            this.UpdateAllButton.Location = new System.Drawing.Point(277, 408);
            this.UpdateAllButton.Name = "UpdateAllButton";
            this.UpdateAllButton.Size = new System.Drawing.Size(78, 31);
            this.UpdateAllButton.TabIndex = 0;
            this.UpdateAllButton.Text = "Update";
            this.UpdateAllButton.UseVisualStyleBackColor = true;
            this.UpdateAllButton.Click += new System.EventHandler(this.UpdateAllButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RuneType";
            this.dataGridViewTextBoxColumn1.HeaderText = "RuneType";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(373, 488);
            this.Controls.Add(this.MainFormTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainFormTabControl.ResumeLayout(false);
            this.SacrificeTab.ResumeLayout(false);
            this.SacrificeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SacrificeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runeBindingSource)).EndInit();
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
        private System.Windows.Forms.Button SacrificeAllButton;
        private System.Windows.Forms.Button SacrificeButton;
        private System.Windows.Forms.DataGridView SacrificeDataGridView;
        private System.Windows.Forms.BindingSource runeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuneTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rarityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
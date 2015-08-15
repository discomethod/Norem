namespace Norem.Controls
{
    partial class SacrificeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SacrificeButton = new System.Windows.Forms.Button();
            this.SacrificeAllButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SacrificeButton
            // 
            this.SacrificeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SacrificeButton.AutoSize = true;
            this.SacrificeButton.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SacrificeButton.Location = new System.Drawing.Point(128, 119);
            this.SacrificeButton.Name = "SacrificeButton";
            this.SacrificeButton.Size = new System.Drawing.Size(89, 31);
            this.SacrificeButton.TabIndex = 0;
            this.SacrificeButton.Text = "Sacrifice";
            this.SacrificeButton.UseVisualStyleBackColor = true;
            // 
            // SacrificeAllButton
            // 
            this.SacrificeAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SacrificeAllButton.AutoSize = true;
            this.SacrificeAllButton.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SacrificeAllButton.Location = new System.Drawing.Point(10, 119);
            this.SacrificeAllButton.Name = "SacrificeAllButton";
            this.SacrificeAllButton.Size = new System.Drawing.Size(112, 31);
            this.SacrificeAllButton.TabIndex = 1;
            this.SacrificeAllButton.Text = "Sacrifice All";
            this.SacrificeAllButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(217, 110);
            this.dataGridView1.TabIndex = 2;
            // 
            // SacrificeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SacrificeAllButton);
            this.Controls.Add(this.SacrificeButton);
            this.Name = "SacrificeControl";
            this.Size = new System.Drawing.Size(217, 150);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SacrificeButton;
        private System.Windows.Forms.Button SacrificeAllButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

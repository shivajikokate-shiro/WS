namespace WaterSystem_v1
{
    partial class FrmInventoryContainer
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
            this.tabInventoryContainer = new System.Windows.Forms.TabControl();
            this.tabRawMaterial = new System.Windows.Forms.TabPage();
            this.tabBottelFormula = new System.Windows.Forms.TabPage();
            this.tabProductManufacture = new System.Windows.Forms.TabPage();
            this.tabInventoryContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInventoryContainer
            // 
            this.tabInventoryContainer.Controls.Add(this.tabRawMaterial);
            this.tabInventoryContainer.Controls.Add(this.tabBottelFormula);
            this.tabInventoryContainer.Controls.Add(this.tabProductManufacture);
            this.tabInventoryContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInventoryContainer.Location = new System.Drawing.Point(0, 0);
            this.tabInventoryContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tabInventoryContainer.Name = "tabInventoryContainer";
            this.tabInventoryContainer.Padding = new System.Drawing.Point(15, 10);
            this.tabInventoryContainer.SelectedIndex = 0;
            this.tabInventoryContainer.Size = new System.Drawing.Size(709, 340);
            this.tabInventoryContainer.TabIndex = 0;
            this.tabInventoryContainer.Click += new System.EventHandler(this.tabInventoryContainer_Click);
            // 
            // tabRawMaterial
            // 
            this.tabRawMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabRawMaterial.Location = new System.Drawing.Point(4, 36);
            this.tabRawMaterial.Name = "tabRawMaterial";
            this.tabRawMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.tabRawMaterial.Size = new System.Drawing.Size(701, 300);
            this.tabRawMaterial.TabIndex = 0;
            this.tabRawMaterial.Text = "Raw Material";
            this.tabRawMaterial.UseVisualStyleBackColor = true;
            // 
            // tabBottelFormula
            // 
            this.tabBottelFormula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabBottelFormula.Location = new System.Drawing.Point(4, 36);
            this.tabBottelFormula.Name = "tabBottelFormula";
            this.tabBottelFormula.Padding = new System.Windows.Forms.Padding(3);
            this.tabBottelFormula.Size = new System.Drawing.Size(701, 300);
            this.tabBottelFormula.TabIndex = 1;
            this.tabBottelFormula.Text = "BottleFormula";
            this.tabBottelFormula.UseVisualStyleBackColor = true;
            // 
            // tabProductManufacture
            // 
            this.tabProductManufacture.Location = new System.Drawing.Point(4, 36);
            this.tabProductManufacture.Name = "tabProductManufacture";
            this.tabProductManufacture.Size = new System.Drawing.Size(701, 300);
            this.tabProductManufacture.TabIndex = 2;
            this.tabProductManufacture.Text = "ProductManufacture";
            this.tabProductManufacture.UseVisualStyleBackColor = true;
            // 
            // FrmInventoryContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 340);
            this.Controls.Add(this.tabInventoryContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventoryContainer";
            this.Text = "FrmInventoryContainer";
            this.tabInventoryContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInventoryContainer;
        private System.Windows.Forms.TabPage tabRawMaterial;
        private System.Windows.Forms.TabPage tabBottelFormula;
        private System.Windows.Forms.TabPage tabProductManufacture;
    }
}
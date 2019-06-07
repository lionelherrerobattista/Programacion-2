namespace Ejercicio_60_Form
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtProductNumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblSafetyStockLabel = new System.Windows.Forms.Label();
            this.lblReorderPoint = new System.Windows.Forms.Label();
            this.lblStandardCost = new System.Windows.Forms.Label();
            this.lblListPrice = new System.Windows.Forms.Label();
            this.lblDaysToManufacture = new System.Windows.Forms.Label();
            this.txtSafetyStockLevel = new System.Windows.Forms.TextBox();
            this.txtReorderPoint = new System.Windows.Forms.TextBox();
            this.txtStandardCost = new System.Windows.Forms.TextBox();
            this.txtListPrice = new System.Windows.Forms.TextBox();
            this.txtDaysToManufacture = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.Location = new System.Drawing.Point(143, 48);
            this.txtProductNumber.Name = "txtProductNumber";
            this.txtProductNumber.Size = new System.Drawing.Size(100, 20);
            this.txtProductNumber.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.AutoSize = true;
            this.lblProductNumber.Location = new System.Drawing.Point(12, 51);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Size = new System.Drawing.Size(84, 13);
            this.lblProductNumber.TabIndex = 5;
            this.lblProductNumber.Text = "Product Number";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(143, 224);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblSafetyStockLabel
            // 
            this.lblSafetyStockLabel.AutoSize = true;
            this.lblSafetyStockLabel.Location = new System.Drawing.Point(12, 77);
            this.lblSafetyStockLabel.Name = "lblSafetyStockLabel";
            this.lblSafetyStockLabel.Size = new System.Drawing.Size(91, 13);
            this.lblSafetyStockLabel.TabIndex = 7;
            this.lblSafetyStockLabel.Text = "SafetyStockLevel";
            // 
            // lblReorderPoint
            // 
            this.lblReorderPoint.AutoSize = true;
            this.lblReorderPoint.Location = new System.Drawing.Point(12, 108);
            this.lblReorderPoint.Name = "lblReorderPoint";
            this.lblReorderPoint.Size = new System.Drawing.Size(72, 13);
            this.lblReorderPoint.TabIndex = 8;
            this.lblReorderPoint.Text = "Reorder Point";
            // 
            // lblStandardCost
            // 
            this.lblStandardCost.AutoSize = true;
            this.lblStandardCost.Location = new System.Drawing.Point(12, 134);
            this.lblStandardCost.Name = "lblStandardCost";
            this.lblStandardCost.Size = new System.Drawing.Size(74, 13);
            this.lblStandardCost.TabIndex = 9;
            this.lblStandardCost.Text = "Standard Cost";
            // 
            // lblListPrice
            // 
            this.lblListPrice.AutoSize = true;
            this.lblListPrice.Location = new System.Drawing.Point(12, 160);
            this.lblListPrice.Name = "lblListPrice";
            this.lblListPrice.Size = new System.Drawing.Size(50, 13);
            this.lblListPrice.TabIndex = 10;
            this.lblListPrice.Text = "List Price";
            // 
            // lblDaysToManufacture
            // 
            this.lblDaysToManufacture.AutoSize = true;
            this.lblDaysToManufacture.Location = new System.Drawing.Point(12, 186);
            this.lblDaysToManufacture.Name = "lblDaysToManufacture";
            this.lblDaysToManufacture.Size = new System.Drawing.Size(110, 13);
            this.lblDaysToManufacture.TabIndex = 11;
            this.lblDaysToManufacture.Text = "Days To Manufacture";
            // 
            // txtSafetyStockLevel
            // 
            this.txtSafetyStockLevel.Location = new System.Drawing.Point(143, 77);
            this.txtSafetyStockLevel.Name = "txtSafetyStockLevel";
            this.txtSafetyStockLevel.Size = new System.Drawing.Size(100, 20);
            this.txtSafetyStockLevel.TabIndex = 12;
            // 
            // txtReorderPoint
            // 
            this.txtReorderPoint.Location = new System.Drawing.Point(143, 105);
            this.txtReorderPoint.Name = "txtReorderPoint";
            this.txtReorderPoint.Size = new System.Drawing.Size(100, 20);
            this.txtReorderPoint.TabIndex = 13;
            // 
            // txtStandardCost
            // 
            this.txtStandardCost.Location = new System.Drawing.Point(143, 131);
            this.txtStandardCost.Name = "txtStandardCost";
            this.txtStandardCost.Size = new System.Drawing.Size(100, 20);
            this.txtStandardCost.TabIndex = 14;
            // 
            // txtListPrice
            // 
            this.txtListPrice.Location = new System.Drawing.Point(143, 157);
            this.txtListPrice.Name = "txtListPrice";
            this.txtListPrice.Size = new System.Drawing.Size(100, 20);
            this.txtListPrice.TabIndex = 15;
            // 
            // txtDaysToManufacture
            // 
            this.txtDaysToManufacture.Location = new System.Drawing.Point(143, 183);
            this.txtDaysToManufacture.Name = "txtDaysToManufacture";
            this.txtDaysToManufacture.Size = new System.Drawing.Size(100, 20);
            this.txtDaysToManufacture.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(242, 224);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(261, 29);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(55, 13);
            this.lblProductId.TabIndex = 18;
            this.lblProductId.Text = "ProductID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(332, 22);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 273);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDaysToManufacture);
            this.Controls.Add(this.txtListPrice);
            this.Controls.Add(this.txtStandardCost);
            this.Controls.Add(this.txtReorderPoint);
            this.Controls.Add(this.txtSafetyStockLevel);
            this.Controls.Add(this.lblDaysToManufacture);
            this.Controls.Add(this.lblListPrice);
            this.Controls.Add(this.lblStandardCost);
            this.Controls.Add(this.lblReorderPoint);
            this.Controls.Add(this.lblSafetyStockLabel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblProductNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtProductNumber);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtProductNumber;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblProductNumber;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Label lblSafetyStockLabel;
    private System.Windows.Forms.Label lblReorderPoint;
    private System.Windows.Forms.Label lblStandardCost;
    private System.Windows.Forms.Label lblListPrice;
    private System.Windows.Forms.Label lblDaysToManufacture;
    private System.Windows.Forms.TextBox txtSafetyStockLevel;
    private System.Windows.Forms.TextBox txtReorderPoint;
    private System.Windows.Forms.TextBox txtStandardCost;
    private System.Windows.Forms.TextBox txtListPrice;
    private System.Windows.Forms.TextBox txtDaysToManufacture;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Label lblProductId;
    private System.Windows.Forms.TextBox txtProductID;
  }
}


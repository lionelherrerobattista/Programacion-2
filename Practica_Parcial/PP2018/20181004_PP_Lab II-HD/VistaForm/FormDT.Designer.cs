namespace VistaForm
{
  partial class FormDT
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelExperiencia = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDNI = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExperiencia = new System.Windows.Forms.NumericUpDown();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonValidar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(60, 51);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(60, 86);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(60, 120);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(32, 13);
            this.labelEdad.TabIndex = 2;
            this.labelEdad.Text = "Edad";
            this.labelEdad.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(60, 158);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 3;
            this.labelDNI.Text = "DNI";
            this.labelDNI.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelExperiencia
            // 
            this.labelExperiencia.AutoSize = true;
            this.labelExperiencia.Location = new System.Drawing.Point(60, 195);
            this.labelExperiencia.Name = "labelExperiencia";
            this.labelExperiencia.Size = new System.Drawing.Size(62, 13);
            this.labelExperiencia.TabIndex = 4;
            this.labelExperiencia.Text = "Experiencia";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(172, 83);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(120, 20);
            this.textBoxApellido.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(172, 48);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(120, 20);
            this.textBoxNombre.TabIndex = 6;
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(172, 120);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEdad.TabIndex = 7;
            // 
            // numericUpDownDNI
            // 
            this.numericUpDownDNI.Location = new System.Drawing.Point(172, 156);
            this.numericUpDownDNI.Name = "numericUpDownDNI";
            this.numericUpDownDNI.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDNI.TabIndex = 8;
            // 
            // numericUpDownExperiencia
            // 
            this.numericUpDownExperiencia.Location = new System.Drawing.Point(172, 188);
            this.numericUpDownExperiencia.Name = "numericUpDownExperiencia";
            this.numericUpDownExperiencia.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownExperiencia.TabIndex = 9;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(73, 245);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(100, 52);
            this.buttonCrear.TabIndex = 10;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(219, 245);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(97, 52);
            this.buttonValidar.TabIndex = 11;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // FormDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 336);
            this.Controls.Add(this.buttonValidar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.numericUpDownExperiencia);
            this.Controls.Add(this.numericUpDownDNI);
            this.Controls.Add(this.numericUpDownEdad);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.labelExperiencia);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormDT";
            this.Text = "FormDT";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelNombre;
    private System.Windows.Forms.Label labelApellido;
    private System.Windows.Forms.Label labelEdad;
    private System.Windows.Forms.Label labelDNI;
    private System.Windows.Forms.Label labelExperiencia;
    private System.Windows.Forms.TextBox textBoxApellido;
    private System.Windows.Forms.TextBox textBoxNombre;
    private System.Windows.Forms.NumericUpDown numericUpDownEdad;
    private System.Windows.Forms.NumericUpDown numericUpDownDNI;
    private System.Windows.Forms.NumericUpDown numericUpDownExperiencia;
    private System.Windows.Forms.Button buttonCrear;
    private System.Windows.Forms.Button buttonValidar;
  }
}


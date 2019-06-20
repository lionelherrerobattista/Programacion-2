namespace Ejercicio_25
{
    partial class FrmConversorNumerico
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
            this.lblBinarioDecimal = new System.Windows.Forms.Label();
            this.lblDecimalBinario = new System.Windows.Forms.Label();
            this.txtBinarioOrigen = new System.Windows.Forms.TextBox();
            this.txtDecimalOrigen = new System.Windows.Forms.TextBox();
            this.txtDecimalDestino = new System.Windows.Forms.TextBox();
            this.txtBinarioDestino = new System.Windows.Forms.TextBox();
            this.btnBinarioDecimal = new System.Windows.Forms.Button();
            this.btnDecimalBinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBinarioDecimal
            // 
            this.lblBinarioDecimal.AutoSize = true;
            this.lblBinarioDecimal.Location = new System.Drawing.Point(6, 25);
            this.lblBinarioDecimal.Name = "lblBinarioDecimal";
            this.lblBinarioDecimal.Size = new System.Drawing.Size(89, 13);
            this.lblBinarioDecimal.TabIndex = 0;
            this.lblBinarioDecimal.Text = "Binario a Decimal";
            // 
            // lblDecimalBinario
            // 
            this.lblDecimalBinario.AutoSize = true;
            this.lblDecimalBinario.Location = new System.Drawing.Point(6, 66);
            this.lblDecimalBinario.Name = "lblDecimalBinario";
            this.lblDecimalBinario.Size = new System.Drawing.Size(89, 13);
            this.lblDecimalBinario.TabIndex = 1;
            this.lblDecimalBinario.Text = "Decimal a Binario";
            // 
            // txtBinarioOrigen
            // 
            this.txtBinarioOrigen.Location = new System.Drawing.Point(101, 22);
            this.txtBinarioOrigen.Name = "txtBinarioOrigen";
            this.txtBinarioOrigen.Size = new System.Drawing.Size(100, 20);
            this.txtBinarioOrigen.TabIndex = 2;
            // 
            // txtDecimalOrigen
            // 
            this.txtDecimalOrigen.Location = new System.Drawing.Point(101, 63);
            this.txtDecimalOrigen.Name = "txtDecimalOrigen";
            this.txtDecimalOrigen.Size = new System.Drawing.Size(100, 20);
            this.txtDecimalOrigen.TabIndex = 3;
            // 
            // txtDecimalDestino
            // 
            this.txtDecimalDestino.Enabled = false;
            this.txtDecimalDestino.Location = new System.Drawing.Point(298, 22);
            this.txtDecimalDestino.Name = "txtDecimalDestino";
            this.txtDecimalDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDecimalDestino.TabIndex = 4;
            // 
            // txtBinarioDestino
            // 
            this.txtBinarioDestino.Enabled = false;
            this.txtBinarioDestino.Location = new System.Drawing.Point(298, 66);
            this.txtBinarioDestino.Name = "txtBinarioDestino";
            this.txtBinarioDestino.Size = new System.Drawing.Size(100, 20);
            this.txtBinarioDestino.TabIndex = 5;
            // 
            // btnBinarioDecimal
            // 
            this.btnBinarioDecimal.Location = new System.Drawing.Point(207, 20);
            this.btnBinarioDecimal.Name = "btnBinarioDecimal";
            this.btnBinarioDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnBinarioDecimal.TabIndex = 6;
            this.btnBinarioDecimal.Text = "->";
            this.btnBinarioDecimal.UseVisualStyleBackColor = true;
            this.btnBinarioDecimal.Click += new System.EventHandler(this.btnBinarioDecimal_Click);
            // 
            // btnDecimalBinario
            // 
            this.btnDecimalBinario.Location = new System.Drawing.Point(207, 63);
            this.btnDecimalBinario.Name = "btnDecimalBinario";
            this.btnDecimalBinario.Size = new System.Drawing.Size(75, 23);
            this.btnDecimalBinario.TabIndex = 7;
            this.btnDecimalBinario.Text = "->";
            this.btnDecimalBinario.UseVisualStyleBackColor = true;
            this.btnDecimalBinario.Click += new System.EventHandler(this.btnDecimalBinario_Click);
            // 
            // FrmConversorNumerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 110);
            this.Controls.Add(this.btnDecimalBinario);
            this.Controls.Add(this.btnBinarioDecimal);
            this.Controls.Add(this.txtBinarioDestino);
            this.Controls.Add(this.txtDecimalDestino);
            this.Controls.Add(this.txtDecimalOrigen);
            this.Controls.Add(this.txtBinarioOrigen);
            this.Controls.Add(this.lblDecimalBinario);
            this.Controls.Add(this.lblBinarioDecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmConversorNumerico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Numérico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinarioDecimal;
        private System.Windows.Forms.Label lblDecimalBinario;
        private System.Windows.Forms.TextBox txtBinarioOrigen;
        private System.Windows.Forms.TextBox txtDecimalOrigen;
        private System.Windows.Forms.TextBox txtDecimalDestino;
        private System.Windows.Forms.TextBox txtBinarioDestino;
        private System.Windows.Forms.Button btnBinarioDecimal;
        private System.Windows.Forms.Button btnDecimalBinario;
    }
}


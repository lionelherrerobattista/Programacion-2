namespace CentralitaForm
{
    partial class FrmMostrar
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
            this.rtbFacturacionTotal = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbFacturacionTotal
            // 
            this.rtbFacturacionTotal.Location = new System.Drawing.Point(0, 0);
            this.rtbFacturacionTotal.Name = "rtbFacturacionTotal";
            this.rtbFacturacionTotal.ReadOnly = true;
            this.rtbFacturacionTotal.Size = new System.Drawing.Size(514, 396);
            this.rtbFacturacionTotal.TabIndex = 0;
            this.rtbFacturacionTotal.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 397);
            this.Controls.Add(this.rtbFacturacionTotal);
            this.Name = "FrmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.FacturacionTotal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFacturacionTotal;
    }
}
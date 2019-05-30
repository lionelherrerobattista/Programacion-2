namespace Ejercicio_56
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
            this.mstArchivo = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbEditorDeTexto = new System.Windows.Forms.RichTextBox();
            this.stsContadorCaracteres = new System.Windows.Forms.StatusStrip();
            this.tslCantidadCaracteres = new System.Windows.Forms.ToolStripStatusLabel();
            this.mstArchivo.SuspendLayout();
            this.stsContadorCaracteres.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstArchivo
            // 
            this.mstArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mstArchivo.Location = new System.Drawing.Point(0, 0);
            this.mstArchivo.Name = "mstArchivo";
            this.mstArchivo.Size = new System.Drawing.Size(678, 24);
            this.mstArchivo.TabIndex = 0;
            this.mstArchivo.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // rtbEditorDeTexto
            // 
            this.rtbEditorDeTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEditorDeTexto.Location = new System.Drawing.Point(0, 27);
            this.rtbEditorDeTexto.Name = "rtbEditorDeTexto";
            this.rtbEditorDeTexto.Size = new System.Drawing.Size(678, 368);
            this.rtbEditorDeTexto.TabIndex = 1;
            this.rtbEditorDeTexto.Text = "";
            this.rtbEditorDeTexto.TextChanged += new System.EventHandler(this.rtbEditorDeTexto_TextChanged);
            // 
            // stsContadorCaracteres
            // 
            this.stsContadorCaracteres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCantidadCaracteres});
            this.stsContadorCaracteres.Location = new System.Drawing.Point(0, 395);
            this.stsContadorCaracteres.Name = "stsContadorCaracteres";
            this.stsContadorCaracteres.Size = new System.Drawing.Size(678, 22);
            this.stsContadorCaracteres.TabIndex = 2;
            this.stsContadorCaracteres.Text = "statusStrip1";
            // 
            // tslCantidadCaracteres
            // 
            this.tslCantidadCaracteres.Name = "tslCantidadCaracteres";
            this.tslCantidadCaracteres.Size = new System.Drawing.Size(62, 17);
            this.tslCantidadCaracteres.Text = "Caracteres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 417);
            this.Controls.Add(this.stsContadorCaracteres);
            this.Controls.Add(this.rtbEditorDeTexto);
            this.Controls.Add(this.mstArchivo);
            this.MainMenuStrip = this.mstArchivo;
            this.Name = "Form1";
            this.Text = "Ejercicio 56";
            this.mstArchivo.ResumeLayout(false);
            this.mstArchivo.PerformLayout();
            this.stsContadorCaracteres.ResumeLayout(false);
            this.stsContadorCaracteres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstArchivo;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbEditorDeTexto;
        private System.Windows.Forms.StatusStrip stsContadorCaracteres;
        private System.Windows.Forms.ToolStripStatusLabel tslCantidadCaracteres;
    }
}


namespace ConversorDinero
{
    partial class Conversor_Dinero
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
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPesosAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtPesosADolar = new System.Windows.Forms.TextBox();
            this.btnConverEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPesos = new System.Windows.Forms.Button();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblPesos = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEuroAPesos = new System.Windows.Forms.TextBox();
            this.txtDolarAPesos = new System.Windows.Forms.TextBox();
            this.txtPesosAPesos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEuro
            // 
            this.txtEuro.BackColor = System.Drawing.SystemColors.Window;
            this.txtEuro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEuro.Location = new System.Drawing.Point(106, 45);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 0;
            this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEuro.TextChanged += new System.EventHandler(this.txtEuro_TextChanged);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(106, 71);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 1;
            this.txtDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(106, 100);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesos.TabIndex = 2;
            this.txtPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesos.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Enabled = false;
            this.txtEuroAEuro.Location = new System.Drawing.Point(310, 47);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAEuro.TabIndex = 3;
            this.txtEuroAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEuroAEuro.TextChanged += new System.EventHandler(this.txtEuroAEuro_TextChanged);
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Enabled = false;
            this.txtDolarAEuro.Location = new System.Drawing.Point(310, 75);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAEuro.TabIndex = 4;
            this.txtDolarAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesosAEuro
            // 
            this.txtPesosAEuro.Enabled = false;
            this.txtPesosAEuro.Location = new System.Drawing.Point(310, 99);
            this.txtPesosAEuro.Name = "txtPesosAEuro";
            this.txtPesosAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesosAEuro.TabIndex = 5;
            this.txtPesosAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Enabled = false;
            this.txtEuroADolar.Location = new System.Drawing.Point(416, 48);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroADolar.TabIndex = 6;
            this.txtEuroADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Enabled = false;
            this.txtDolarADolar.Location = new System.Drawing.Point(416, 75);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarADolar.TabIndex = 7;
            this.txtDolarADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesosADolar
            // 
            this.txtPesosADolar.Enabled = false;
            this.txtPesosADolar.Location = new System.Drawing.Point(416, 99);
            this.txtPesosADolar.Name = "txtPesosADolar";
            this.txtPesosADolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesosADolar.TabIndex = 8;
            this.txtPesosADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConverEuro
            // 
            this.btnConverEuro.Location = new System.Drawing.Point(217, 45);
            this.btnConverEuro.Name = "btnConverEuro";
            this.btnConverEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConverEuro.TabIndex = 9;
            this.btnConverEuro.Text = "->";
            this.btnConverEuro.UseVisualStyleBackColor = true;
            this.btnConverEuro.Click += new System.EventHandler(this.btnConverEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(217, 73);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 10;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPesos
            // 
            this.btnConvertPesos.Location = new System.Drawing.Point(217, 99);
            this.btnConvertPesos.Name = "btnConvertPesos";
            this.btnConvertPesos.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPesos.TabIndex = 11;
            this.btnConvertPesos.Text = "->";
            this.btnConvertPesos.UseVisualStyleBackColor = true;
            this.btnConvertPesos.Click += new System.EventHandler(this.btnConvertPesos_Click);
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(28, 49);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 12;
            this.lblEuro.Text = "Euro";
            this.lblEuro.Click += new System.EventHandler(this.lblEuro_Click);
            // 
            // lblPesos
            // 
            this.lblPesos.Location = new System.Drawing.Point(28, 102);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(41, 20);
            this.lblPesos.TabIndex = 13;
            this.lblPesos.Text = "Pesos";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(28, 78);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 14;
            this.lblDolar.Text = "Dólar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dólar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(550, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pesos";
            // 
            // txtEuroAPesos
            // 
            this.txtEuroAPesos.Enabled = false;
            this.txtEuroAPesos.Location = new System.Drawing.Point(522, 49);
            this.txtEuroAPesos.Name = "txtEuroAPesos";
            this.txtEuroAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAPesos.TabIndex = 18;
            this.txtEuroAPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDolarAPesos
            // 
            this.txtDolarAPesos.Enabled = false;
            this.txtDolarAPesos.Location = new System.Drawing.Point(522, 75);
            this.txtDolarAPesos.Name = "txtDolarAPesos";
            this.txtDolarAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAPesos.TabIndex = 19;
            this.txtDolarAPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesosAPesos
            // 
            this.txtPesosAPesos.Enabled = false;
            this.txtPesosAPesos.Location = new System.Drawing.Point(522, 99);
            this.txtPesosAPesos.Name = "txtPesosAPesos";
            this.txtPesosAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesosAPesos.TabIndex = 20;
            this.txtPesosAPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Conversor_Dinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 150);
            this.Controls.Add(this.txtPesosAPesos);
            this.Controls.Add(this.txtDolarAPesos);
            this.Controls.Add(this.txtEuroAPesos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.btnConvertPesos);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConverEuro);
            this.Controls.Add(this.txtPesosADolar);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtPesosAEuro);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Name = "Conversor_Dinero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Dinero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtPesosAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtPesosADolar;
        private System.Windows.Forms.Button btnConverEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPesos;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEuroAPesos;
        private System.Windows.Forms.TextBox txtDolarAPesos;
        private System.Windows.Forms.TextBox txtPesosAPesos;
    }
}
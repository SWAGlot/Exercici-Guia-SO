namespace Exercici_Guia
{
    partial class Finestra
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
            this.Connecta = new System.Windows.Forms.Button();
            this.Envia = new System.Windows.Forms.Button();
            this.Desconnecta = new System.Windows.Forms.Button();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bellesa = new System.Windows.Forms.RadioButton();
            this.Estatura = new System.Windows.Forms.RadioButton();
            this.Palindrom = new System.Windows.Forms.RadioButton();
            this.Majúscula = new System.Windows.Forms.RadioButton();
            this.Lletres = new System.Windows.Forms.TextBox();
            this.Nombres = new System.Windows.Forms.TextBox();
            this.Quants_serveis = new System.Windows.Forms.Button();
            this.Quantitat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Connecta
            // 
            this.Connecta.Location = new System.Drawing.Point(211, 26);
            this.Connecta.Name = "Connecta";
            this.Connecta.Size = new System.Drawing.Size(75, 23);
            this.Connecta.TabIndex = 0;
            this.Connecta.Text = "Connecta";
            this.Connecta.UseVisualStyleBackColor = true;
            this.Connecta.Click += new System.EventHandler(this.Connecta_Click);
            // 
            // Envia
            // 
            this.Envia.Location = new System.Drawing.Point(111, 98);
            this.Envia.Name = "Envia";
            this.Envia.Size = new System.Drawing.Size(75, 23);
            this.Envia.TabIndex = 1;
            this.Envia.Text = "Envia";
            this.Envia.UseVisualStyleBackColor = true;
            this.Envia.Click += new System.EventHandler(this.Envia_Click);
            // 
            // Desconnecta
            // 
            this.Desconnecta.Location = new System.Drawing.Point(211, 56);
            this.Desconnecta.Name = "Desconnecta";
            this.Desconnecta.Size = new System.Drawing.Size(82, 23);
            this.Desconnecta.TabIndex = 2;
            this.Desconnecta.Text = "Desconnecta";
            this.Desconnecta.UseVisualStyleBackColor = true;
            this.Desconnecta.Click += new System.EventHandler(this.Desconnecta_Click);
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(12, 8);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(66, 17);
            this.Longitud.TabIndex = 3;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Longitud";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bellesa
            // 
            this.Bellesa.AutoSize = true;
            this.Bellesa.Location = new System.Drawing.Point(12, 32);
            this.Bellesa.Name = "Bellesa";
            this.Bellesa.Size = new System.Drawing.Size(59, 17);
            this.Bellesa.TabIndex = 4;
            this.Bellesa.TabStop = true;
            this.Bellesa.Text = "Bellesa";
            this.Bellesa.UseVisualStyleBackColor = true;
            // 
            // Estatura
            // 
            this.Estatura.AutoSize = true;
            this.Estatura.Location = new System.Drawing.Point(12, 56);
            this.Estatura.Name = "Estatura";
            this.Estatura.Size = new System.Drawing.Size(64, 17);
            this.Estatura.TabIndex = 5;
            this.Estatura.TabStop = true;
            this.Estatura.Text = "Estatura";
            this.Estatura.UseVisualStyleBackColor = true;
            // 
            // Palindrom
            // 
            this.Palindrom.AutoSize = true;
            this.Palindrom.Location = new System.Drawing.Point(12, 80);
            this.Palindrom.Name = "Palindrom";
            this.Palindrom.Size = new System.Drawing.Size(73, 17);
            this.Palindrom.TabIndex = 6;
            this.Palindrom.TabStop = true;
            this.Palindrom.Text = "Palíndrom";
            this.Palindrom.UseVisualStyleBackColor = true;
            // 
            // Majúscula
            // 
            this.Majúscula.AutoSize = true;
            this.Majúscula.Location = new System.Drawing.Point(12, 104);
            this.Majúscula.Name = "Majúscula";
            this.Majúscula.Size = new System.Drawing.Size(73, 17);
            this.Majúscula.TabIndex = 7;
            this.Majúscula.TabStop = true;
            this.Majúscula.Text = "Majúscula";
            this.Majúscula.UseVisualStyleBackColor = true;
            // 
            // Lletres
            // 
            this.Lletres.Location = new System.Drawing.Point(86, 55);
            this.Lletres.Name = "Lletres";
            this.Lletres.Size = new System.Drawing.Size(100, 20);
            this.Lletres.TabIndex = 8;
            // 
            // Nombres
            // 
            this.Nombres.Location = new System.Drawing.Point(211, 101);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(100, 20);
            this.Nombres.TabIndex = 9;
            // 
            // Quants_serveis
            // 
            this.Quants_serveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quants_serveis.Location = new System.Drawing.Point(12, 134);
            this.Quants_serveis.Name = "Quants_serveis";
            this.Quants_serveis.Size = new System.Drawing.Size(85, 60);
            this.Quants_serveis.TabIndex = 10;
            this.Quants_serveis.Text = "Quants serveis?";
            this.Quants_serveis.UseVisualStyleBackColor = true;
            this.Quants_serveis.Click += new System.EventHandler(this.Quants_serveis_Click);
            // 
            // Quantitat
            // 
            this.Quantitat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quantitat.Location = new System.Drawing.Point(111, 134);
            this.Quantitat.Name = "Quantitat";
            this.Quantitat.Size = new System.Drawing.Size(100, 60);
            this.Quantitat.TabIndex = 11;
            // 
            // Finestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 206);
            this.Controls.Add(this.Quantitat);
            this.Controls.Add(this.Quants_serveis);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.Lletres);
            this.Controls.Add(this.Majúscula);
            this.Controls.Add(this.Palindrom);
            this.Controls.Add(this.Estatura);
            this.Controls.Add(this.Bellesa);
            this.Controls.Add(this.Longitud);
            this.Controls.Add(this.Desconnecta);
            this.Controls.Add(this.Envia);
            this.Controls.Add(this.Connecta);
            this.Name = "Finestra";
            this.Text = "Finestra";
            this.Load += new System.EventHandler(this.Finestra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connecta;
        private System.Windows.Forms.Button Envia;
        private System.Windows.Forms.Button Desconnecta;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bellesa;
        private System.Windows.Forms.RadioButton Estatura;
        private System.Windows.Forms.RadioButton Palindrom;
        private System.Windows.Forms.RadioButton Majúscula;
        private System.Windows.Forms.TextBox Lletres;
        private System.Windows.Forms.TextBox Nombres;
        private System.Windows.Forms.Button Quants_serveis;
        private System.Windows.Forms.Label Quantitat;
    }
}


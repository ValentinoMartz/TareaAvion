namespace WindowsAvionesApp
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
            this.btnCrearAvionComercial = new System.Windows.Forms.Button();
            this.btnCrearAvionCarga = new System.Windows.Forms.Button();
            this.btnDespegaCarga = new System.Windows.Forms.Button();
            this.btnAterrizaCarga = new System.Windows.Forms.Button();
            this.btnComercialDespega = new System.Windows.Forms.Button();
            this.btnComercialAterriza = new System.Windows.Forms.Button();
            this.btnComercialToString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearAvionComercial
            // 
            this.btnCrearAvionComercial.Location = new System.Drawing.Point(93, 64);
            this.btnCrearAvionComercial.Name = "btnCrearAvionComercial";
            this.btnCrearAvionComercial.Size = new System.Drawing.Size(417, 37);
            this.btnCrearAvionComercial.TabIndex = 1;
            this.btnCrearAvionComercial.Text = "Avion Comercial";
            this.btnCrearAvionComercial.UseVisualStyleBackColor = true;
            this.btnCrearAvionComercial.Click += new System.EventHandler(this.btnCrearAvionComercial_Click);
            // 
            // btnCrearAvionCarga
            // 
            this.btnCrearAvionCarga.Location = new System.Drawing.Point(93, 303);
            this.btnCrearAvionCarga.Name = "btnCrearAvionCarga";
            this.btnCrearAvionCarga.Size = new System.Drawing.Size(417, 38);
            this.btnCrearAvionCarga.TabIndex = 2;
            this.btnCrearAvionCarga.Text = "Avion de Carga";
            this.btnCrearAvionCarga.UseVisualStyleBackColor = true;
            this.btnCrearAvionCarga.Click += new System.EventHandler(this.btnCrearAvionCarga_Click);
            // 
            // btnDespegaCarga
            // 
            this.btnDespegaCarga.Location = new System.Drawing.Point(93, 388);
            this.btnDespegaCarga.Name = "btnDespegaCarga";
            this.btnDespegaCarga.Size = new System.Drawing.Size(121, 36);
            this.btnDespegaCarga.TabIndex = 9;
            this.btnDespegaCarga.Text = "Despega";
            this.btnDespegaCarga.UseVisualStyleBackColor = true;
            this.btnDespegaCarga.Click += new System.EventHandler(this.btnDespegaCarga_Click);
            // 
            // btnAterrizaCarga
            // 
            this.btnAterrizaCarga.Location = new System.Drawing.Point(389, 388);
            this.btnAterrizaCarga.Name = "btnAterrizaCarga";
            this.btnAterrizaCarga.Size = new System.Drawing.Size(121, 36);
            this.btnAterrizaCarga.TabIndex = 10;
            this.btnAterrizaCarga.Text = "Aterriza";
            this.btnAterrizaCarga.UseVisualStyleBackColor = true;
            this.btnAterrizaCarga.Click += new System.EventHandler(this.btnAterrizaCarga_Click);
            // 
            // btnComercialDespega
            // 
            this.btnComercialDespega.Location = new System.Drawing.Point(12, 148);
            this.btnComercialDespega.Name = "btnComercialDespega";
            this.btnComercialDespega.Size = new System.Drawing.Size(121, 36);
            this.btnComercialDespega.TabIndex = 11;
            this.btnComercialDespega.Text = "Despega";
            this.btnComercialDespega.UseVisualStyleBackColor = true;
            this.btnComercialDespega.Click += new System.EventHandler(this.btnComercialDespega_Click);
            // 
            // btnComercialAterriza
            // 
            this.btnComercialAterriza.Location = new System.Drawing.Point(243, 148);
            this.btnComercialAterriza.Name = "btnComercialAterriza";
            this.btnComercialAterriza.Size = new System.Drawing.Size(121, 36);
            this.btnComercialAterriza.TabIndex = 12;
            this.btnComercialAterriza.Text = "Aterriza";
            this.btnComercialAterriza.UseVisualStyleBackColor = true;
            this.btnComercialAterriza.Click += new System.EventHandler(this.btnComercialAterriza_Click);
            // 
            // btnComercialToString
            // 
            this.btnComercialToString.Location = new System.Drawing.Point(462, 148);
            this.btnComercialToString.Name = "btnComercialToString";
            this.btnComercialToString.Size = new System.Drawing.Size(121, 36);
            this.btnComercialToString.TabIndex = 13;
            this.btnComercialToString.Text = "ToString";
            this.btnComercialToString.UseVisualStyleBackColor = true;
            this.btnComercialToString.Click += new System.EventHandler(this.btnComercialToString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 474);
            this.Controls.Add(this.btnComercialToString);
            this.Controls.Add(this.btnComercialAterriza);
            this.Controls.Add(this.btnComercialDespega);
            this.Controls.Add(this.btnAterrizaCarga);
            this.Controls.Add(this.btnDespegaCarga);
            this.Controls.Add(this.btnCrearAvionCarga);
            this.Controls.Add(this.btnCrearAvionComercial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCrearAvionComercial;
        private System.Windows.Forms.Button btnCrearAvionCarga;
        private System.Windows.Forms.Button btnDespegaCarga;
        private System.Windows.Forms.Button btnAterrizaCarga;
        private System.Windows.Forms.Button btnComercialDespega;
        private System.Windows.Forms.Button btnComercialAterriza;
        private System.Windows.Forms.Button btnComercialToString;
    }
}


namespace Numeros_pares_y_impares
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbNumeros = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.lbPares = new System.Windows.Forms.ListBox();
            this.lbImpares = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite un numero:";
            // 
            // TbNumeros
            // 
            this.TbNumeros.Location = new System.Drawing.Point(190, 50);
            this.TbNumeros.Name = "TbNumeros";
            this.TbNumeros.Size = new System.Drawing.Size(301, 22);
            this.TbNumeros.TabIndex = 2;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(294, 384);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(95, 37);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lbPares
            // 
            this.lbPares.FormattingEnabled = true;
            this.lbPares.ItemHeight = 16;
            this.lbPares.Location = new System.Drawing.Point(110, 110);
            this.lbPares.Name = "lbPares";
            this.lbPares.Size = new System.Drawing.Size(170, 228);
            this.lbPares.TabIndex = 4;
            // 
            // lbImpares
            // 
            this.lbImpares.FormattingEnabled = true;
            this.lbImpares.ItemHeight = 16;
            this.lbImpares.Location = new System.Drawing.Point(373, 110);
            this.lbImpares.Name = "lbImpares";
            this.lbImpares.Size = new System.Drawing.Size(174, 228);
            this.lbImpares.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.lbImpares);
            this.Controls.Add(this.lbPares);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TbNumeros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbNumeros;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ListBox lbPares;
        private System.Windows.Forms.ListBox lbImpares;
    }
}


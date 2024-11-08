namespace Numeros_pares_y_impares
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.lbOtros = new System.Windows.Forms.ListBox();
            this.btnAgg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(112, 34);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(159, 22);
            this.tbCantidad.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(523, 37);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(152, 22);
            this.tbNombre.TabIndex = 3;
            // 
            // lbNombres
            // 
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.ItemHeight = 16;
            this.lbNombres.Location = new System.Drawing.Point(83, 99);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(215, 260);
            this.lbNombres.TabIndex = 4;
            // 
            // lbOtros
            // 
            this.lbOtros.FormattingEnabled = true;
            this.lbOtros.ItemHeight = 16;
            this.lbOtros.Location = new System.Drawing.Point(482, 99);
            this.lbOtros.Name = "lbOtros";
            this.lbOtros.Size = new System.Drawing.Size(212, 260);
            this.lbOtros.TabIndex = 5;
            // 
            // btnAgg
            // 
            this.btnAgg.Location = new System.Drawing.Point(348, 387);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(104, 34);
            this.btnAgg.TabIndex = 6;
            this.btnAgg.Text = "Agregar";
            this.btnAgg.UseVisualStyleBackColor = true;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.lbOtros);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ListBox lbNombres;
        private System.Windows.Forms.ListBox lbOtros;
        private System.Windows.Forms.Button btnAgg;
    }
}
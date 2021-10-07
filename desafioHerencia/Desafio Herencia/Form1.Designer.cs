
namespace Desafio_Herencia
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
            this.boxInmueble = new System.Windows.Forms.GroupBox();
            this.lblventanas = new System.Windows.Forms.Label();
            this.lblpiso = new System.Windows.Forms.Label();
            this.textBoxNroDeVentanas = new System.Windows.Forms.TextBox();
            this.textBoxPisoNro = new System.Windows.Forms.TextBox();
            this.radioLocal = new System.Windows.Forms.RadioButton();
            this.radioPiso = new System.Windows.Forms.RadioButton();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.textBoxSuperficie = new System.Windows.Forms.TextBox();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.textBoxAntiguedad = new System.Windows.Forms.TextBox();
            this.textBoxPrecioBase = new System.Windows.Forms.TextBox();
            this.labelm2 = new System.Windows.Forms.Label();
            this.labelAños = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.boxInmueble.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxInmueble
            // 
            this.boxInmueble.Controls.Add(this.lblventanas);
            this.boxInmueble.Controls.Add(this.lblpiso);
            this.boxInmueble.Controls.Add(this.textBoxNroDeVentanas);
            this.boxInmueble.Controls.Add(this.textBoxPisoNro);
            this.boxInmueble.Controls.Add(this.radioLocal);
            this.boxInmueble.Controls.Add(this.radioPiso);
            this.boxInmueble.Location = new System.Drawing.Point(12, 13);
            this.boxInmueble.Name = "boxInmueble";
            this.boxInmueble.Size = new System.Drawing.Size(217, 103);
            this.boxInmueble.TabIndex = 0;
            this.boxInmueble.TabStop = false;
            this.boxInmueble.Text = "Tipo de Inmueble";
            // 
            // lblventanas
            // 
            this.lblventanas.AutoSize = true;
            this.lblventanas.Location = new System.Drawing.Point(109, 61);
            this.lblventanas.Name = "lblventanas";
            this.lblventanas.Size = new System.Drawing.Size(86, 13);
            this.lblventanas.TabIndex = 3;
            this.lblventanas.Text = "&Nro de ventanas";
            // 
            // lblpiso
            // 
            this.lblpiso.AutoSize = true;
            this.lblpiso.Location = new System.Drawing.Point(16, 61);
            this.lblpiso.Name = "lblpiso";
            this.lblpiso.Size = new System.Drawing.Size(47, 13);
            this.lblpiso.TabIndex = 1;
            this.lblpiso.Text = "&Piso Nro";
            // 
            // textBoxNroDeVentanas
            // 
            this.textBoxNroDeVentanas.Enabled = false;
            this.textBoxNroDeVentanas.Location = new System.Drawing.Point(116, 77);
            this.textBoxNroDeVentanas.Name = "textBoxNroDeVentanas";
            this.textBoxNroDeVentanas.Size = new System.Drawing.Size(79, 20);
            this.textBoxNroDeVentanas.TabIndex = 2;
            // 
            // textBoxPisoNro
            // 
            this.textBoxPisoNro.Enabled = false;
            this.textBoxPisoNro.Location = new System.Drawing.Point(19, 77);
            this.textBoxPisoNro.Name = "textBoxPisoNro";
            this.textBoxPisoNro.Size = new System.Drawing.Size(60, 20);
            this.textBoxPisoNro.TabIndex = 1;
            // 
            // radioLocal
            // 
            this.radioLocal.AutoSize = true;
            this.radioLocal.Location = new System.Drawing.Point(116, 33);
            this.radioLocal.Name = "radioLocal";
            this.radioLocal.Size = new System.Drawing.Size(51, 17);
            this.radioLocal.TabIndex = 1;
            this.radioLocal.TabStop = true;
            this.radioLocal.Text = "Local";
            this.radioLocal.UseVisualStyleBackColor = true;
            this.radioLocal.CheckedChanged += new System.EventHandler(this.radioLocal_CheckedChanged);
            // 
            // radioPiso
            // 
            this.radioPiso.AutoSize = true;
            this.radioPiso.Location = new System.Drawing.Point(34, 33);
            this.radioPiso.Name = "radioPiso";
            this.radioPiso.Size = new System.Drawing.Size(45, 17);
            this.radioPiso.TabIndex = 0;
            this.radioPiso.TabStop = true;
            this.radioPiso.Text = "Piso";
            this.radioPiso.UseVisualStyleBackColor = true;
            this.radioPiso.CheckedChanged += new System.EventHandler(this.radioPiso_CheckedChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(9, 138);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(54, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "&Direccíon";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(12, 154);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(213, 20);
            this.textBoxDireccion.TabIndex = 2;
            // 
            // lblSuperficie
            // 
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.Location = new System.Drawing.Point(9, 188);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(54, 13);
            this.lblSuperficie.TabIndex = 3;
            this.lblSuperficie.Text = "&Superficie";
            // 
            // textBoxSuperficie
            // 
            this.textBoxSuperficie.Location = new System.Drawing.Point(12, 204);
            this.textBoxSuperficie.Name = "textBoxSuperficie";
            this.textBoxSuperficie.Size = new System.Drawing.Size(51, 20);
            this.textBoxSuperficie.TabIndex = 4;
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(82, 188);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(61, 13);
            this.lblAntiguedad.TabIndex = 5;
            this.lblAntiguedad.Text = "&Antiguedad";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(162, 188);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(63, 13);
            this.lblPrecioBase.TabIndex = 6;
            this.lblPrecioBase.Text = "&Precio base";
            // 
            // textBoxAntiguedad
            // 
            this.textBoxAntiguedad.Location = new System.Drawing.Point(91, 204);
            this.textBoxAntiguedad.Name = "textBoxAntiguedad";
            this.textBoxAntiguedad.Size = new System.Drawing.Size(32, 20);
            this.textBoxAntiguedad.TabIndex = 7;
            // 
            // textBoxPrecioBase
            // 
            this.textBoxPrecioBase.Location = new System.Drawing.Point(165, 204);
            this.textBoxPrecioBase.Name = "textBoxPrecioBase";
            this.textBoxPrecioBase.Size = new System.Drawing.Size(60, 20);
            this.textBoxPrecioBase.TabIndex = 8;
            // 
            // labelm2
            // 
            this.labelm2.AutoSize = true;
            this.labelm2.Location = new System.Drawing.Point(64, 207);
            this.labelm2.Name = "labelm2";
            this.labelm2.Size = new System.Drawing.Size(27, 13);
            this.labelm2.TabIndex = 9;
            this.labelm2.Text = "(m2)";
            // 
            // labelAños
            // 
            this.labelAños.AutoSize = true;
            this.labelAños.Location = new System.Drawing.Point(125, 207);
            this.labelAños.Name = "labelAños";
            this.labelAños.Size = new System.Drawing.Size(36, 13);
            this.labelAños.TabIndex = 10;
            this.labelAños.Text = "(años)";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 243);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(213, 41);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "&Calcular Precio Final";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPrecio.Location = new System.Drawing.Point(12, 287);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblPrecio.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 344);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labelAños);
            this.Controls.Add(this.textBoxPrecioBase);
            this.Controls.Add(this.textBoxAntiguedad);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.textBoxSuperficie);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.boxInmueble);
            this.Controls.Add(this.labelm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.boxInmueble.ResumeLayout(false);
            this.boxInmueble.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxInmueble;
        private System.Windows.Forms.Label lblventanas;
        private System.Windows.Forms.Label lblpiso;
        private System.Windows.Forms.TextBox textBoxNroDeVentanas;
        private System.Windows.Forms.TextBox textBoxPisoNro;
        private System.Windows.Forms.RadioButton radioLocal;
        private System.Windows.Forms.RadioButton radioPiso;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label lblSuperficie;
        private System.Windows.Forms.TextBox textBoxSuperficie;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.TextBox textBoxAntiguedad;
        private System.Windows.Forms.TextBox textBoxPrecioBase;
        private System.Windows.Forms.Label labelm2;
        private System.Windows.Forms.Label labelAños;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPrecio;
    }
}


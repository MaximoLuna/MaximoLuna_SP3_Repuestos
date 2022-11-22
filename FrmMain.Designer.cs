namespace MaximoLuna_SP3_Repuestos
{
    partial class FrmMain
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
            this.mrcConsultaRepuestos = new System.Windows.Forms.GroupBox();
            this.lstDatosRepuestos = new System.Windows.Forms.ListBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblMarcaConsulta = new System.Windows.Forms.Label();
            this.cmbMarcaConsulta = new System.Windows.Forms.ComboBox();
            this.mrcOrigenConsulta = new System.Windows.Forms.GroupBox();
            this.optNacionalConsulta = new System.Windows.Forms.RadioButton();
            this.optImportadoConsulta = new System.Windows.Forms.RadioButton();
            this.lblDatosRepuestos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.txtNumeroRepuesto = new System.Windows.Forms.TextBox();
            this.lblNumeroRepuesto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.mrcConsultaRepuestos.SuspendLayout();
            this.mrcOrigenConsulta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mrcOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcConsultaRepuestos
            // 
            this.mrcConsultaRepuestos.Controls.Add(this.lstDatosRepuestos);
            this.mrcConsultaRepuestos.Controls.Add(this.btnConsulta);
            this.mrcConsultaRepuestos.Controls.Add(this.lblMarcaConsulta);
            this.mrcConsultaRepuestos.Controls.Add(this.cmbMarcaConsulta);
            this.mrcConsultaRepuestos.Controls.Add(this.mrcOrigenConsulta);
            this.mrcConsultaRepuestos.Controls.Add(this.lblDatosRepuestos);
            this.mrcConsultaRepuestos.Enabled = false;
            this.mrcConsultaRepuestos.Location = new System.Drawing.Point(12, 194);
            this.mrcConsultaRepuestos.Name = "mrcConsultaRepuestos";
            this.mrcConsultaRepuestos.Size = new System.Drawing.Size(465, 210);
            this.mrcConsultaRepuestos.TabIndex = 14;
            this.mrcConsultaRepuestos.TabStop = false;
            this.mrcConsultaRepuestos.Text = "Consulta de Repuestos";
            // 
            // lstDatosRepuestos
            // 
            this.lstDatosRepuestos.FormattingEnabled = true;
            this.lstDatosRepuestos.Location = new System.Drawing.Point(225, 35);
            this.lstDatosRepuestos.Name = "lstDatosRepuestos";
            this.lstDatosRepuestos.Size = new System.Drawing.Size(229, 134);
            this.lstDatosRepuestos.TabIndex = 15;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Enabled = false;
            this.btnConsulta.Location = new System.Drawing.Point(384, 181);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 14;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // lblMarcaConsulta
            // 
            this.lblMarcaConsulta.AutoSize = true;
            this.lblMarcaConsulta.Location = new System.Drawing.Point(52, 19);
            this.lblMarcaConsulta.Name = "lblMarcaConsulta";
            this.lblMarcaConsulta.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaConsulta.TabIndex = 1;
            this.lblMarcaConsulta.Text = "Marca";
            // 
            // cmbMarcaConsulta
            // 
            this.cmbMarcaConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaConsulta.FormattingEnabled = true;
            this.cmbMarcaConsulta.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.cmbMarcaConsulta.Location = new System.Drawing.Point(95, 16);
            this.cmbMarcaConsulta.Name = "cmbMarcaConsulta";
            this.cmbMarcaConsulta.Size = new System.Drawing.Size(104, 21);
            this.cmbMarcaConsulta.TabIndex = 0;
            // 
            // mrcOrigenConsulta
            // 
            this.mrcOrigenConsulta.Controls.Add(this.optNacionalConsulta);
            this.mrcOrigenConsulta.Controls.Add(this.optImportadoConsulta);
            this.mrcOrigenConsulta.Location = new System.Drawing.Point(95, 43);
            this.mrcOrigenConsulta.Name = "mrcOrigenConsulta";
            this.mrcOrigenConsulta.Size = new System.Drawing.Size(104, 70);
            this.mrcOrigenConsulta.TabIndex = 4;
            this.mrcOrigenConsulta.TabStop = false;
            this.mrcOrigenConsulta.Text = "Origen";
            // 
            // optNacionalConsulta
            // 
            this.optNacionalConsulta.AutoSize = true;
            this.optNacionalConsulta.Checked = true;
            this.optNacionalConsulta.Location = new System.Drawing.Point(6, 19);
            this.optNacionalConsulta.Name = "optNacionalConsulta";
            this.optNacionalConsulta.Size = new System.Drawing.Size(67, 17);
            this.optNacionalConsulta.TabIndex = 2;
            this.optNacionalConsulta.TabStop = true;
            this.optNacionalConsulta.Text = "Nacional";
            this.optNacionalConsulta.UseVisualStyleBackColor = true;
            // 
            // optImportadoConsulta
            // 
            this.optImportadoConsulta.AutoSize = true;
            this.optImportadoConsulta.Location = new System.Drawing.Point(6, 42);
            this.optImportadoConsulta.Name = "optImportadoConsulta";
            this.optImportadoConsulta.Size = new System.Drawing.Size(72, 17);
            this.optImportadoConsulta.TabIndex = 3;
            this.optImportadoConsulta.Text = "Importado";
            this.optImportadoConsulta.UseVisualStyleBackColor = true;
            // 
            // lblDatosRepuestos
            // 
            this.lblDatosRepuestos.AutoSize = true;
            this.lblDatosRepuestos.Location = new System.Drawing.Point(222, 19);
            this.lblDatosRepuestos.Name = "lblDatosRepuestos";
            this.lblDatosRepuestos.Size = new System.Drawing.Size(104, 13);
            this.lblDatosRepuestos.TabIndex = 6;
            this.lblDatosRepuestos.Text = "Datos de Repuestos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistro);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.cmbMarca);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.mrcOrigen);
            this.groupBox1.Controls.Add(this.txtNumeroRepuesto);
            this.groupBox1.Controls.Add(this.lblNumeroRepuesto);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 159);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Repuestos";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Enabled = false;
            this.btnRegistro.Location = new System.Drawing.Point(384, 130);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnRegistro.TabIndex = 13;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(52, 19);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(291, 95);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(74, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.cmbMarca.Location = new System.Drawing.Point(95, 16);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(104, 21);
            this.cmbMarca.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(291, 16);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(163, 73);
            this.txtDescripcion.TabIndex = 9;
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.optNacional);
            this.mrcOrigen.Controls.Add(this.optImportado);
            this.mrcOrigen.Location = new System.Drawing.Point(95, 43);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(104, 70);
            this.mrcOrigen.TabIndex = 4;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Checked = true;
            this.optNacional.Location = new System.Drawing.Point(6, 19);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 2;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(6, 42);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 3;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // txtNumeroRepuesto
            // 
            this.txtNumeroRepuesto.Enabled = false;
            this.txtNumeroRepuesto.Location = new System.Drawing.Point(95, 119);
            this.txtNumeroRepuesto.MaxLength = 6;
            this.txtNumeroRepuesto.Name = "txtNumeroRepuesto";
            this.txtNumeroRepuesto.Size = new System.Drawing.Size(69, 20);
            this.txtNumeroRepuesto.TabIndex = 8;
            // 
            // lblNumeroRepuesto
            // 
            this.lblNumeroRepuesto.AutoSize = true;
            this.lblNumeroRepuesto.Enabled = false;
            this.lblNumeroRepuesto.Location = new System.Drawing.Point(6, 122);
            this.lblNumeroRepuesto.Name = "lblNumeroRepuesto";
            this.lblNumeroRepuesto.Size = new System.Drawing.Size(83, 13);
            this.lblNumeroRepuesto.TabIndex = 5;
            this.lblNumeroRepuesto.Text = "Nº de Repuesto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Enabled = false;
            this.lblPrecio.Location = new System.Drawing.Point(248, 98);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Enabled = false;
            this.lblDescripcion.Location = new System.Drawing.Point(222, 19);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 418);
            this.Controls.Add(this.mrcConsultaRepuestos);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Registro de Autopartes";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mrcConsultaRepuestos.ResumeLayout(false);
            this.mrcConsultaRepuestos.PerformLayout();
            this.mrcOrigenConsulta.ResumeLayout(false);
            this.mrcOrigenConsulta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcConsultaRepuestos;
        private System.Windows.Forms.ListBox lstDatosRepuestos;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblMarcaConsulta;
        private System.Windows.Forms.ComboBox cmbMarcaConsulta;
        private System.Windows.Forms.GroupBox mrcOrigenConsulta;
        private System.Windows.Forms.RadioButton optNacionalConsulta;
        private System.Windows.Forms.RadioButton optImportadoConsulta;
        private System.Windows.Forms.Label lblDatosRepuestos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.TextBox txtNumeroRepuesto;
        private System.Windows.Forms.Label lblNumeroRepuesto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
    }
}



namespace ReservacionAulas
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbTandaLaboral = new System.Windows.Forms.ComboBox();
            this.picGuardar = new System.Windows.Forms.PictureBox();
            this.picEliminar = new System.Windows.Forms.PictureBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.Label();
            this.cmbCriterioBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusquedaEmpleado = new System.Windows.Forms.TextBox();
            this.picLimpiar = new System.Windows.Forms.PictureBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.picExportar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExportar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(190, 228);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(380, 194);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(635, 315);
            this.dgvEmpleados.TabIndex = 3;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tanda Laboral:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Ingreso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(190, 261);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(151, 22);
            this.txtCedula.TabIndex = 8;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(206, 391);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(135, 24);
            this.cmbEstado.TabIndex = 9;
            // 
            // cmbTandaLaboral
            // 
            this.cmbTandaLaboral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTandaLaboral.FormattingEnabled = true;
            this.cmbTandaLaboral.Items.AddRange(new object[] {
            "Matutina",
            "Vespertina",
            "Nocturna"});
            this.cmbTandaLaboral.Location = new System.Drawing.Point(206, 305);
            this.cmbTandaLaboral.Name = "cmbTandaLaboral";
            this.cmbTandaLaboral.Size = new System.Drawing.Size(135, 24);
            this.cmbTandaLaboral.TabIndex = 10;
            // 
            // picGuardar
            // 
            this.picGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGuardar.BackgroundImage")));
            this.picGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGuardar.Location = new System.Drawing.Point(133, 455);
            this.picGuardar.Name = "picGuardar";
            this.picGuardar.Size = new System.Drawing.Size(56, 54);
            this.picGuardar.TabIndex = 41;
            this.picGuardar.TabStop = false;
            this.picGuardar.Click += new System.EventHandler(this.picGuardar_Click);
            // 
            // picEliminar
            // 
            this.picEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEliminar.BackgroundImage")));
            this.picEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEliminar.Location = new System.Drawing.Point(205, 455);
            this.picEliminar.Name = "picEliminar";
            this.picEliminar.Size = new System.Drawing.Size(56, 54);
            this.picEliminar.TabIndex = 40;
            this.picEliminar.TabStop = false;
            this.picEliminar.Click += new System.EventHandler(this.picEliminar_Click);
            // 
            // picBuscar
            // 
            this.picBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBuscar.BackgroundImage")));
            this.picBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBuscar.Location = new System.Drawing.Point(939, 118);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(56, 54);
            this.picBuscar.TabIndex = 46;
            this.picBuscar.TabStop = false;
            this.picBuscar.Click += new System.EventHandler(this.picBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Criterio Busqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.AutoSize = true;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(644, 128);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(96, 24);
            this.txtBusqueda.TabIndex = 44;
            this.txtBusqueda.Text = "Busqueda:";
            // 
            // cmbCriterioBusqueda
            // 
            this.cmbCriterioBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterioBusqueda.FormattingEnabled = true;
            this.cmbCriterioBusqueda.Items.AddRange(new object[] {
            "Identificador",
            "Nombre",
            "Cedula",
            "Tanda_Laboral",
            "Fecha_Ingreso",
            "Estado"});
            this.cmbCriterioBusqueda.Location = new System.Drawing.Point(480, 133);
            this.cmbCriterioBusqueda.Name = "cmbCriterioBusqueda";
            this.cmbCriterioBusqueda.Size = new System.Drawing.Size(156, 24);
            this.cmbCriterioBusqueda.TabIndex = 43;
            // 
            // txtBusquedaEmpleado
            // 
            this.txtBusquedaEmpleado.Location = new System.Drawing.Point(750, 133);
            this.txtBusquedaEmpleado.Name = "txtBusquedaEmpleado";
            this.txtBusquedaEmpleado.Size = new System.Drawing.Size(183, 22);
            this.txtBusquedaEmpleado.TabIndex = 42;
            // 
            // picLimpiar
            // 
            this.picLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLimpiar.BackgroundImage")));
            this.picLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLimpiar.Location = new System.Drawing.Point(62, 455);
            this.picLimpiar.Name = "picLimpiar";
            this.picLimpiar.Size = new System.Drawing.Size(56, 54);
            this.picLimpiar.TabIndex = 47;
            this.picLimpiar.TabStop = false;
            this.picLimpiar.Click += new System.EventHandler(this.picLimpiar_Click);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(206, 349);
            this.dtpFechaIngreso.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(135, 22);
            this.dtpFechaIngreso.TabIndex = 48;
            // 
            // picExportar
            // 
            this.picExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExportar.BackgroundImage")));
            this.picExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExportar.Location = new System.Drawing.Point(278, 455);
            this.picExportar.Name = "picExportar";
            this.picExportar.Size = new System.Drawing.Size(56, 54);
            this.picExportar.TabIndex = 49;
            this.picExportar.TabStop = false;
            this.picExportar.Click += new System.EventHandler(this.picExportar_Click);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 532);
            this.Controls.Add(this.picExportar);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.picLimpiar);
            this.Controls.Add(this.picBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cmbCriterioBusqueda);
            this.Controls.Add(this.txtBusquedaEmpleado);
            this.Controls.Add(this.picGuardar);
            this.Controls.Add(this.picEliminar);
            this.Controls.Add(this.cmbTandaLaboral);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Empleado";
            this.Text = "Empleados";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExportar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbTandaLaboral;
        private System.Windows.Forms.PictureBox picGuardar;
        private System.Windows.Forms.PictureBox picEliminar;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtBusqueda;
        private System.Windows.Forms.ComboBox cmbCriterioBusqueda;
        private System.Windows.Forms.TextBox txtBusquedaEmpleado;
        private System.Windows.Forms.PictureBox picLimpiar;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.PictureBox picExportar;
    }
}
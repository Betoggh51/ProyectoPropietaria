
namespace ReservacionAulas
{
    partial class Edificio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edificio));
            this.label5 = new System.Windows.Forms.Label();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.picGuardar = new System.Windows.Forms.PictureBox();
            this.picEliminar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCriterioEdificio = new System.Windows.Forms.ComboBox();
            this.txtBusquedaEdificio = new System.Windows.Forms.TextBox();
            this.dgvEdificio = new System.Windows.Forms.DataGridView();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCampus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdificio)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Campus:";
            // 
            // picBuscar
            // 
            this.picBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBuscar.BackgroundImage")));
            this.picBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBuscar.Location = new System.Drawing.Point(848, 90);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(56, 54);
            this.picBuscar.TabIndex = 30;
            this.picBuscar.TabStop = false;
            // 
            // picGuardar
            // 
            this.picGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGuardar.BackgroundImage")));
            this.picGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGuardar.Location = new System.Drawing.Point(112, 462);
            this.picGuardar.Name = "picGuardar";
            this.picGuardar.Size = new System.Drawing.Size(56, 54);
            this.picGuardar.TabIndex = 29;
            this.picGuardar.TabStop = false;
            this.picGuardar.Click += new System.EventHandler(this.picGuardar_Click);
            // 
            // picEliminar
            // 
            this.picEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEliminar.BackgroundImage")));
            this.picEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEliminar.Location = new System.Drawing.Point(184, 462);
            this.picEliminar.Name = "picEliminar";
            this.picEliminar.Size = new System.Drawing.Size(56, 54);
            this.picEliminar.TabIndex = 28;
            this.picEliminar.TabStop = false;
            this.picEliminar.Click += new System.EventHandler(this.picEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Criterio Busqueda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(561, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Busqueda:";
            // 
            // cmbCriterioEdificio
            // 
            this.cmbCriterioEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterioEdificio.FormattingEnabled = true;
            this.cmbCriterioEdificio.Items.AddRange(new object[] {
            "Identificador",
            "Descripcion",
            "Campus",
            "Estado"});
            this.cmbCriterioEdificio.Location = new System.Drawing.Point(399, 105);
            this.cmbCriterioEdificio.Name = "cmbCriterioEdificio";
            this.cmbCriterioEdificio.Size = new System.Drawing.Size(156, 24);
            this.cmbCriterioEdificio.TabIndex = 24;
            // 
            // txtBusquedaEdificio
            // 
            this.txtBusquedaEdificio.Location = new System.Drawing.Point(659, 105);
            this.txtBusquedaEdificio.Name = "txtBusquedaEdificio";
            this.txtBusquedaEdificio.Size = new System.Drawing.Size(183, 22);
            this.txtBusquedaEdificio.TabIndex = 23;
            // 
            // dgvEdificio
            // 
            this.dgvEdificio.AllowUserToAddRows = false;
            this.dgvEdificio.AllowUserToDeleteRows = false;
            this.dgvEdificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdificio.Location = new System.Drawing.Point(356, 178);
            this.dgvEdificio.Name = "dgvEdificio";
            this.dgvEdificio.ReadOnly = true;
            this.dgvEdificio.RowHeadersWidth = 51;
            this.dgvEdificio.RowTemplate.Height = 24;
            this.dgvEdificio.Size = new System.Drawing.Size(548, 338);
            this.dgvEdificio.TabIndex = 22;
            this.dgvEdificio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEdificio_CellDoubleClick);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(158, 289);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(175, 24);
            this.cmbEstado.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Estado:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(158, 215);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(175, 22);
            this.txtDescripcion.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Descripcion:";
            // 
            // cmbCampus
            // 
            this.cmbCampus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampus.FormattingEnabled = true;
            this.cmbCampus.Location = new System.Drawing.Point(158, 253);
            this.cmbCampus.Name = "cmbCampus";
            this.cmbCampus.Size = new System.Drawing.Size(175, 24);
            this.cmbCampus.TabIndex = 32;
            // 
            // Edificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 539);
            this.Controls.Add(this.cmbCampus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBuscar);
            this.Controls.Add(this.picGuardar);
            this.Controls.Add(this.picEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCriterioEdificio);
            this.Controls.Add(this.txtBusquedaEdificio);
            this.Controls.Add(this.dgvEdificio);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "Edificio";
            this.Text = "Edificio";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Edificio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdificio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.PictureBox picGuardar;
        private System.Windows.Forms.PictureBox picEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCriterioEdificio;
        private System.Windows.Forms.TextBox txtBusquedaEdificio;
        private System.Windows.Forms.DataGridView dgvEdificio;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCampus;
    }
}
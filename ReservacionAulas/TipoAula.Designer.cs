
namespace ReservacionAulas
{
    partial class TipoAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoAula));
            this.txtDescripcionTipoAula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstadoTipoAula = new System.Windows.Forms.ComboBox();
            this.dgvTipoAula = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.picGuardar = new System.Windows.Forms.PictureBox();
            this.picEliminar = new System.Windows.Forms.PictureBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCriterioBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.picLimpiar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoAula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcionTipoAula
            // 
            this.txtDescripcionTipoAula.Location = new System.Drawing.Point(145, 176);
            this.txtDescripcionTipoAula.Name = "txtDescripcionTipoAula";
            this.txtDescripcionTipoAula.Size = new System.Drawing.Size(165, 22);
            this.txtDescripcionTipoAula.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion:";
            // 
            // cmbEstadoTipoAula
            // 
            this.cmbEstadoTipoAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoTipoAula.FormattingEnabled = true;
            this.cmbEstadoTipoAula.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoTipoAula.Location = new System.Drawing.Point(145, 216);
            this.cmbEstadoTipoAula.Name = "cmbEstadoTipoAula";
            this.cmbEstadoTipoAula.Size = new System.Drawing.Size(165, 24);
            this.cmbEstadoTipoAula.TabIndex = 2;
            // 
            // dgvTipoAula
            // 
            this.dgvTipoAula.AllowUserToAddRows = false;
            this.dgvTipoAula.AllowUserToDeleteRows = false;
            this.dgvTipoAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoAula.Location = new System.Drawing.Point(364, 147);
            this.dgvTipoAula.Name = "dgvTipoAula";
            this.dgvTipoAula.ReadOnly = true;
            this.dgvTipoAula.RowHeadersWidth = 51;
            this.dgvTipoAula.RowTemplate.Height = 24;
            this.dgvTipoAula.Size = new System.Drawing.Size(464, 223);
            this.dgvTipoAula.TabIndex = 3;
            this.dgvTipoAula.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoAula_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado:";
            // 
            // picGuardar
            // 
            this.picGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGuardar.BackgroundImage")));
            this.picGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGuardar.Location = new System.Drawing.Point(149, 316);
            this.picGuardar.Name = "picGuardar";
            this.picGuardar.Size = new System.Drawing.Size(56, 54);
            this.picGuardar.TabIndex = 44;
            this.picGuardar.TabStop = false;
            this.picGuardar.Click += new System.EventHandler(this.picGuardar_Click);
            // 
            // picEliminar
            // 
            this.picEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEliminar.BackgroundImage")));
            this.picEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEliminar.Location = new System.Drawing.Point(221, 316);
            this.picEliminar.Name = "picEliminar";
            this.picEliminar.Size = new System.Drawing.Size(56, 54);
            this.picEliminar.TabIndex = 43;
            this.picEliminar.TabStop = false;
            this.picEliminar.Click += new System.EventHandler(this.picEliminar_Click);
            // 
            // picBuscar
            // 
            this.picBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBuscar.BackgroundImage")));
            this.picBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBuscar.Location = new System.Drawing.Point(772, 78);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(56, 54);
            this.picBuscar.TabIndex = 49;
            this.picBuscar.TabStop = false;
            this.picBuscar.Click += new System.EventHandler(this.picBuscar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(149, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 24);
            this.label9.TabIndex = 48;
            this.label9.Text = "Criterio Busqueda:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(480, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 24);
            this.label10.TabIndex = 47;
            this.label10.Text = "Busqueda:";
            // 
            // cmbCriterioBusqueda
            // 
            this.cmbCriterioBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterioBusqueda.FormattingEnabled = true;
            this.cmbCriterioBusqueda.Items.AddRange(new object[] {
            "Descripcion",
            "Estado"});
            this.cmbCriterioBusqueda.Location = new System.Drawing.Point(319, 93);
            this.cmbCriterioBusqueda.Name = "cmbCriterioBusqueda";
            this.cmbCriterioBusqueda.Size = new System.Drawing.Size(156, 24);
            this.cmbCriterioBusqueda.TabIndex = 46;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(583, 93);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(183, 22);
            this.txtBusqueda.TabIndex = 45;
            // 
            // picLimpiar
            // 
            this.picLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLimpiar.BackgroundImage")));
            this.picLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLimpiar.Location = new System.Drawing.Point(77, 316);
            this.picLimpiar.Name = "picLimpiar";
            this.picLimpiar.Size = new System.Drawing.Size(56, 54);
            this.picLimpiar.TabIndex = 50;
            this.picLimpiar.TabStop = false;
            this.picLimpiar.Click += new System.EventHandler(this.picLimpiar_Click);
            // 
            // TipoAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 408);
            this.Controls.Add(this.picLimpiar);
            this.Controls.Add(this.picBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbCriterioBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.picGuardar);
            this.Controls.Add(this.picEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTipoAula);
            this.Controls.Add(this.cmbEstadoTipoAula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcionTipoAula);
            this.Name = "TipoAula";
            this.Text = "Tipos de Aula";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.TipoAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoAula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcionTipoAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstadoTipoAula;
        private System.Windows.Forms.DataGridView dgvTipoAula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picGuardar;
        private System.Windows.Forms.PictureBox picEliminar;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCriterioBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox picLimpiar;
    }
}
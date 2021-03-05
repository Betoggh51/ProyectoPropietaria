
namespace ReservacionAulas
{
    partial class Campus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Campus));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCampus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstadoCampus = new System.Windows.Forms.ComboBox();
            this.dgvCampus = new System.Windows.Forms.DataGridView();
            this.txtBusquedaCampus = new System.Windows.Forms.TextBox();
            this.cmbCriterioCampus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picEliminarCampus = new System.Windows.Forms.PictureBox();
            this.picGuardarCampus = new System.Windows.Forms.PictureBox();
            this.picBuscarCampus = new System.Windows.Forms.PictureBox();
            this.txtDireccionCampus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminarCampus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardarCampus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarCampus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Campus:";
            // 
            // txtNombreCampus
            // 
            this.txtNombreCampus.Location = new System.Drawing.Point(178, 215);
            this.txtNombreCampus.Name = "txtNombreCampus";
            this.txtNombreCampus.Size = new System.Drawing.Size(161, 22);
            this.txtNombreCampus.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado:";
            // 
            // cmbEstadoCampus
            // 
            this.cmbEstadoCampus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCampus.FormattingEnabled = true;
            this.cmbEstadoCampus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoCampus.Location = new System.Drawing.Point(178, 289);
            this.cmbEstadoCampus.Name = "cmbEstadoCampus";
            this.cmbEstadoCampus.Size = new System.Drawing.Size(161, 24);
            this.cmbEstadoCampus.TabIndex = 3;
            // 
            // dgvCampus
            // 
            this.dgvCampus.AllowUserToAddRows = false;
            this.dgvCampus.AllowUserToDeleteRows = false;
            this.dgvCampus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampus.Location = new System.Drawing.Point(356, 178);
            this.dgvCampus.Name = "dgvCampus";
            this.dgvCampus.ReadOnly = true;
            this.dgvCampus.RowHeadersWidth = 51;
            this.dgvCampus.RowTemplate.Height = 24;
            this.dgvCampus.Size = new System.Drawing.Size(548, 338);
            this.dgvCampus.TabIndex = 4;
            this.dgvCampus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampus_CellDoubleClick);
            // 
            // txtBusquedaCampus
            // 
            this.txtBusquedaCampus.Location = new System.Drawing.Point(659, 105);
            this.txtBusquedaCampus.Name = "txtBusquedaCampus";
            this.txtBusquedaCampus.Size = new System.Drawing.Size(183, 22);
            this.txtBusquedaCampus.TabIndex = 8;
            // 
            // cmbCriterioCampus
            // 
            this.cmbCriterioCampus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterioCampus.FormattingEnabled = true;
            this.cmbCriterioCampus.Items.AddRange(new object[] {
            "Identificador",
            "Descripcion",
            "Direccion",
            "Estado"});
            this.cmbCriterioCampus.Location = new System.Drawing.Point(388, 106);
            this.cmbCriterioCampus.Name = "cmbCriterioCampus";
            this.cmbCriterioCampus.Size = new System.Drawing.Size(156, 24);
            this.cmbCriterioCampus.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Busqueda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Criterio Busqueda:";
            // 
            // picEliminarCampus
            // 
            this.picEliminarCampus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEliminarCampus.BackgroundImage")));
            this.picEliminarCampus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEliminarCampus.Location = new System.Drawing.Point(188, 462);
            this.picEliminarCampus.Name = "picEliminarCampus";
            this.picEliminarCampus.Size = new System.Drawing.Size(56, 54);
            this.picEliminarCampus.TabIndex = 13;
            this.picEliminarCampus.TabStop = false;
            this.picEliminarCampus.Click += new System.EventHandler(this.picEliminarCampus_Click);
            // 
            // picGuardarCampus
            // 
            this.picGuardarCampus.BackColor = System.Drawing.Color.White;
            this.picGuardarCampus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGuardarCampus.BackgroundImage")));
            this.picGuardarCampus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGuardarCampus.Location = new System.Drawing.Point(116, 462);
            this.picGuardarCampus.Name = "picGuardarCampus";
            this.picGuardarCampus.Size = new System.Drawing.Size(56, 54);
            this.picGuardarCampus.TabIndex = 14;
            this.picGuardarCampus.TabStop = false;
            this.picGuardarCampus.Click += new System.EventHandler(this.picGuardarCampus_Click);
            // 
            // picBuscarCampus
            // 
            this.picBuscarCampus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBuscarCampus.BackgroundImage")));
            this.picBuscarCampus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBuscarCampus.Location = new System.Drawing.Point(848, 90);
            this.picBuscarCampus.Name = "picBuscarCampus";
            this.picBuscarCampus.Size = new System.Drawing.Size(56, 54);
            this.picBuscarCampus.TabIndex = 15;
            this.picBuscarCampus.TabStop = false;
            this.picBuscarCampus.Click += new System.EventHandler(this.picBuscarCampus_Click);
            // 
            // txtDireccionCampus
            // 
            this.txtDireccionCampus.Location = new System.Drawing.Point(178, 254);
            this.txtDireccionCampus.Name = "txtDireccionCampus";
            this.txtDireccionCampus.Size = new System.Drawing.Size(161, 22);
            this.txtDireccionCampus.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Direccion:";
            // 
            // Campus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 539);
            this.Controls.Add(this.txtDireccionCampus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBuscarCampus);
            this.Controls.Add(this.picGuardarCampus);
            this.Controls.Add(this.picEliminarCampus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCriterioCampus);
            this.Controls.Add(this.txtBusquedaCampus);
            this.Controls.Add(this.dgvCampus);
            this.Controls.Add(this.cmbEstadoCampus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCampus);
            this.Controls.Add(this.label1);
            this.Name = "Campus";
            this.Text = "Campus";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Campus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminarCampus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardarCampus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarCampus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCampus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstadoCampus;
        private System.Windows.Forms.DataGridView dgvCampus;
        private System.Windows.Forms.TextBox txtBusquedaCampus;
        private System.Windows.Forms.ComboBox cmbCriterioCampus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picEliminarCampus;
        private System.Windows.Forms.PictureBox picGuardarCampus;
        private System.Windows.Forms.PictureBox picBuscarCampus;
        private System.Windows.Forms.TextBox txtDireccionCampus;
        private System.Windows.Forms.Label label5;
    }
}
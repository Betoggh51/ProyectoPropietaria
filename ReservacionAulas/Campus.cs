using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservacionAulas
{
    public partial class Campus : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = null;
        string modalidad = "c";
        public Campus()
        {
            InitializeComponent();
        }

        private void Campus_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-GRAT9S9R\\BETOSQL;Initial Catalog=Reserva_Aulas;User ID=sa;Password=Enceladus");
                con.Open();

                cmbCriterioCampus.SelectedIndex = 0;

                CargarDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexion a la base de datos: " + ex.Message);
            }
        }

        private void CargarDataGridView()
        {
            try
            {
                string consulta = "SELECT * FROM CAMPUS ";
                if (cmbCriterioCampus.Text == "Estado")
                    consulta += $"WHERE {cmbCriterioCampus.Text} = '{txtBusquedaCampus.Text}'";
                else
                    consulta += $"WHERE {cmbCriterioCampus.Text} LIKE '%{txtBusquedaCampus.Text}%'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, con);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dgvCampus.DataSource = dataTable;
                dgvCampus.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta: " + ex.Message);
            }
        }

        private void picBuscarCampus_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void picGuardarCampus_Click(object sender, EventArgs e)
        {
            if (txtNombreCampus.Text == "" || txtDireccionCampus.Text == "" || cmbEstadoCampus.Text == "")
            {
                MessageBox.Show("Favor de completar todos los campos");
                return;
            }

            try
            {
                if (modalidad == "c")
                {
                    string consulta = $@"INSERT INTO CAMPUS (Descripcion, Direccion, Estado) 
                                    VALUES('{txtNombreCampus.Text}', '{txtDireccionCampus.Text}', '{cmbEstadoCampus.Text}')";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    txtNombreCampus.Text = "";
                    txtDireccionCampus.Text = "";
                    cmbEstadoCampus.Text = "";

                    CargarDataGridView();

                    MessageBox.Show("Campus registrado exitosamente");
                }
                else
                {
                    DataGridViewRow fila = this.dgvCampus.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string consulta = $@"UPDATE CAMPUS SET Descripcion = '{txtNombreCampus.Text}', Direccion = '{txtDireccionCampus.Text}',
                                       Estado = '{cmbEstadoCampus.Text}' WHERE Identificador = '{id}'";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Campus modificado exitosamente");
                    modalidad = "c";

                    txtNombreCampus.Text = "";
                    txtDireccionCampus.Text = "";
                    cmbEstadoCampus.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar registro: " + ex.Message);
                return;
            }
        }

        private void picEliminarCampus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow fila = this.dgvCampus.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string consulta = $"DELETE FROM CAMPUS WHERE Identificador = '{id}'";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Campus eliminado exitosamente");

                    txtNombreCampus.Text = "";
                    txtDireccionCampus.Text = "";
                    cmbEstadoCampus.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminarlo");
                }
            }
        }

        private void dgvCampus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = this.dgvCampus.SelectedRows[0];
                txtNombreCampus.Text = fila.Cells[1].Value.ToString();
                txtDireccionCampus.Text = fila.Cells[2].Value.ToString();
                cmbEstadoCampus.SelectedItem = fila.Cells[3].Value.ToString();
                modalidad = "u";
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona la fila desde la flecha de la izquierda");
            }
        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreCampus.Text = "";
            txtDireccionCampus.Text = "";
            cmbEstadoCampus.Text = "";

            modalidad = "c";

            dgvCampus.ClearSelection();
        }
    }
}

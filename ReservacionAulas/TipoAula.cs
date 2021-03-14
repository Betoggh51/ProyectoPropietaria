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
    public partial class TipoAula : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = null;
        string modalidad = "c";
        public TipoAula()
        {
            InitializeComponent();
        }

        private void TipoAula_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-GRAT9S9R\\BETOSQL;Initial Catalog=Reserva_Aulas;User ID=sa;Password=Enceladus");
                con.Open();

                cmbCriterioBusqueda.SelectedIndex = 0;

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
                string consulta;
                if (cmbCriterioBusqueda.Text == "Estado")
                    consulta = $@"SELECT * FROM TIPOS_AULAS
                                WHERE {cmbCriterioBusqueda.Text} = '{txtBusqueda.Text}'";
                else
                    consulta = $@"SELECT * FROM TIPOS_AULAS
                                WHERE {cmbCriterioBusqueda.Text} LIKE '%{txtBusqueda.Text}%'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, con);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dgvTipoAula.DataSource = dataTable;
                dgvTipoAula.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta: " + ex.Message);
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void dgvTipoAula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = this.dgvTipoAula.SelectedRows[0];
                txtDescripcionTipoAula.Text = fila.Cells[1].Value.ToString();
                cmbEstadoTipoAula.Text = fila.Cells[2].Value.ToString();
                modalidad = "u";
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona la fila desde la flecha de la izquierda");
            }
        }

        private void picGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcionTipoAula.Text == "" || cmbEstadoTipoAula.Text == "")
            {
                MessageBox.Show("Favor de completar todos los campos");
                return;
            }

            try
            {
                if (modalidad == "c")
                {
                    string consulta = $@"INSERT INTO Tipos_Aulas (Descripcion, Estado) 
                                    VALUES('{txtDescripcionTipoAula.Text}', '{cmbEstadoTipoAula.Text}')";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Tipo de Aula registrado exitosamente");
                }
                else
                {
                    DataGridViewRow fila = this.dgvTipoAula.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string consulta = $@"UPDATE Tipos_Aulas SET Descripcion = '{txtDescripcionTipoAula.Text}',
                                      Estado  = '{cmbEstadoTipoAula.Text}'
                                      WHERE Identificador = '{id}'";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Tipo de Aula modificado exitosamente");
                    modalidad = "c";

                    txtDescripcionTipoAula.Text = "";
                    cmbEstadoTipoAula.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar registro: " + ex.Message);
                return;
            }
        }

        private void picEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow fila = this.dgvTipoAula.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string consulta = $@"DELETE FROM Tipos_Aulas WHERE Identificador = {id}";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Tipo de Aula eliminado exitosamente");
                    CargarDataGridView();

                    txtDescripcionTipoAula.Text = "";
                    cmbEstadoTipoAula.SelectedIndex = -1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminarlo");
                }
            }
        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcionTipoAula.Text = "";
            cmbEstadoTipoAula.SelectedIndex = -1;
            modalidad = "c";

            dgvTipoAula.ClearSelection();
        }
    }
}

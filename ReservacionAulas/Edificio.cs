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
    public partial class Edificio : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = null;
        string modalidad = "c";
        public Edificio()
        {
            InitializeComponent();
        }

        private void Edificio_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-GRAT9S9R\\BETOSQL;Initial Catalog=Reserva_Aulas;User ID=sa;Password=Enceladus");
            con.Open();

            cmbCriterioEdificio.SelectedIndex = 0;
            CargarDataGridView();

            LlenarLista();

        }

        private void CargarDataGridView()
        {
            try
            {
                string consulta;
                if (cmbCriterioEdificio.Text == "Estado")
                {
                    consulta = $@"SELECT * FROM EDIFICIOS 
                                        WHERE {cmbCriterioEdificio.Text} = '{txtBusquedaEdificio.Text}'";
                }
                else
                {
                    consulta = $@"SELECT * FROM EDIFICIOS 
                                            WHERE {cmbCriterioEdificio.Text} LIKE '%{txtBusquedaEdificio.Text}%'";
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, con);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dgvEdificio.DataSource = dataTable;
                dgvEdificio.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta: " + ex.Message);
            }
        }

        private void picGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || cmbCampus.Text == "" || cmbEstado.Text == "")
            {
                MessageBox.Show("Favor de completar todos los campos");
                return;
            }

            try
            {
                if (modalidad == "c")
                {
                    string consulta = $@"INSERT INTO EDIFICIOS (Descripcion, Identificador_Campus, Estado) 
                                    VALUES('{txtDescripcion.Text}', {cmbCampus.SelectedValue}, '{cmbEstado.Text}')";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    dgvEdificio.Refresh();
                    MessageBox.Show("Edificio registrado exitosamente");
                }
                else
                {
                    DataGridViewRow fila = this.dgvEdificio.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string consulta = $@"UPDATE EDIFICIOS SET Descripcion = '{txtDescripcion.Text}', 
                                      Identificador_Campus = '{cmbCampus.SelectedValue}',
                                      Estado  = '{cmbEstado.Text}'
                                      WHERE Identificador = {id}";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Edificio modificado exitosamente");
                    modalidad = "c";

                    txtDescripcion.Text = "";
                    cmbCampus.Text = "";
                    cmbEstado.Text = "";
                }
                CargarDataGridView();
                    dgvEdificio.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar registro: " + ex.Message);
                return;
            }
        }

        private void dgvEdificio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = this.dgvEdificio.SelectedRows[0];
                txtDescripcion.Text = fila.Cells[1].Value.ToString();
                cmbCampus.Text = fila.Cells[2].Value.ToString();
                cmbEstado.SelectedItem = fila.Cells[3].Value.ToString();
                modalidad = "u";
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona la fila desde la flecha de la izquierda");
            }
        }

        private void picEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow fila = this.dgvEdificio.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string consulta = $@"DELETE FROM EDIFICIOS WHERE Identificador = '{id}'";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Edificio eliminado exitosamente");
                    CargarDataGridView();

                    txtDescripcion.Text = "";
                    cmbCampus.SelectedIndex = -1;
                    cmbEstado.SelectedIndex = -1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminarlo");
                }
            }
        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            cmbCampus.Text = "";
            cmbEstado.Text = "";

            modalidad = "c";

            dgvEdificio.ClearSelection();
        }

        private void LlenarLista()
        {
            string sql = "SELECT identificador, descripcion FROM CAMPUS WHERE ESTADO = 'ACTIVO' ORDER BY identificador";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            cmbCampus.DataSource = table;
            cmbCampus.DisplayMember = "descripcion";
            cmbCampus.ValueMember = "identificador";

            cmbCampus.SelectedIndex = -1;
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
        }
    }
}

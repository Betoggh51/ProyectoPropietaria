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
    public partial class Aula : MetroFramework.Forms.MetroForm
    {
        string modalidad = "c";
        SqlConnection con = null;
        public Aula()
        {
            InitializeComponent();
        }

        private void Aula_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-GRAT9S9R\\BETOSQL;Initial Catalog=Reserva_Aulas;User ID=sa;Password=Enceladus");
            con.Open();

            cmbCriterioBusqueda.SelectedIndex = 0;

            LlenarListaEdificio();
            LlenarListaTipoAula();
            CargarDataGridView();
        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcionAula.Text = "";
            cmbTipoAula.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            cmbEdificio.SelectedIndex = -1;
            nudCapacidad.Value = 0;
            nudCuposReservados.Value = 0;

            dgvAulas.ClearSelection();
        }

        private void dgvAulas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = this.dgvAulas.SelectedRows[0];
                txtDescripcionAula.Text = fila.Cells[1].Value.ToString();
                cmbTipoAula.Text = fila.Cells[2].Value.ToString();
                cmbEdificio.Text = fila.Cells[3].Value.ToString();
                nudCapacidad.Value = int.Parse(fila.Cells[4].Value.ToString());
                nudCuposReservados.Value = int.Parse(fila.Cells[5].Value.ToString());
                cmbEstado.SelectedItem = fila.Cells[6].Value.ToString();
                modalidad = "u";
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona la fila desde la flecha de la izquierda");
            }
        }

        private void picGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcionAula.Text == "" || cmbTipoAula.Text == "" || cmbEstado.Text == "" || cmbEdificio.Text == "" ||
                nudCapacidad.Value == 0)
            {
                MessageBox.Show("Favor de completar todos los campos");
                return;
            }

            try
            {
                if (modalidad == "c")
                {
                    string consulta = $@"INSERT INTO Aulas (Descripcion, Identificador_Tipo_Aula,
                                Identificador_Edificio, Capacidad, Cupos_reservados, Estado) 
                                VALUES ('{txtDescripcionAula.Text}', '{cmbTipoAula.SelectedValue}',
                                {cmbEdificio.SelectedValue}, {nudCapacidad.Value}, 
                                {nudCuposReservados.Value},'{cmbEstado.Text}')";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Aula registrada exitosamente");
                }
                else
                {
                    DataGridViewRow fila = this.dgvAulas.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string consulta = $@"UPDATE Aulas SET Descripcion = '{txtDescripcionAula.Text}', 
                                       Identificador_Tipo_Aula = '{cmbTipoAula.SelectedValue}',
                                       Identificador_Edificio = {cmbEdificio.SelectedValue}, Capacidad = {nudCapacidad.Value},
                                       Cupos_Reservados = {nudCuposReservados.Value}, Estado  = '{cmbEstado.Text}'
                                       WHERE Identificador = {id}";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Aula modificada exitosamente");
                    modalidad = "c";

                    txtDescripcionAula.Text = "";
                    cmbTipoAula.SelectedIndex = -1;
                    cmbEdificio.SelectedIndex = -1;
                    nudCapacidad.Value = 0;
                    nudCuposReservados.Value = 0;
                    cmbEstado.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar registro: " + ex.Message);
                return;
            }
        }
        private void CargarDataGridView()
        {
            try
            {
                string consulta;
                if(cmbCriterioBusqueda.Text == "Estado")
                    consulta = $"SELECT * FROM Aulas WHERE {cmbCriterioBusqueda.Text} = '{txtBusqueda.Text}'";
                else
                    consulta = $"SELECT * FROM Aulas WHERE {cmbCriterioBusqueda.Text} LIKE '%{txtBusqueda.Text}%'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, con);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dgvAulas.DataSource = dataTable;
                dgvAulas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta: " + ex.Message);
            }
        }

        private void picEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow fila = this.dgvAulas.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string consulta = $"DELETE FROM Aulas WHERE Identificador = {id}";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Aula eliminada exitosamente");
                    CargarDataGridView();

                    txtDescripcionAula.Text = "";
                    cmbTipoAula.SelectedIndex = -1;
                    cmbEdificio.SelectedIndex = -1;
                    nudCapacidad.Value = 0;
                    nudCuposReservados.Value = 0;
                    cmbEstado.SelectedIndex = -1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminarlo");
                }
            }

        }
        private void LlenarListaTipoAula()
        {
            string sql = "SELECT identificador, descripcion FROM Tipos_Aulas WHERE ESTADO = 'ACTIVO' ORDER BY identificador";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            cmbTipoAula.DataSource = table;
            cmbTipoAula.DisplayMember = "descripcion";
            cmbTipoAula.ValueMember = "identificador";

            cmbTipoAula.SelectedIndex = -1;
        }
        private void LlenarListaEdificio()
        {
            string sql = "SELECT identificador, descripcion FROM Edificios WHERE ESTADO = 'ACTIVO' ORDER BY identificador";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            cmbEdificio.DataSource = table;
            cmbEdificio.DisplayMember = "descripcion";
            cmbEdificio.ValueMember = "identificador";

            cmbEdificio.SelectedIndex = -1;
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
        }
    }
}

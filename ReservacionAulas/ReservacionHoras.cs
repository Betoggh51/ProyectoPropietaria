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
    public partial class ReservacionHoras : MetroFramework.Forms.MetroForm
    {
        string modalidad = "c";
        SqlConnection con = null;
        public ReservacionHoras()
        {
            InitializeComponent();
        }

        private void ReservacionHoras_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-GRAT9S9R\\BETOSQL;Initial Catalog=Reserva_Aulas;User ID=sa;Password=Enceladus");
            con.Open();

            cmbCriterioBusqueda.SelectedIndex = 0;

            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraFin.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraFin.ShowUpDown = true;

            LlenarListaAula();
            LlenarListaEmpleados();
            LlenarListaUsuarios();
            CargarDataGridView();
        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            cmbEmpleado.SelectedIndex = 0;
            cmbUsuario.SelectedIndex = 0;
            cmbAula.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            txtCantidadHoras.Text = "0";
            txtComentario.Text = "";
            cmbEstado.SelectedIndex = 0;

            dgvReservacion.ClearSelection();
        }

        private void picGuardar_Click(object sender, EventArgs e)
        {
            if (cmbEmpleado.Text == "" || cmbAula.Text == "" || cmbEstado.Text == "" || cmbUsuario.Text == "" || dtpFecha.Value == null)
            {
                MessageBox.Show("Favor de completar todos los campos");
                return;
            }

            try
            {
                if (modalidad == "c")
                {
                    string cantidadHoras = (dtpHoraFin.Value - dtpHoraInicio.Value).ToString();
                    MessageBox.Show(cantidadHoras);
                    string consulta = $@"INSERT INTO Reservaciones_Aulas (Identificador_Empleado, Identificador_Usuario,
                                      Identificador_Aula, Fecha_Reservacion,Hora_Inicio, Hora_Fin, Cantidad_Horas, Comentario, Estado)
                                      VALUES ({cmbEmpleado.SelectedValue}, {cmbUsuario.SelectedValue}, {cmbAula.SelectedValue}, '{dtpFecha.Text}',
                                      '{dtpHoraInicio}', '{dtpHoraFin}','{cantidadHoras}', '{txtComentario.Text}', '{cmbEstado.Text}')";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Reservacion registrada exitosamente");
                }
                else
                {
                    DataGridViewRow fila = this.dgvReservacion.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();
                    string cantidadHoras = (dtpHoraFin.Value - dtpHoraInicio.Value).ToString();
                    MessageBox.Show(cantidadHoras);
                    string fechaReserva = dtpFecha.Value.ToString("yyyy-MM-dd");
                    string consulta = $@"UPDATE Reservaciones_Aulas SET Identificador_Empleado = {cmbEmpleado.SelectedValue},
                                      Identificador_Usuario = {cmbUsuario.SelectedValue}, Identificador_Aula = {cmbAula.SelectedValue},
                                      Fecha_Reservacion = '{fechaReserva}', Hora_Inicio = '{dtpHoraInicio.Text}',
                                      Hora_Fin = '{dtpHoraFin.Text}',Cantidad_Horas = {cantidadHoras},
                                      Comentario = '{txtComentario.Text}', Estado = '{cmbEstado.Text}'
                                        WHERE Num_Reservacion = {id}";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Reserva modificada exitosamente");
                    modalidad = "c";

                    cmbEmpleado.SelectedIndex = 0;
                    cmbUsuario.SelectedIndex = 0;
                    cmbAula.SelectedIndex = 0;
                    dtpFecha.Value = DateTime.Now;
                    txtCantidadHoras.Text = "0";
                    txtComentario.Text = "";
                    cmbEstado.SelectedIndex = 0;
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
                string consulta = $@"SELECT RA.Num_Reservacion AS 'Numero Reservacion', E.Nombre AS 'Nombre Empleado',
                        U.Nombre AS 'Nombre Usuario', A.Descripcion AS 'Descripcion', RA.Fecha_Reservacion AS 'Fecha Reservacion',
                        RA.Hora_Inicio AS 'Hora Inicio', RA.Hora_Fin AS 'Hora Fin',RA.Cantidad_Horas AS 'Cantidad Horas', RA.Comentario, RA.Estado FROM Reservaciones_Aulas AS RA INNER JOIN
                        Empleados AS E ON E.Identificador = RA.Identificador_Empleado INNER JOIN Usuarios AS U
                        ON U.Identificador = RA.Identificador_Usuario INNER JOIN Aulas AS A ON A.Identificador = RA.Identificador_Aula
                        WHERE {cmbCriterioBusqueda.Text} LIKE '%{txtBusqueda.Text}%'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, con);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dgvReservacion.DataSource = dataTable;
                dgvReservacion.Refresh();
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
                    DataGridViewRow fila = this.dgvReservacion.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string consulta = "DELETE FROM Reservacion_Aulas WHERE Identificador = '" + id + "'";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Reservacion eliminada exitosamente");
                    CargarDataGridView();

                    cmbEmpleado.SelectedIndex = 0;
                    cmbUsuario.SelectedIndex = 0;
                    cmbAula.SelectedIndex = 0;
                    dtpFecha.Value = DateTime.Now;
                    txtCantidadHoras.Text = "0";
                    txtComentario.Text = "";
                    cmbEstado.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminarlo");
                }
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void LlenarListaAula()
        {
            string sql = "SELECT identificador, descripcion FROM Aulas WHERE ESTADO = 'ACTIVO' ORDER BY identificador";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            cmbAula.DataSource = table;
            cmbAula.DisplayMember = "descripcion";
            cmbAula.ValueMember = "identificador";

            cmbAula.SelectedIndex = 0;
        }
        private void LlenarListaEmpleados()
        {
            string sql = "SELECT identificador, nombre FROM Empleados WHERE ESTADO = 'ACTIVO' ORDER BY identificador";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            cmbEmpleado.DataSource = table;
            cmbEmpleado.DisplayMember = "Nombre";
            cmbEmpleado.ValueMember = "identificador";

            cmbEmpleado.SelectedIndex = 0;
        }
        private void LlenarListaUsuarios()
        {
            string sql = "SELECT identificador, nombre FROM Usuarios WHERE ESTADO = 'ACTIVO' ORDER BY identificador";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            cmbUsuario.DataSource = table;
            cmbUsuario.DisplayMember = "Nombre";
            cmbUsuario.ValueMember = "identificador";

            cmbUsuario.SelectedIndex = 0;
        }

        private void dgvReservacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = this.dgvReservacion.SelectedRows[0];
                cmbEmpleado.Text = fila.Cells[1].Value.ToString();
                cmbUsuario.Text = fila.Cells[2].Value.ToString();
                cmbAula.Text = fila.Cells[3].Value.ToString();
                dtpFecha.Text = fila.Cells[4].Value.ToString();
                dtpHoraInicio.Text = fila.Cells[5].Value.ToString();
                dtpHoraFin.Text = fila.Cells[6].Value.ToString();
                txtCantidadHoras.Text = fila.Cells[7].Value.ToString();
                txtComentario.Text = fila.Cells[8].Value.ToString();
                cmbEstado.SelectedItem = fila.Cells[9].Value.ToString();
                modalidad = "u";
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona la fila desde la flecha de la izquierda");
            }
        }
    }
}

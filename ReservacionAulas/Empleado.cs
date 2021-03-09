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
    public partial class Empleado : MetroFramework.Forms.MetroForm
    {
        string modalidad = "c";
        SqlConnection con = null;
        public Empleado()
        {
            InitializeComponent();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-GRAT9S9R\\BETOSQL;Initial Catalog=Reserva_Aulas;User ID=sa;Password=Enceladus");
            con.Open();

            cmbCriterioBusqueda.SelectedIndex = 0;

            CargarDataGridView();
        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCedula.Text = "";
            cmbTandaLaboral.Text = "";
            cmbEstado.Text = "";
            modalidad = "c";

            dgvEmpleados.ClearSelection();
        }

        private void picEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow fila = this.dgvEmpleados.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string consulta = "DELETE FROM Empleados WHERE Identificador = '" + id + "'";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Empleado eliminada exitosamente");
                    CargarDataGridView();

                    txtNombre.Text = "";
                    txtCedula.Text = "";
                    cmbTandaLaboral.SelectedIndex = 0;
                    dtpFechaIngreso.Value = DateTime.Now;
                    cmbEstado.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminarlo");
                }
            }
        }
        private void CargarDataGridView()
        {
            try
            {
                string consulta = "SELECT * FROM Empleados ";
                consulta += " WHERE " + cmbCriterioBusqueda.Text + " LIKE '%" + txtBusquedaEmpleado.Text + "%'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, con);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dgvEmpleados.DataSource = dataTable;
                dgvEmpleados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta: " + ex.Message);
            }
        }

        private void picGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCedula.Text == "" || cmbEstado.Text == "" || cmbTandaLaboral.Text == "" ||
                dtpFechaIngreso.Value == null)
            {
                MessageBox.Show("Favor de completar todos los campos");
                return;
            }

            try
            {
                if (modalidad == "c")
                {
                    string fechaIngreso = dtpFechaIngreso.Value.ToString("yyyy-MM-dd");
                    string consulta = $@"INSERT INTO Empleados (Nombre, Cedula, Tanda_Laboral, Fecha_Ingreso, Estado)
                                     VALUES ('{txtNombre.Text}', {txtCedula.Text}, '{cmbTandaLaboral.Text}', {fechaIngreso}, 
                                        '{cmbEstado.Text}')";
                    MessageBox.Show(fechaIngreso);
                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Empleado registrado exitosamente");
                }
                else
                {
                    DataGridViewRow fila = this.dgvEmpleados.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string fechaIngreso = dtpFechaIngreso.Value.ToString("yyyy-MM-dd");

                    string consulta = $@"UPDATE Empleados SET Nombre = '{txtNombre.Text}', Cedula = {txtCedula.Text},
                                        Tanda_Laboral = '{cmbTandaLaboral.Text}', Fecha_Ingreso = {fechaIngreso},
                                        Estado = '{cmbEstado.Text}' WHERE identificador = {id}";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Empleado modificado exitosamente");
                    modalidad = "c";

                    txtNombre.Text = "";
                    txtCedula.Text = "";
                    cmbTandaLaboral.SelectedIndex = 0;
                    dtpFechaIngreso.Value = DateTime.Now;
                    cmbEstado.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar registro: " + ex.Message);
                return;
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = this.dgvEmpleados.SelectedRows[0];
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtCedula.Text = fila.Cells[2].Value.ToString();
                cmbTandaLaboral.Text = fila.Cells[3].Value.ToString();

                // Preguntar al profesor como sacar esto
                //dtpFechaIngreso.Value = Convert.ToDateTime(fila.Cells[4].Value.ToString());
                cmbEstado.Text = fila.Cells[5].Value.ToString();
                modalidad = "u";
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona la fila desde la flecha de la izquierda");
            }
        }
    }
}

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
    public partial class Usuario : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = null;
        string modalidad = "c";
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-GRAT9S9R\\BETOSQL;Initial Catalog=Reserva_Aulas;User ID=sa;Password=Enceladus");
            con.Open();

            cmbCriterioBusqueda.SelectedIndex = 0;

            CargarDataGridView();
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void CargarDataGridView()
        {
            try
            {
                string consulta = "SELECT * FROM Usuarios ";
                consulta += " WHERE " + cmbCriterioBusqueda.Text + " LIKE '%" + txtBusqueda.Text + "%'";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, con);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dgvUsuarios.DataSource = dataTable;
                dgvUsuarios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta: " + ex.Message);
            }
        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtCarnet.Text = "";
            cmbTipoUsuario.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;

            dgvUsuarios.ClearSelection();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = this.dgvUsuarios.SelectedRows[0];
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtCedula.Text = fila.Cells[2].Value.ToString();
                txtCarnet.Text = fila.Cells[3].Value.ToString();
                cmbTipoUsuario.Text = fila.Cells[4].Value.ToString();
                cmbEstado.Text = fila.Cells[5].Value.ToString();
                modalidad = "u";
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona la fila desde la flecha de la izquierda");
            }
        }

        private void picGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCedula.Text == "" || cmbEstado.Text == "" || txtCarnet.Text == "" ||
                cmbEstado.Text == "")
            {
                MessageBox.Show("Favor de completar todos los campos");
                return;
            }

            if (!validaCedula(txtCedula.Text))
            {
                MessageBox.Show("La cédula ingresada no es válida");
                return;
            }

            try
            {
                if (modalidad == "c")
                {
                    string consulta = $@"INSERT INTO USUARIOS (NOMBRE, CEDULA, NO_CARNET, TIPO_USUARIO, ESTADO)
                                      VALUES ('{txtNombre.Text}', {txtCedula.Text}, {txtCarnet.Text}, 
                                      '{cmbTipoUsuario.Text}', '{cmbEstado.Text}')";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Usuario registrado exitosamente");
                }
                else
                {
                    DataGridViewRow fila = this.dgvUsuarios.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string consulta = $@"UPDATE USUARIOS SET Nombre = '{txtNombre.Text}', Cedula = {txtCedula.Text},
                          No_Carnet = {txtCarnet.Text}, Tipo_Usuario = '{cmbTipoUsuario.Text}', Estado = '{cmbEstado.Text}'
                          WHERE Identificador = {id}";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    CargarDataGridView();
                    MessageBox.Show("Usuario modificado exitosamente");
                    modalidad = "c";

                    txtNombre.Text = "";
                    txtCedula.Text = "";
                    txtCarnet.Text = "";
                    cmbTipoUsuario.SelectedIndex = 0;
                    cmbEstado.SelectedIndex = 0;
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
                    DataGridViewRow fila = this.dgvUsuarios.SelectedRows[0];
                    string id = fila.Cells[0].Value.ToString();

                    string consulta = $"DELETE FROM Usuario WHERE Identificador = '{id}'";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuario eliminado exitosamente");
                    CargarDataGridView();

                    txtNombre.Text = "";
                    txtCedula.Text = "";
                    txtCarnet.Text = "";
                    cmbTipoUsuario.SelectedIndex = 0;
                    cmbEstado.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe seleccionar un registro para eliminarlo");
                }
            }
        }
        public static bool validaCedula(string pCedula)
        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }
            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }
    }
}

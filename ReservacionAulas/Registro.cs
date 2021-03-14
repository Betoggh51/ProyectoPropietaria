using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservacionAulas
{
    public partial class frmRegistro : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = null;
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-GRAT9S9R\\BETOSQL;Initial Catalog=Reserva_Aulas;User ID=sa;Password=Enceladus");
            con.Open();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "" || txtClave.Text == "" || txtConfirmarClave.Text == "")
            {
                MessageBox.Show("Favor de completar todos los campos");
                return;
            }

            if (txtClave.Text != txtConfirmarClave.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            try
            {
                    string consulta = $@"INSERT INTO Registro (Nombre_Usuario, Correo, Clave) 
                                    VALUES('{txtNombreUsuario.Text}', '{txtCorreo.Text}', HASHBYTES('SHA2_256', '{txtClave.Text}'))";

                    SqlCommand comando = new SqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuario registrado exitosamente");
                
                // Estructura que debemos seguir en caso de hacer un UPDATE. Obviamente debemos cambiar todos los campos
                // actuales por los campos correspondientes
                //{
                //    DataGridViewRow fila = this.dgvEdificio.SelectedRows[0];
                //    string id = fila.Cells[0].Value.ToString();

                //    string consulta = $@"UPDATE EDIFICIOS SET Descripcion = '{txtDescripcion.Text}', 
                //                      Identificador_Campus = '{cmbCampus.SelectedValue}',
                //                      Estado  = '{cmbEstado.Text}'
                //                      WHERE Identificador = {id}";

                //    SqlCommand comando = new SqlCommand(consulta, con);
                //    comando.ExecuteNonQuery();

                //    CargarDataGridView();
                //    MessageBox.Show("Edificio modificado exitosamente");
                //    modalidad = "c";

                //    txtDescripcion.Text = "";
                //    cmbCampus.Text = "";
                //    cmbEstado.Text = "";
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar registro: " + ex.Message);
                return;
            }
        }
    }
}

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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-GRAT9S9R\\BETOSQL;Initial Catalog=Reserva_Aulas;User ID=sa;Password=Enceladus");
        }

        private void picInicioSesion_Click(object sender, EventArgs e)
        {

            if (txtClave.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos para iniciar sesion");
                return;
            }

            string consulta = @"SELECT COUNT(Cedula) FROM Usuarios WHERE Clave = HASHBYTES('SHA2_256', @Clave)
                                    AND Nombre = @Nombre";
            
            con.Open();
            SqlCommand command = new SqlCommand(consulta, con);
            command.Parameters.Add("@Nombre", SqlDbType.VarChar);
            command.Parameters["@Nombre"].Value = txtUsuario.Text;
            command.Parameters.Add("@Clave", SqlDbType.VarChar);
            command.Parameters["@Clave"].Value = txtClave.Text;

            int valido = (int)command.ExecuteScalar();
            if (valido == 0)
            {
                MessageBox.Show("Usuario o contraseña Incorrecta");
                con.Close();
                return;
            }

            string consultaTipoUsuario = $@"SELECT Tipo_Usuario from Usuarios WHERE Clave = HASHBYTES('SHA2_256', @Cedula)
                                        AND Nombre = @Nombre";

            SqlCommand command2 = new SqlCommand(consultaTipoUsuario, con);
            command2.Parameters.Add("@Nombre", SqlDbType.VarChar);
            command2.Parameters["@Nombre"].Value = txtUsuario.Text;
            command2.Parameters.Add("@Cedula", SqlDbType.VarChar);
            command2.Parameters["@Cedula"].Value = txtClave.Text;

            string tipoUsuario = command2.ExecuteScalar().ToString();
            con.Close();

            this.Hide();
            Menu menu = new Menu(tipoUsuario);
            menu.Closed += (s, args) => this.Close();
            menu.Show();

        }
    }
}

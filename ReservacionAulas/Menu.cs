using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservacionAulas
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void campusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campus campus = new Campus();
            campus.ShowDialog();
        }

        private void edificiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edificio edificio = new Edificio();
            edificio.ShowDialog();
        }

        private void tiposAulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoAula tipoAula = new TipoAula();
            tipoAula.ShowDialog();
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aula aula = new Aula();
            aula.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.ShowDialog();
        }

        private void reservacionHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservacionHoras reservacionHoras = new ReservacionHoras();
            reservacionHoras.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }
    }
}

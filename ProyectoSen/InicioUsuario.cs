using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen
{
    public partial class InicioUsuario : Form
    {
        public InicioUsuario()
        {
            InitializeComponent();
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalUser principal = new PrincipalUser();
            principal.ShowDialog();
        }

        private void btnRegistrarC_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalUser cliente = new PrincipalUser();
            cliente.ShowDialog();
        }
        
        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            this.Hide();
            EquipoUser equipo = new EquipoUser();
            equipo.ShowDialog();
        }
    }
}

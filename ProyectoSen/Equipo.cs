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

namespace ProyectoSen
{
    public partial class Equipo : Form
    {
        public Equipo()
        {
            InitializeComponent();
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.SelecionEquipo(dgvEquipo, txtId,txtDni, cmbTipoE, txtMarca, txtDescripcion);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.modificarEquipo(txtId,txtDni, cmbTipoE, txtMarca, txtDescripcion);
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.guardarEquipo(txtDni,cmbTipoE, txtMarca, txtDescripcion,lblFecha,lblHora);   
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.DeleteEquipo(txtId);
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (cmbElegirU.Text == "ADMIN")
            {
                this.Hide();
                InicioAdmin admin = new InicioAdmin();
                admin.ShowDialog();
            }

            if (cmbElegirU.Text == "USUARIO")
            {
                this.Hide();
                InicioUsuario usuario = new InicioUsuario();
                usuario.ShowDialog();
            }
            else
            {
                lblTest.Text = "Error coloque usuario";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.ResetEquipo();
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.BuscarDni(dgvEquipo,txtDni);
            
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            
           
        }
    }
}

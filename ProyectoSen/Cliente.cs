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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.modificarCliente(txtId, txtNombre, txtApellido, txtDni, txtTelefono);
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.guardarCliente(txtNombre, txtApellido, txtDni, txtTelefono);
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.DeleteCliente(txtId);
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.SelecionCliente(dgvCliente, txtId, txtNombre, txtApellido, txtDni, txtTelefono);
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.SelecionCliente(dgvCliente, txtId, txtNombre, txtApellido, txtDni, txtTelefono);
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
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
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.ResetCliente();
            objetoCliente.mostrarCliente(dgvCliente);
        }

       
    }
}

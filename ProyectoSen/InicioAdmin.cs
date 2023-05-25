using MySqlConnector;
using ProyectoSen.Clases;
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
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
        {
            InitializeComponent();
        }



        private void btnTareas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal();
            principal.ShowDialog();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrarT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 tecnico= new Form1();
            tecnico.ShowDialog();
        }

        private void btnRegistrarC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipo equipo= new Equipo();
            equipo.ShowDialog();
        }

        /*private void btnUsuario_Click(object sender, EventArgs e)
        {
            string usuario;
            usuario = txtUsuario.Text;

            CConexion objetoConexion = new CConexion();

            String query = "Select * from login where Usuario ='" + usuario + "';";

            MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            
                if (usuario == "ADMIN@PERUSIS.COM")
                {
                    txtUsuario.Text = usuario;
                }
                else
                {

                    MessageBox.Show("Error " + usuario);

                }

            
           
            objetoConexion.cerrarConexion();
        }*/
    }
}

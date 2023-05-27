using MySqlConnector;
using ProyectoSen.Clases;
using System;
using System.Collections;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;
            usuario = txtUsuario.Text;
            contraseña = txtContra.Text;
            CConexion objetoConexion = new CConexion();
            
            String query= "Select Usuario,Contraseña from login where Usuario = '" + usuario + "' AND Contraseña = '" + contraseña + "' ";

            MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (reader.Read())
            {
                if(usuario == "ADMIN@PERUSIS.COM" && contraseña == "perusis2023")
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido "+  " \n ADMIN \n" + usuario);
                    InicioAdmin admin = new InicioAdmin();
                    admin.ShowDialog();
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido " + usuario);
                    InicioUsuario formularioP = new InicioUsuario();
                    formularioP.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("No existe ese usuario "+  usuario);
            }
            objetoConexion.cerrarConexion();
        }
    }
}

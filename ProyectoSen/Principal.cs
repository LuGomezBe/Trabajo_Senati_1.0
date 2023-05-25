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
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
            //-----------------------------------------------------------------------------------------
            //----            ---          ---            ------        -------------------------------
            //----   ------------   ----------   ------   -----    ----   -----------------------------
            //----   ------------   ----------   ------   ----    ------   ----------------------------
            //----   ------------          ---   ------   ----   --------   ---------------------------
            //----   --       ---   ----------        --------   --------   ---------------------------
            //----   -----    ---   ----------   ---   -------    ------   ----------------------------
            //----   -----    ---   ----------   -----   ------    ----   -----------------------------
            //----            ---          ---   -------    ----        -------------------------------
            //-----------------------------------------------------------------------------------------
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoTecnico = new Clases.CCliente();
            objetoTecnico.mostrarCliente(dgvPrincipal);
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoTecnico = new Clases.CEquipo();
            objetoTecnico.mostrarEquipo(dgvPrincipal);
        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.mostrarTecnico(dgvPrincipal);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.mostrarReporte(dgvReporte);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbBuscar.Text == "TECNICO")
            {
                Clases.CTecnico objetoReporte = new Clases.CTecnico();
                objetoReporte.BuscarTecnico(dgvPrincipal,txtBuscar);
                
            }
            
            if(cmbBuscar.Text == "CLIENTE")
            {
                Clases.CCliente objetoReporte = new Clases.CCliente();
                objetoReporte.BuscarCliente(dgvPrincipal, txtBuscar);
            }
        }

        private void btnBuscarR_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.BuscarReporte(dgvReporte,txtBuscarR);
        }

        private void dgvPrincipal_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
                
            

            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //string User = "Admin";    //


            if(cmbElegirU.Text == "ADMIN")
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





        //if nombre == juan que muestre todo sus actividades
        // que guarde en ambas partes 
    }
}

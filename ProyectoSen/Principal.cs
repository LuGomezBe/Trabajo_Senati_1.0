
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
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.mostrarReporte(dgvReporte);
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



        private void btnVolver_Click(object sender, EventArgs e)
        {
            //string User = "Admin";    //

                this.Hide();
                InicioAdmin admin = new InicioAdmin();
                admin.ShowDialog();
           

        }





        //if nombre == juan que muestre todo sus actividades
        // que guarde en ambas partes 
    }
}

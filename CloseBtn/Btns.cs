using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloseBtn
{
    public partial class Btns : Form
    {
        public Btns()
        {
            InitializeComponent();
        }
        //Evento click del botón maximizar
        private void btnMax_Click(object sender, EventArgs e)
        {
            //Si está normal lo maximiza, si está maximizado vuelve normal.
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }
        //Evento click del botón cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Cierra el form.
            this.Close();
        }
        //Evento click del botón minimizar
        private void btnMin_Click(object sender, EventArgs e)
        {
            //Si está normal lo minimiza, si está maximizado vuelve minimiza.
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }
        //Evento cuando se carga el form
        private void Btns_Load(object sender, EventArgs e)
        {
            //ajustamos el tamaño maximo 
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
        }
    }
}

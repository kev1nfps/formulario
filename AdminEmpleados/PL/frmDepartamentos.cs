using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminEmpleados.BLL;
using AdminEmpleados.DAL;

namespace AdminEmpleados.PL
{
    public partial class frmDepartamentos : Form
    {
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // instrucciones GUI (obtener informacion de la presentacion)
            RecupararInformacion(); 
            conexionDAL conexion = new conexionDAL();
            MessageBox.Show("Conectado.." + conexion.pruebaConectar("INSERT INTO Departamentos (departamento) VALUES ('Diseño')"));
        }

        private void RecupararInformacion()
        {
            DepartamentoBLL oDepartamento = new DepartamentoBLL();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oDepartamento.ID = ID;

            oDepartamento.Departamento = txtNombre.Text;

            MessageBox.Show(oDepartamento.ID.ToString());
            MessageBox.Show(oDepartamento.Departamento);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

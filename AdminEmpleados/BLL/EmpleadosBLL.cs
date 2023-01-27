using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminEmpleados.BLL
{
    internal class EmpleadosBLL
    {
        public int ID { get; set; }
        public string nombreEmpleado { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string correo { get; set; }
        public int departamento { get; set; }
        public byte[] fotEmpleado { get; set; }
    }
}

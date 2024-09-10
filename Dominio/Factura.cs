using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPractica.Dominio
{
    public class Factura
    {
        int NroFactura { get; set; }
        DateTime Fecha { get; set; }
        int FormaPago { get; set; }
        int Cliente { get; set; }
    }
}

using ActividadPractica.Dominio;
using System.Data.SqlClient;


namespace ActividadPractica.Datos
{
    public class IFacturaRepositpryADO : IFacturasRepository
    {
        private SqlConnection _conection;

        public IFacturaRepositpryADO()
        {
            _conection = new SqlConnection(); 
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Factura> GetAll()
        {
            throw new NotImplementedException();
        }

        public Factura GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Nueva(Factura factura)
        {
            throw new NotImplementedException();
        }
    }
}

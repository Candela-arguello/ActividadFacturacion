using ActividadPractica.Dominio;

namespace ActividadPractica.Datos
{
    public interface IFacturasRepository
    {
        List<Factura> GetAll();
        Factura GetById(int id);

        bool Nueva(Factura factura);
        bool Eliminar(int id);
    }
}

using SistemaCafeteria.Models;

namespace Proyecto.API._2._DataStructures.Linear
{
    public class NodoCircular
    {
        public Categoria Dato { get; set; }
        public NodoCircular Siguiente { get; set; }
        public NodoCircular Anterior { get; set; }

        public NodoCircular(Categoria categoria)
        {
            Dato = categoria;
            Siguiente = this;
            Anterior = this;
        }
    }
}

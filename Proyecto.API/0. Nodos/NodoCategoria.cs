using SistemaCafeteria.Models;

namespace Proyecto.API._0._Nodos
{
    public class NodoCategoria
    {
        public Categoria Datos { get; set; }
        public NodoCategoria Sig { get; set; }
        public NodoCategoria Ant { get; set; }

        public NodoCategoria(Categoria datos)
        {
            Datos = datos;
            Sig = null;
            Ant = null;
        }
    }
}

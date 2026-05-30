namespace Proyecto.API._2._DataStructures.NoLinear
{
    public class NodoArbol
    {
        public string Nombre { get; set; }
        public object Contenido { get; set; } // Puede almacenar un objeto Categoria o un objeto Producto
        public List<NodoArbol> Hijos { get; set; }

        public NodoArbol(string nombre, object contenido = null)
        {
            Nombre = nombre;
            Contenido = contenido;
            Hijos = new List<NodoArbol>();
        }
    }
}

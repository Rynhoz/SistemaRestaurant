using Microsoft.AspNetCore.Mvc;
using Proyecto.API._0._Nodos;
using Proyecto.API._2._DataStructures.NoLinear;
using SistemaCafeteria._2._DataStructures.Linear;
using SistemaCafeteria._2._DataStructures.NoLinear;
using SistemaCafeteria.Models;

namespace Proyecto.API._3._Controllers
{
    public class MenuController : Controller
    {
        private readonly ListaDobleCircular _categoriasList;
        private readonly ArbolMenu _arbolMenu;

        public MenuController()
        {
            _categoriasList = new ListaDobleCircular();
            _arbolMenu = new ArbolMenu();

            InicializarDatos();
        }

        private void InicializarDatos()
        {
            var cat1 = new Categoria(1, "Cafés", "Bebidas calientes premium");
            var cat2 = new Categoria(2, "Postres", "Tortas y masas dulces");

            _categoriasList.Insertar(cat1);
            _categoriasList.Insertar(cat2);

            _arbolMenu.AgregarCategoria(cat1);
            _arbolMenu.AgregarCategoria(cat2);
        }

        public List<Categoria> ObtenerCategoriasCarrusel()
        {
            return _categoriasList.ObtenerLista();
        }

        public NodoArbol ObtenerMenuJerarquico()
        {
            return _arbolMenu.Raiz;
        }

        public void RegistrarCategoria(Categoria nuevaCategoria)
        {
            _categoriasList.Insertar(nuevaCategoria);
            _arbolMenu.AgregarCategoria(nuevaCategoria);
        }
    }
}

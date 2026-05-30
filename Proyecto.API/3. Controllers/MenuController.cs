using SistemaCafeteria._2._DataStructures.Linear;
using SistemaCafeteria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCafeteria._3._Controllers
{
    public class MenuController
    {
        // El controlador tiene la instancia de la estructura en memoria
        private ListaDobleCircular _listaCategorias;
        private NodoCategoria _categoriaActual;

        public MenuController()
        {
            _listaCategorias = new ListaDobleCircular();
            _categoriaActual = null;
        }

        // Métodos que los botones del formulario van a activar
        public void RegistrarNuevaCategoria(string nombre)
        {
            Categoria nueva = new Categoria(nombre);
            _listaCategorias.InsertarNodo(nueva);
        }

        public string AvanzarEnMenu()
        {
            if (_categoriaActual != null)
            {
                _categoriaActual = _categoriaActual.Sig;
                return _categoriaActual.Datos.Nombre;
            }
            return "No hay categorías";
        }
    }
}

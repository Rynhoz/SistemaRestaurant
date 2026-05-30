using Proyecto.API._2._DataStructures.NoLinear;
using SistemaCafeteria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCafeteria._2._DataStructures.NoLinear
{
    public class ArbolMenu
    {
        public NodoArbol Raiz { get; private set; }

        public ArbolMenu()
        {
            Raiz = new NodoArbol("Menú General de la Cafetería");
        }

        public NodoArbol AgregarCategoria(Categoria categoria)
        {
            NodoArbol nodoCat = new NodoArbol(categoria.Nombre, categoria);
            Raiz.Hijos.Add(nodoCat);
            return nodoCat;
        }

        private NodoArbol BuscarNodo(NodoArbol actual, string nombre)
        {
            if (actual.Nombre.Equals(nombre, System.StringComparison.OrdinalIgnoreCase))
                return actual;

            foreach (var hijo in actual.Hijos)
            {
                NodoArbol encontrado = BuscarNodo(hijo, nombre);
                if (encontrado != null) return encontrado;
            }
            return null;
        }
    }
}

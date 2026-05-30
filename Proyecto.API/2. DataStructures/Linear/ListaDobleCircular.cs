using Proyecto.API._0._Nodos;
using Proyecto.API._2._DataStructures.Linear;
using SistemaCafeteria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCafeteria._2._DataStructures.Linear
{
    public class ListaDobleCircular
    {
        private NodoCircular cabeza = null;
        private int contador = 0;

        public int Cantidad => contador;

        public void Insertar(Categoria nuevaCategoria)
        {
            NodoCircular nuevo = new NodoCircular(nuevaCategoria);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoCircular cola = cabeza.Anterior;

                cola.Siguiente = nuevo;
                nuevo.Anterior = cola;
                nuevo.Siguiente = cabeza;
                cabeza.Anterior = nuevo;
            }
            contador++;
        }

        public List<Categoria> ObtenerLista()
        {
            List<Categoria> lista = new List<Categoria>();
            if (cabeza == null) return lista;

            NodoCircular actual = cabeza;
            do
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return lista;
        }

        public NodoCircular ObtenerCabeza() => cabeza;
    }
}


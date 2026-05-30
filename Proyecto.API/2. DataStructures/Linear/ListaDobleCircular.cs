using Proyecto.API._0._Nodos;
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
        private NodoCategoria primero;
        private NodoCategoria ultimo;

        public NodoCategoria Actual { get; private set; }

        public ListaDobleCircular()
        {
            primero = null;
            ultimo = null;
            Actual = null;
        }

        public void InsertarNodo(Categoria nuevaCategoria)
        {
            NodoCategoria nuevo = new NodoCategoria(nuevaCategoria);

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.Sig = primero;
                primero.Ant = primero;
                Actual = primero;
            }
            else
            {
                ultimo.Sig = nuevo;
                nuevo.Ant = ultimo;
                nuevo.Sig = primero;
                primero.Ant = nuevo;
                ultimo = nuevo;
            }
        }

        public Categoria Avanzar()
        {
            if (Actual != null)
            {
                Actual = Actual.Sig;
                return Actual.Datos;
            }
            return null;
        }

        public Categoria Retroceder()
        {
            if (Actual != null)
            {
                Actual = Actual.Ant;
                return Actual.Datos;
            }
            return null;
        }
    }
}

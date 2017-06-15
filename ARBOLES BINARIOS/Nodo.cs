using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARBOLES_BINARIOS
{
    class Nodo
    {
        public char _dato;
        private char dato { get { return _dato; } set { _dato = value; } }

        public Nodo _hizq;
        private Nodo hizq { get { return _hizq; } set { _hizq = value; } }

        public Nodo _hder;
        private Nodo hder { get { return _hder; } set { _hder = value; } }

        public Nodo _anterior;
        private Nodo anterior { get { return _anterior; } set { _anterior = value; } }

        public Nodo _siguiente;
        private Nodo siguiente { get { return _siguiente; } set { _siguiente = value; } }

        public override string ToString()
        {
            return dato.ToString();
        }
    }
}

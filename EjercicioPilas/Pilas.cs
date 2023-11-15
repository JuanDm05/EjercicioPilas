using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjercicioPilas
{
    public class Pilas
    {
        private int _cima;
        private int [] listaPila;
        private int _longitudPila = 5;

        public Pilas()
        {
            _cima = -1;
            listaPila = new int[_longitudPila];

        }
        public bool PilaVacia()
        {
            if(_cima == -1)
            {
                return true;
            }
            else
                return false;
            //return _cima == -1?true:false;
        }
        public bool PilaLlena()
        {
            if(_cima == _longitudPila-1)
            {
                return true;
            }
            return false;
            //return _cima == longitudPila - 1 ? true : false;
        }
        public int LongitudPila()
        {
            return _longitudPila;
        }
        public int CantidadElementos()
        {
            return _cima+1;
        }
        public int valorCima()
        {
            return listaPila[_cima];
        }
        public bool InsertarElemento(int valor)
        {
            if(PilaLlena())
            {
                return false;
            }
            else
            {
                _cima++;
                listaPila[_cima] = valor;
                return true;
            }
            
        }
        public int ExtraerElemento()
        {
            if (PilaVacia())
            {
                Console.WriteLine("Pila vacia");
                return _cima;
            }
            else
            {
                int aux = listaPila[_cima];
                _cima--;
                Console.WriteLine($"El valor eliminado es: {aux}");
                return aux;
            }

        }
        public bool LimpiarPila()
        {
            if (PilaVacia())
            {
                return false;
            }
            else
            {
                while(!PilaVacia())
                {
                    ExtraerElemento();
                }
            }
            return true;
        }
        public void ImprimirElementos()
        {
            if (PilaVacia())
            {
                Console.WriteLine("Pila vacia");
            }
            else
            {
                for (int i = _cima; i >= 0; i--)
                {
                    Console.Write(listaPila[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
   
}

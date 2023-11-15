using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilas pilas = new Pilas();
            int opcion = 0;
            while(opcion != 5)
            { 
            Console.WriteLine("Selecciona una opcion\n" +
                "1.- Insertar elemento\n"+
                "2.- Eliminar elemento\n"+
                "3.- Limpiar pila\n"+
                "4.- Imprimir pila\n" +
                "5.- Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch ( opcion )
                {
                    case 1:
                        Console.WriteLine("Ingrese un valor");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        pilas.InsertarElemento(valor);
                        break;
                    case 2:
                        pilas.ExtraerElemento();
                        break;
                    case 3:
                        pilas.LimpiarPila();
                        break;
                    case 4:
                        pilas.ImprimirElementos();
                        break;
                    case 5:
                        break;
                }
            

            } 
        }
    }
}

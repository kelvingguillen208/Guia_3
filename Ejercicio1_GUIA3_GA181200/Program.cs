using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_GUIA3_GA181200
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista listan = new Lista();
            Boolean token2= true;
            while (token2 == true)
            {
                Menu();
                string token = Console.ReadLine();                
                if (token == "a" || token == "A")
                {
                    Console.WriteLine("*    *   *   *   *   *   *   *   *");
                    Console.WriteLine("Ingrese el dato del item:");
                    int item = int.Parse(Console.ReadLine());
                    listan.InsertarI(item);
                    clear();
                    listan.Mostrar();
                   
                    

                }
                if (token == "b" || token == "B")
                {
                    Console.WriteLine("*    *   *   *   *   *   *   *   *");
                    Console.WriteLine("Ingrese el dato del item:");
                    int item = int.Parse(Console.ReadLine());
                    listan.InsertarF(item);
                    clear();
                    listan.Mostrar();
                }
                if (token == "c" || token == "C")
                {
                    Console.WriteLine("*    *   *   *   *   *   *   *   *");
                    Console.WriteLine("Ingrese el dato del item:");
                    int item = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la posicion especifica: ");
                    int posicion= int.Parse(Console.ReadLine());
                    listan.InsertarP(item,posicion);
                    clear();
                    listan.Mostrar();
                }
                if (token == "d" || token == "D")
                {
                    listan.EliminarI();
                    clear();
                    Console.WriteLine("Cabeza eliminada.");
                    listan.Mostrar();
                }
                if (token == "e" || token == "E")
                {
                    listan.EliminarF();
                    clear();
                    Console.WriteLine("cola eliminada.");
                    listan.Mostrar();
                }
                if (token == "f" || token == "F")
                {
                    clear();
                    Console.WriteLine("Lista:");
                    listan.Mostrar();
                }
                if (token == "g" || token == "G")
                {
                    token2 = false;
                }
                else
                {
                    clear();
                    Console.WriteLine("Opcion invalida");

                }
            }

                


        }
        public  static void Menu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("*    *  Menu de listas  *   *");
            Console.WriteLine("a. Insertar al Frente");
            Console.WriteLine("b. Insertar al Final");
            Console.WriteLine("c. Insertar en una posición específica");
            Console.WriteLine("d. Eliminar al Frente");
            Console.WriteLine("e. Eliminar al Final");
            Console.WriteLine("f. Mostrar lista");
            Console.WriteLine("g. Salir");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("ingrese su opcion: ");
        }
        public static void clear()
        {
            Console.Clear();
        }
    }
    class Nodo
    {
        public int dato;
        public Nodo siguiente;
    }
    class Lista
    {
        public Nodo inicio;
        public Lista()
        { inicio = null; }

        public void InsertarF(int item)
        {
            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
            }
        }
        public void InsertarI(int item)
        {
            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                inicio = auxiliar;
                auxiliar.siguiente = puntero;
            }
        }
        public void EliminarI()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacia, no se puede eliminar elemento");
            }
            else
            {
                inicio = inicio.siguiente;
            }
        }
        public void EliminarF()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacia, no se puede eliminar elemento");
            }
            else
            {
                Nodo punteroant, punteropost;
                punteroant = inicio;
                punteropost = inicio;
                while (punteropost.siguiente != null)
                {
                    punteroant = punteropost;
                    punteropost = punteropost.siguiente;
                }
                punteroant.siguiente = null;
            }
        }
        public void InsertarP(int item, int pos)
        {
            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (inicio == null)
            {
                Console.WriteLine("La lista vacia, por lo tanto se va a insertar en la 1 posicion.");
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                if (pos == 1)
                {
                    inicio = auxiliar;
                    auxiliar.siguiente = puntero;
                }
                else
                {
                    for (int i = 1; i < pos - 1; i++)
                    {
                        puntero = puntero.siguiente;
                        if (puntero.siguiente == null)
                            break;
                    }
                    Nodo punteronext;
                    punteronext = puntero.siguiente;
                    puntero.siguiente = auxiliar;
                    auxiliar.siguiente = punteronext;
                }
            }
        }
        public void Mostrar()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                Console.Write("{0} -> \t", puntero.dato);
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    Console.Write("{0} -> \t", puntero.dato);
                }
                Console.WriteLine("\n");
                
            }
            
        }

    }

}

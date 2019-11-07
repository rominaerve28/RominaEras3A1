using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//hacer pila, cola y reutilizar el codigo
//reutilizar : codigo que sirva para ambos
namespace RominaEras3A
{
     class Program
     {
        static void Main(string[] args)
        {
            int auxiliar = 0;
            do
            {
                Console.WriteLine("\n\n\t\t\t============Menú ==============");
                Console.WriteLine("\t\t\t=                             =");
                Console.WriteLine("\t\t\t= 1- Pila                     =");
                Console.WriteLine("\t\t\t= 2- Cola                     =");
                Console.WriteLine("\t\t\t= 4- Salir            =");
            
                Console.WriteLine("\t\t\t===============================");
                Console.WriteLine("\t\t\tOpción: ");
      
              int op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    Stack pila = new Stack(); //creando la pila
                    int opcion = 0; // opcion para el menú
                    do
                    {
                        //Console.Clear();
                        opcion = Menu();
                        switch (opcion)
                        {
                            case 1:
                                Apilar(ref pila);
                                break;
                            case 2:
                                Desapilar (ref pila);
                                break;
                            case 3:
                                Limpiar(ref pila);
                                break;
                            case 4:
                               Mostrar(pila);
                                break;
                            case 5:
                                break;
                            default:
                                Console.WriteLine("ERROR: no es válida la opcion intente de nuevo");
                                break;

                        }

                    } while (opcion != 5);

                    Console.WriteLine("El programa ha finalizado");


                    //agregar a la pila
                    static void Apilar(ref Stack lapila)
                    {
                        Console.WriteLine("\n>Ingrese valor: ");
                        //validacion de que los numeros solo sean ingresados del 1 al 99
                        try
                        {
                            int numero = Convert.ToInt32(Console.ReadLine());
                            //pregunta si estan en el rango
                            if (numero > 99 || numero <= 0)
                            {

                                Console.WriteLine("Solo son permitidos numeros del 1 al 99");

                            }
                            else
                            {
                                //agregar numero y mostrar
                                lapila.Push(numero);
                                Mostrar(lapila);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Error: Solo son permitidos numeros del 1 al 99");
                        }
                    }

                    // eliminar todos los elementos de la pila
                    static void Limpiar(ref Stack lapila)
                    {
                        lapila.Clear();
                        Mostrar(lapila);
                    }

                    // elimina un elemento de la pila
                    static void Desapilar(ref Stack lapila)
                    {
                        if (lapila.Count > 0)
                        {
                            int numero = (int)lapila.Pop();
                            Console.WriteLine("Elemento " + numero + "  eliminado");
                        }
                        else
                        {
                            Mostrar(lapila);
                        }
                    }

                    //mostrar el menú y retornar opcion
                    static int Menu()
                    {
                        Console.WriteLine(" \n              Menu de la Pila\n");
                        Console.WriteLine(" 1.- Apilar ");
                        Console.WriteLine(" 2.- Desapilar ");
                        Console.WriteLine(" 3.- Vacíar ");
                        Console.WriteLine(" 4.- Ver elementos de la pila ");
                        Console.WriteLine(" 5.- Salir ");
                        Console.WriteLine(" > Ingresar opcion: ");

                        try
                        {
                            int numero = Convert.ToInt32(Console.ReadLine());
                            return numero;
                        }
                        catch
                        {
                            return 0;
                        }
                    }

                    static void Mostrar(Stack lapila)
                    {

                        if (lapila.Count > 0)
                        {
                            Console.WriteLine(" ");
                            foreach (int auxi in lapila)
                            {
                                Console.WriteLine("     |  |");
                                if (auxi < 10)
                                {
                                    Console.WriteLine(" |    {0}   |" , auxi);
                                }
                                else
                                {
                                    Console.WriteLine(" |    {0}   |" , auxi);
                                    Console.WriteLine(" |  ------   |");
                                }
                            }

                            Console.WriteLine("\nPresione cualquier tecla para continuar");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("La pila esta vacia");
                        }
                    }

                        Console.WriteLine("Desea seguir usando la pila?");
                        Console.WriteLine("1.- Si");
                        Console.WriteLine("2.- No");
                        Console.WriteLine("Digite su opcion");
                        int op2 =Convert.ToInt32(Console.ReadLine()); 

                    if (op2 == 1)
                    {
                        Menu();

                    }
                    else
                    {
                         Console.Clear();
                    }

                }
           
                //la cola
//-----------------------------------------------------------------------------------------------------
          
                 if (op == 2)
                 {

                    Queue cola = new Queue(); //creando la cola
                    int opcion = 0; // opcion para el menú
                    do
                    {
                        //Console.Clear();
                        opcion = Menu1();
                        switch (opcion)
                        {
                            case 1:
                                Añadir(ref cola);
                                break;
                            case 2:
                                Eliminar(ref cola);
                                break;
                            case 3:
                                Limpiar(ref cola);
                                break;
                            case 4:
                                Imprimir(cola);
                                break;
                            case 5:
                                break;
                            default:
                                Console.WriteLine("ERROR: no es válida la opcion intente de nuevo");
                                break;

                        }

                    } while (opcion != 5);

                    Console.WriteLine("El programa ha finalizado");


                    //agregar a la cola
                    static void Añadir(ref Queue lacola)
                    {
                        Console.WriteLine("\n>Ingrese valor: ");
                        //validacion de que los numeros solo sean ingresados del 1 al 99
                        try
                        {
                            int numero = Convert.ToInt32(Console.ReadLine());
                            //pregunta si estan en el rango
                            if (numero > 99 || numero <= 0)
                            {

                                Console.WriteLine("Solo son permitidos numeros del 1 al 99");

                            }
                            else
                            {
                                //agregar numero y mostrar
                                lacola.Enqueue(numero);
                                Imprimir(lacola);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Error: Solo son permitidos numeros del 1 al 99");
                        }
                    }

                    // eliminar todos los elementos de la cola
                    static void Limpiar(ref Queue lacola)
                    {
                        lacola.Clear();
                        Imprimir(lacola);
                    }

                    // elimina un elemento de la cola
                    static void Eliminar(ref Queue lacola)
                    {
                       
                            int numero = (int)lacola.Dequeue();
                            Console.WriteLine("Elemento " + numero + "  eliminado");
                        
                            Imprimir(lacola);
                       
                    }


                    //mostrar el menú y retornar opcion
                    static int Menu1()
                    {
                        Console.WriteLine(" \n              Operaciones de la Cola\n");
                        Console.WriteLine(" 1.- Añadir ");
                        Console.WriteLine(" 2.- Eliminar Elemento ");
                        Console.WriteLine(" 3.- Vacíar ");
                        Console.WriteLine(" 4.- Ver elementos de la cola ");
                        Console.WriteLine(" 5.- Salir ");
                        Console.WriteLine(" > Ingresar opcion: ");

                        try
                        {
                            int numero = Convert.ToInt32(Console.ReadLine());
                            return numero;
                        }
                        catch
                        {
                            return 0;
                        }
                    }

                    static void Imprimir(Queue lacola)
                    {

                        if (lacola.Count > 0)
                        {
                            Console.WriteLine(" ");
                            foreach (int auxi in lacola)
                            {
                                Console.WriteLine("     |  |");
                                if (auxi < 10)
                                {
                                    Console.WriteLine(" |    {0}   |" , auxi);
                                }
                                else
                                {
                                    Console.WriteLine(" |    {0}   |" , auxi);
                                    Console.WriteLine(" |  ------   |");
                                }
                            }

                            Console.WriteLine("\nPresione cualquier tecla para continuar");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("La cola esta vacia");
                        }
                    }

                    Console.WriteLine("Desea seguir usando la cola?");
                    Console.WriteLine("1.- Si");
                    Console.WriteLine("2.- No");
                    Console.WriteLine("Digite su opcion");
                    int op2 = Convert.ToInt32(Console.ReadLine());
                    if (op2 == 1)
                    {
                        Menu1();

                    }
                    else
                    {
                        Console.Clear();
                    }


                }

                //salir
                if (op == 3)
                {
                    Console.ReadKey();
                    auxiliar = 1;

                }

                

            } while (auxiliar == 0);
        }

     }



    
}

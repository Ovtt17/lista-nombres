/*
Escriba un programa en C# que permita almacenar una lista de nombres (utilice el tipo List<>). A
continuación, el programa debe permitir realizar las siguientes operaciones:
• Buscar un nombre dentro de la lista.
• Eliminar un elemento de la lista.
• Imprimir por pantalla toda la lista.
*/
using System;
using System.Collections.Generic;

namespace ListaNombres
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> nombres = new List<string>();

      while (true)
      {
        Console.WriteLine("Elija una opción:");
        Console.WriteLine("1. Agregar nombre");
        Console.WriteLine("2. Buscar nombre");
        Console.WriteLine("3. Eliminar nombre");
        Console.WriteLine("4. Imprimir lista");
        Console.WriteLine("5. Salir");

        //solicitamos la accion que desea realizar el usuario.
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
          case 1:
            Console.Write("Ingrese un nombre: ");
            string nombre = Console.ReadLine();
            //agregamos el nombre que escriba el usuario a nuestra lista "nombres".
            nombres.Add(nombre);
            //imprime el nombre agregado
            Console.WriteLine($"El nombre '{nombre}' fue agregado a la lista.");
            break;
          case 2:
            Console.Write("Ingrese un nombre a buscar: ");
            //solicitamos el nombre a buscar y validar si el nombre está o no
            string nombreBuscado = Console.ReadLine();
            if (nombres.Contains(nombreBuscado))
            {
              Console.WriteLine($"El nombre '{nombreBuscado}' se encuentra en la lista.");
            }
            else
            {
              Console.WriteLine($"El nombre '{nombreBuscado}' no se encuentra en la lista.");
            }
            break;
          case 3:
            Console.Write("Ingrese un nombre a eliminar: ");
            string nombreEliminar = Console.ReadLine();
            //en caso de eliminar un nombre se usa .Remove() para eliminar dicho valor de la lista
            if (nombres.Remove(nombreEliminar))
            {
              Console.WriteLine($"El nombre '{nombreEliminar}' fue eliminado de la lista.");
            }
            else
            {
              //en caso de no encontrarlo, mostramos un mensaje
              Console.WriteLine($"El nombre '{nombreEliminar}' no se encuentra en la lista.");
            }
            break;
          case 4:
            Console.WriteLine("Lista de nombres:");
            //la utilizacion de foarch nos facilita la iteracion de una lista o array, entonces hacemos uso de ello
            foreach (string n in nombres)
            {
              Console.WriteLine(n);
            }
            break;
          case 5:
            Console.WriteLine("Adiós!");
            return;
          default:
            Console.WriteLine("Opción inválida.");
            break;
        }
      }
    }
  }

}

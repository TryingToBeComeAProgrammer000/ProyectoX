using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoQ
{
    internal class Menu
    {

        static void BuscarTodosSalarios() // Muestra un mensaje y espera a que se presione la tecla F para regresar al menú principal.
        {
            Console.WriteLine("Mostrando todos los salarios");
            Console.WriteLine("");
            Console.WriteLine("Cedula".PadRight(15) + "Nombre".PadRight(15) + "Apellido".PadLeft(15) + "email".PadLeft(15));

            Console.WriteLine("");
            Console.WriteLine("\nPresione F para regresar al menú principal...");
            while (Console.ReadKey(true).Key != ConsoleKey.F) ;
        }

        static void BuscarSalarioPorID() // Solicita al usuario un ID, muestra un mensaje y espera a que se presione la tecla F para regresar al menú principal.
        {
            Console.WriteLine("Ingrese el ID para buscar el salario: "); // pide que se ingrese el ID
            string idBuscar = Console.ReadLine(); // lee la respuesta del usuario y la almacena en idBuscar
            Console.WriteLine($"Buscando empleado con el ID {idBuscar}"); // se muestra un mensaje de confirmacion de que se esta buscando a un empleado y se llama a la variable donde se almaceno el numero de ID para que el usuario puede ver de nuevo si esta buscando correctamente
            Console.WriteLine("");
            Console.WriteLine("Cedula".PadRight(15) + "Nombre".PadRight(15) + "Apellido".PadLeft(15) + "email".PadLeft(15));

            Console.WriteLine("");
            Console.WriteLine("\nPresione F para regresar al menú principal...");
            while (Console.ReadKey(true).Key != ConsoleKey.F) ; // espera a que el usuario presione una tecla la cual no se va a mostrar en pantalla, solo cuando se presione F se volvera al menu principal
        }

        static void AgregarEmpleado() // Solicita información del empleado (cedula, nombre, apellido, correo) y valida cada entrada.
                                      // Muestra la información ingresada y opciones para guardar cambios o regresar al menú principal.
        {
            Validaciones.LimpiarP(); // Se llama a la clase Validaciones especificamente al metodo LimpiarP que contiene un Console.Clear(); para limpiar la consola
            Console.WriteLine("Agregando nuevo empleado"); // mesaje de la accion que esta en proceso

            Console.WriteLine("Ingrese la cédula: "); // Solicita una cedula 
            string cedula = Console.ReadLine(); // lee lo introducido por consola y lo alamcena en una variable de tipo string llamada cedula
            while (!Validaciones.EsCedulaValida(cedula))
            {
                Validaciones.LimpiarP(); // si no es valido se limpia la pantalla para que no se acumulen advertencias y se pide un nombre valido
                Console.WriteLine("Cédula inválida. Por favor, ingrese solo números."); // se muestra mensaje de advertencia
                cedula = Console.ReadLine(); // se lee lo introducido y se vuelve a validar para ver si ahora esta bien
            }

            Console.WriteLine("Ingrese su nombre : "); // Solicita un nombre  
            string nombre = Console.ReadLine(); // lo lee y lo almacena en una variable de tipo string llamada nombre
            while (!Validaciones.EsNombreValido(nombre)) // se llama a la clase validaciones especificamente al metodo EsNombreValido y compara si lo ingresado coincide con lo que es valido
            {
                Validaciones.LimpiarP(); // si no es valido se limpia la pantalla para que no se acumulen advertencias y se pide un nombre valido
                Console.WriteLine("Nombre inválido. Por favor, ingrese solo letras y no deje en blanco."); // mensaje de advertencia
                nombre = Console.ReadLine(); // se lee lo introducido y se vuelve a validar para ver si ahora esta bien
            }

            Console.WriteLine("Ingrese su apellido: "); // Solicita un nombre 
            string apellido = Console.ReadLine(); // lo lee y lo almacena en una variable de tipo string con el nombre de apellido
            while (!Validaciones.EsNombreValido(apellido)) // se llama a la clase validaciones especificamente al metodo EsNombreValido y compara si lo ingresado coincide con lo que es valido
            {
                Validaciones.LimpiarP(); // si no es valido se limpia la pantalla para que no se acumulen advertencias y se pide un nombre valido
                Console.WriteLine("Apellido inválido. Por favor, ingrese solo letras y no deje en blanco."); // mensaje de advertencia
                apellido = Console.ReadLine(); // se lee lo introducido y se vuelve a validar para ver si ahora esta bien
            }

            Console.WriteLine("Ingrese el correo electrónico: "); // Se pide que se ingrese un correo electronico
            string correo = Console.ReadLine(); // lo lee y lo almacena en una variable de tipo string llamada correo
            while (!Validaciones.EsCorreoValido(correo)) // se llama a la clase validaciones especificamente al metodo EsCorreoValido y compara si lo ingresado coincide con lo que es valido
            {
                Validaciones.LimpiarP(); // si no es valido se limpia la pantalla para que no se acumulen advertencias y se pide un nombre valido
                Console.WriteLine("Correo inválido. Por favor, ingrese una dirección de correo válida."); // mensaje de advertencia
                correo = Console.ReadLine(); // se lee lo introducido y se vuelve a validar para ver si ahora esta bien
            }

            Validaciones.LimpiarP(); // limpia la consola
            Console.WriteLine("Empleado agregado exitosamente:"); // Se limpia la pantalla y se muestra que el empleado fue agregado correctamente
            Console.WriteLine($"Cédula: {cedula}"); // Se muestra la cedula y se llama al nombre de la variable donde se alberga el dato
            Console.WriteLine($"Nombre: {nombre}"); // Se muestra el nombre y se llama al nombre de la variable donde se alberga el dato
            Console.WriteLine($"Apellido: {apellido}"); // Se muestra el apellido y se llama al nombre de la variable donde se alberga el dato
            Console.WriteLine($"Correo electrónico: {correo}"); // Se muestra el correo electronico y se llama al nombre de la variable donde se alberga el dato


            Console.WriteLine("\nOpciones:"); // Se da un mensaje de que se pueden seleccionar opciones
            Console.WriteLine("1. Guardar cambios"); // la primera guarda cambios
            Console.WriteLine("2. Salir al menú principal (Presione F)"); // la segunda nos devuelve al menu principal

            ConsoleKeyInfo optionKey = Console.ReadKey(); // este metodo permite que mediante una tecla en especifico se realize un opcion, lee lo que introducio el usuario y lo almacena en optionKey
            if (optionKey.Key == ConsoleKey.F) // compara si optionKey es igual a F si lo es nos regresa al menu sino continua.
            {
                return; // Regresar al menú principal
            }
            else if (optionKey.Key == ConsoleKey.D1 || optionKey.Key == ConsoleKey.NumPad1) // verifica que el usuario ingrese 1 ya sea desde la parte superior del teclado o desde el teclado numerico
            {
                // Lógica para guardar al empleado solo si llega a ser necesario
                Console.WriteLine("\nEmpleado guardado."); // se muestra que el nuevo empleado fue guardado correctamente
                Console.WriteLine("\nPresione cualquier tecla para regresar al menú principal..."); // al final para volver al menu principal se puede presionar cualquier tecla
                Console.WriteLine("Gracias!"); // mensaje de agradecimiento
                Console.ReadKey(); // lee lo que el usuario introduce y lo redirige al menu principal
            }

        }


        public static void MeNu()
        {

            while (true)
            {

                Validaciones.LimpiarP(); // Limpia la consola y muestra el Menú Principal.
                                         // Solicita al usuario una opción.

                Console.WriteLine("Menú Principal:"); // Se muestra el mensaje de que se encuentra en el menu principal
                Console.WriteLine("1. Ver todos los salarios"); // se da una opcion para ver todos los salarios 
                Console.WriteLine("2. Agregar empleado"); // otra opcion para agregar un empleado
                Console.WriteLine("3. Salir"); // y una ultima para salir de programa por completo

                Console.Write("Seleccione una opción: "); // Se le pide al usuario que seleccione una opcion 
                string opcionPrincipal = Console.ReadLine(); // se lee la opcion ingresada y la almacena en una variable de tipo string llamada opcionPrincipal

                if (!Validaciones.EsOpcionValida(opcionPrincipal)) // Se llama a la clase de validaciones en especifico al metodo EsOpcionValida y se llama a opcionPrincipal para que la valide
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida."); // Si la opcion no es valida se muestra un mensaje de advertencia
                    Console.ReadLine(); // se lee lo que el usuario ingreso
                    continue; // si es una opcion valida permite continuar al siguiente submenu
                }

                switch (opcionPrincipal)
                {
                    case "1":
                        while (true)
                        {
                            Validaciones.LimpiarP(); // Limpia la consola y muestra el Submenú de Ver Salarios.

                            Console.WriteLine("Ver Salarios:"); // se muestra el mensaje de que esta en el submenu llamado Ver Salarios
                            Console.WriteLine("1. Buscar todos los salarios"); // se nos da la primer opcion que es buscar todos los salarios
                            Console.WriteLine("2. Buscar empleado por ID"); // la segunda que es para buscar un empleado por id
                            Console.WriteLine("3. Regresar al menú principal"); // luego una ultima opcion que nos permite regresar directamente al menu principal

                            Console.WriteLine("Seleccione una opción: "); // se solicita al usuario que ingrese una opcion
                            string opcionSubmenu = Console.ReadLine(); // se lee la opcion y se almacena en una variable de tipo string llamada opcionSubmenu

                            if (!Validaciones.EsOpcionValida(opcionSubmenu)) // se llama a la clase Validaciones especificamente a la clase EsOpcionValida y se compara con la variable donde esta almacenada nuestra respuesta
                            {
                                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida."); // si no coincide con ninguna de las opciones se manda un mensaje de advertencia
                                Console.ReadLine(); // se lee la nueva opcion y se valida
                                continue; // si esta dentro de las opciones disponibles nos permite continuar si no nos devuelve el mensaje de advertencia
                            }

                            switch (opcionSubmenu) // segun lo que introducimos anteriormente, se muestra un caso para cada opcion
                            {
                                case "1": // en el primer caso se llama a BuscarTodosSalarios();
                                    BuscarTodosSalarios();
                                    break;
                                case "2": // en el segundo caso se llama a BuscarSalarioPorID();
                                    BuscarSalarioPorID();
                                    break;
                                case "3":
                                    break; // Finaliza del bucle interno (submenú).
                            }

                            break; // Finaliza el bucle interno después de que se haya ejecutado una opción válida.
                        }
                        break;
                    case "2":
                        AgregarEmpleado(); // llama al metodo agregar empleado
                        break;
                    case "3":
                        Console.WriteLine("Saliendo del programa."); // muestra un mensaje de despedida
                        return; // finaliza el programa

                }

            }


        }

    }
}

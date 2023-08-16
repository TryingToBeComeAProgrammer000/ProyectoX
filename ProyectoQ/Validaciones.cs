using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ProyectoQ
{
    internal class Validaciones
    {

        public static void LimpiarP() // metodo para limpiar la pantalla
        {

            Console.Clear();

        }

        public static bool EsOpcionValida(string input) // validacion para opciones de menu y submenu
        {
            return input == "1" || input == "2" || input == "3" || input == "4"; // la opcion tiene que ser igual a 1 o 2 o 3 o 4 para que sea valida
        }

        public static bool EsCedulaValida(string input) // validacion para cedula y numeros
        {
            return !string.IsNullOrWhiteSpace(input) && input.All(char.IsDigit); // lee lo introducido por consola y ve que no este vacio ni tenga espacios en blanco ademas de que valida que todos los caracteres sean numeros.
        }

        public static bool EsNombreValido(string input) // validacion para nombre y apellido
        {
            return !string.IsNullOrWhiteSpace(input) && input.All(c => char.IsLetter(c)); // lee lo introducido por consola y ve que no este vacio ni tenga espacios en blanco ademas de que valida que todos los caracteres sean letras
        }

        public static bool EsCorreoValido(string input) // validacion para correo
        {
            string pattern = @"^[a-zA-Z0-9!#$%&'*+\-/=?^_`{|}~.@]+$"; // toma una cadena de texto y nos devuelve un true o un false si no es valido
            return Regex.IsMatch(input, pattern); // el regex valida si lo ingresado es igual al patron pattern, esto tambien devuelve un true o false si no es valido
        }



    }
}

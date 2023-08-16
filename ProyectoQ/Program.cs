
using System;
using System.Collections.Generic;

namespace ProyectoQ
{
    internal class Program
    {
        static string pathEmpleados = $@"C:\Users\ryome\OneDrive\Escritorio\Nueva carpeta(4)\ProyectoQ\ProyectoQ\Archivos\Empleados.txt";
        static string pathPlanillas = $@"C:\\Users\\ryome\\OneDrive\\Escritorio\\Nueva carpeta (4)\\ProyectoQ\\ProyectoQ\\Archivos\\Plantilla.txt";
        static void Main(string[] args)
        {
            List<string> empleados = new List<string>();
            List<string> planillas = new List<string>();
            List<string> Datosparaarchivosnuevo = new List<string>();
            Archivos archivos = new Archivos();
            // guardar los datos leidos
            empleados = archivos.LeerArchivo(pathEmpleados);
            planillas = archivos.LeerArchivo(pathPlanillas);

            //variables para cedula
            string cedula = "200456789";
                string emp;
            string plan;

            //buscar por medio de la cedula
            emp = empleados.Find(e => e.Contains(cedula));
            plan = planillas.Find(p => p.Contains(cedula));

            //division de cadenas para  la creacion del archivo
            string[] ArrayEmpleado = emp.Split(" ");
            string[] ArrayPlanilla = plan.Split(" ");

            //ahora para la impresion del dato del empleado
            Datosparaarchivosnuevo
                .Add(
                ArrayEmpleado[1]+" "+
                 ArrayEmpleado[2] + " " +
                  ArrayEmpleado[3] + " " +
                 ArrayEmpleado[1]
                );
            string pathDelNuevoArchivo = $@"C:\Users\ryome\OneDrive\Escritorio\Nueva carpeta (4)\ProyectoQ\ProyectoQ\Archivos\{ArrayEmpleado[0]}.txt";
            archivos.CrearArchivo(pathDelNuevoArchivo, Datosparaarchivosnuevo);
            
            Console.WriteLine("Bienvenido al organizador de datos de empleados");
            Console.WriteLine("");
            Console.WriteLine("─── ❖ ── ✦ ── ❖ ─── ✦ ─── ❖ ── ✦ ── ❖ ───");
            Console.WriteLine("");
            Console.WriteLine("A continuacion hay dos opciones seleccione la que necesite");
            Console.WriteLine("");
            Console.WriteLine("1- Ver todos los salarios");
            Console.WriteLine("2- Buscar salario por un ID");
            Console.WriteLine("3- Salir");
            Console.WriteLine("");
            Console.WriteLine("Seleccione una opcion");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Aqui estan los salarios");
            }
            else if (opcion == 2)
            {

                Console.WriteLine("Aqui buscas un salario por ID");

            }
            else if (opcion == 3)
            {

                Console.WriteLine("Adios!");

            }
           
          
        }

        
       
      

























































            
        
    }
}

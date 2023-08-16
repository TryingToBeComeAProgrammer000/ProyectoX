
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
                ArrayEmpleado[1] + " " +
                 ArrayEmpleado[2] + " " +
                  ArrayEmpleado[3] + " " +
                 ArrayEmpleado[1]
                );
            string pathDelNuevoArchivo = $@"C:\Users\ryome\OneDrive\Escritorio\Nueva carpeta (4)\ProyectoQ\ProyectoQ\Archivos\{ArrayEmpleado[0]}.txt";
            archivos.CrearArchivo(pathDelNuevoArchivo, Datosparaarchivosnuevo);

            Menu.MeNu();





























































        } 
        
    }
}

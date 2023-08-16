using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoQ
{
    public class Archivos
    {
        private List<string> datos;

        public void CrearArchivo(string path,List<string>datosParametro)
        {
            using(StreamWriter swf = File.CreateText(path))
            {
                foreach (var dato in datosParametro)
                    swf.WriteLine(dato);
                    swf.Close();
            }
        }
        // leer un archivo
        public List<string> LeerArchivo(string path)
        {
            datos = new List<string>();
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.EndOfStream != true)
                    {
                        datos.Add(sr.ReadLine());
                    }
                            
                    

                }
                
            }

            else
            {
                Console.WriteLine("El archivo de referencia no existe");
            }
            return datos;
        }
        //escribir un archivo
        public void EscribirArchivo(string cadena ,string path)
        {
            if (File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(cadena);
                    sw.Close();
                }
            }
            else Console.WriteLine("El archivo de referencia no existe");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Data;
using System.Windows.Forms;

namespace Switcher_Steam
{
    class funciones
    {   //creo un array de 5*2, donde el indice de la fila es la opcion seleccionada, la primer columna
        //es el nombre, y la segunda columna es el id.
        
        public static string[,] variable2 = new string[7, 2];


        //llama al metodo Process.Start dentro de System
        private static void Ejecutar(string steamid)
        {
            System.Diagnostics.Process.Start(steamid);
        }


        //mediante un index introducido por parametro, se obtiene el id y se utiliza la funcion ejecutarJuego
        public static void launcher(int opc)
        {
            string url;
            if (opc <= 4)
            {
                string id = variable2[opc, 1];
                url = "steam://rungameid/" + id;
            }
            else
            {
                url = variable2[opc, 1];
            }
            Ejecutar(url);
        }


        //guarda dentro del array el nombre e id del juego a modificar, llama a la funcion guardarJuegos para 
        //conseguir persistencia de datos
        public static void modificarOpcion(int opc, string nuevoid, string nombreNuevo)
        {
            variable2[opc, 1] = nuevoid;
            variable2[opc, 0] = nombreNuevo;
            guardarJuegos();

        }
        

        //obtiene los datos de un archivo txt
        //separado por comas (index, nombre, id)
        //los ingresa en el array declarado anteriormente
        public static void CargarDatos()
        {
            string file = Application.StartupPath + @"\\Resources\recursos.txt";
            //Se carga el archivo de texto
            StreamReader sr = new StreamReader(file);
            //se selecciona la primera linea
            string line = sr.ReadLine();
            //mientras haya lineas escritas
            while (line != null)
            {
                string[] sep = line.Split(',');//se separa la linea tomada por comas
                for (int i = 0; i <= 1; i++)
                {
                    variable2[Convert.ToInt32(sep[0]) - 1, i] = sep[i + 1];// se carga el array

                }

                line = sr.ReadLine();
            }
            sr.Close();

        }
        //convierte el array en texto plano para la persistencia de datos
        public static void guardarJuegos()
        {
            string mydocpath = Application.StartupPath + @"\\Resources\recursos.txt";

            using (StreamWriter sw = File.CreateText(mydocpath))
            {
                for (int i = 0; i < 7; i++)
                {
                    int num = i + 1;
                    string line = "";
                    line = num +","+ variable2[i, 0] +","+ variable2[i, 1];
                    sw.WriteLine(line);

                }
                sw.Close();
            }


        }

        
    }
}

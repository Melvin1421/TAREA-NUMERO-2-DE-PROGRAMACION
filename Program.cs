using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_NUMERO_2_DE_PROGRAMACION
    //bloque de codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] genero = new string[10];
            string[] estudiantes = new string[10];

            int femenino = 0;
            int masculino = 0;

            double[] edad = new double[10];

            double prom = 0;



            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.Write("INGRESE EL NOMBRE DEL ALUMNO/A {0}:  ", i);
                estudiantes[i] = Console.ReadLine();

                Console.Write(" GENERO F / M  :  ", i);
                genero[i] = Console.ReadLine();


                Console.Write("EDAD DEL ALUMNO/A : ", i);
                edad[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();


            }
            Console.WriteLine();
            Console.WriteLine("DATOS DE LOS ESTUDIANTES: ");
            Console.WriteLine();


            // Array.Sort(estudiantes);


            for (int i = 0; i < estudiantes.Length; i++)
            {

                Console.WriteLine("SU NOMBRE ES : {0} | DEL GENERO : {1}", estudiantes[i], genero[i]);

                if (genero[i] == "f")
                {
                    femenino += 1;
                }

                if (genero[i] == "m")
                {
                    masculino += 1;
                }

                prom = edad.Average();
            }

            Console.WriteLine();
            Console.WriteLine("LA CANTIDAD DE ESTUDIANTES DEL GENERO FEMENINO ES: {0}", femenino);
            Console.WriteLine("LA CANTIDAD DE ESTUDIANTES DEL GENERO MASCULINO ES: {0}", masculino);
            Console.WriteLine("EL PROMEDIO DE LAS EDADES DE LOS ESTUDIANTES ES DE: {0}", prom);


            Console.ReadKey();

        }
    }
}

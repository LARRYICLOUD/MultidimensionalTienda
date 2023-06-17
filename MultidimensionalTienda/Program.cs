using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalTienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipo[,] nombre= new tipo[filas,columnas]
            double[,] ventas = new double[4, 3] { { 100, 120, 205 }, { 115, 196, 300 }, { 157, 172, 245 }, { 130, 180, 281 } };


            Console.WriteLine(ventas[3, 2]);

            //Declaracion e instancia de matriz de 3 dimensiones
            //int[,,] matriz3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };


            








            //declaracion e instancia de matriz de 3 dimensiones
            //double[,,] ventasAño = new double[5, 3, 3];


        }
    }
}

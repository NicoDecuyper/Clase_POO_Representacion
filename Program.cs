using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_1_op
{
    internal class Program
    {

        static Random azar=new Random();

        static void Main(string[] args)
        {
            int posicion1, posicion2;
            string nombre1, nombre2;
            int pie1, pie2, cabecera1, cabecera2;
            int cabeza, cola;
            bool finJuego;
            int dado;

            #region iniciar posicion jugador 1 y 2
            posicion1 = 1;
            posicion2 = 1;
            #endregion

            #region solicitar nombre jugador 1 y 2
            Console.WriteLine("Ingrese nombre jugador 1 ");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese nombre jugador 2 ");
            nombre2 = Console.ReadLine();
            #endregion

            #region inicializar las dos escaleras
            pie1=azar.Next(1, 100);
            cabecera1=azar.Next(pie1, 100);
            pie2 = azar.Next(1, 100);
            cabecera2 = azar.Next(pie2, 100);
            #endregion

            #region inicializar la serpiente
            cola = azar.Next(1, 100);
            cabeza= azar.Next(cola, 100);
            #endregion

            #region iterar jugadas
            finJuego=true;
            do
            {

                #region determinar avance jugador 1
                dado=azar.Next(1, 7);
                posicion1 += dado;

                if (cabeza == posicion1)
                {
                    posicion1 = cola;
                }
                if (pie1 == posicion1)
                {
                    posicion1 = cabecera1;
                }

                if (pie1 == posicion1)
                {
                    posicion1 = cabecera1;
                }

                Console.WriteLine("jugador 1 : " + posicion1);
                #endregion
                Console.WriteLine("jugador 1 - posición: " + posicion1);
                #region determinar avance jugador 2
                dado = azar.Next(1, 7);
                posicion2 += dado;

                if (cabeza == posicion2) posicion2 = cola;

                if (pie2 == posicion2) posicion2 = cabecera2;

                if (pie2 == posicion2) posicion2 = cabecera2;

                Console.WriteLine("jugador 2 : " + posicion2);
                #endregion
                #endregion
                Console.WriteLine("jugador 2 - posición: " + posicion2);

                finJuego = posicion1>=100 || posicion2 >= 100;

            } while (!finJuego);

            if (posicion1 >= 100 ^ posicion2 >= 100)
            {
                if (posicion1 >= 100)
                {
                    Console.WriteLine("el ganador es " + nombre1);
                }
                else
                {
                    Console.WriteLine("el ganador es " + nombre2);
                }
            }
            else
            {
                Console.WriteLine("No hay ganador");
            }
            Console.ReadKey();
        }
    }
}

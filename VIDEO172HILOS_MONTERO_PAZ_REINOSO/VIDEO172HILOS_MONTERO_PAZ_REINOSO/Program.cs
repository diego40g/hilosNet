using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace VIDEO172HILOS_MONTERO_PAZ_REINOSO
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread hilo1 = new Thread(HilosVarios.run);
            Thread hilo2 = new Thread(HilosVarios2.run);

            hilo2.Start(); //imprime Terino tarea hilo1 y hilo2
            hilo1.Start();

            Console.WriteLine("Termino las tareas");
        }
    }
    class HilosVarios
    {
        [ThreadStatic]
        static int threadSpecific;
        public static void run()
        {
            threadSpecific = Thread.CurrentThread.ManagedThreadId;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(i + "Ejecutando hilo " + Thread.CurrentThread.ManagedThreadId);

                Thread.Sleep(100);
            }
        }
    }
    class HilosVarios2  
    {
        [ThreadStatic]
        static int threadSpecific;
        
        public static void run()
        {
            threadSpecific = Thread.CurrentThread.ManagedThreadId;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(i + "Ejecutando hilo " + Thread.CurrentThread.ManagedThreadId);

                Thread.Sleep(100);
            }
        }
    }
}

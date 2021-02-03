using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace VIDEO171HILOS_MONTERO_PAZ_REINOSO
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
            Thread hilo2 = new Thread(HilosVarios.run);
            hilo1.Start();
            hilo1.Join();
            hilo2.Start();
            hilo2.Join();
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
            for(int i =0; i < 15; i++)
            {
                Console.WriteLine(i + "Ejecutando hilo " + Thread.CurrentThread.ManagedThreadId);

                Thread.Sleep(100);
            }
        }
    }
}

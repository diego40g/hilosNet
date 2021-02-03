using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace VIDEO174HILOS_MONTERO_PAZ_REINOSO
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Banco b = new Banco();
            //b.cuentasImp();
            for(int i = 0; i < 100; i++)
            {
                EjecucionTransferencia r = new EjecucionTransferencia(b,i,2000);
                Thread t = new Thread(r.run);
                t.Start();
            }  
        }
    }
    class Banco
    {
        private double[] cuentas { get; set; }

        public void cuentasImp()
        {
            for (int i = 0; i < cuentas.Length; i++)
            {
                Console.WriteLine(cuentas[i]);
            }
        }
        public Banco()
        {
            cuentas = new double[100];
            for (int i = 0; i < cuentas.Length; i++)
            {
                cuentas[i] = 2000;
            }
        }

        public void transferencia(int cuentaOrigen, int cuentaDestino, double cantidad)
        {
            if (cuentas[cuentaOrigen] < cantidad)//evalúa q el saldo no es inferior a la transferencia
            {
                return;
            }
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            cuentas[cuentaOrigen] -= cantidad;//dinero q sale de la cuenta origen
            Console.WriteLine(cantidad + " de " + cuentaOrigen + " para " + cuentaDestino);
            cuentas[cuentaDestino] += cantidad;
            Console.WriteLine("Saldo total: " + getSaldoTotal());
        }

        public double getSaldoTotal()
        {
            double suma_cuentas = 0;
            foreach (var a in cuentas)
            {
                suma_cuentas += a;
            }
            return suma_cuentas;
        }
    }
    class EjecucionTransferencia
    {
        private Banco banco;
        private int deLaCuenta;
        private double cantidadMax;
        public EjecucionTransferencia(Banco b, int de, double max)
        {
            banco = b;
            deLaCuenta = de;
            cantidadMax = max;
        }
        public void run()
        {
            var rand = new Random();
            try
            {
                while (true)
                {
                    int paraLaCuenta = rand.Next(100);
                    double cantidad = cantidadMax * rand.NextDouble();
                    banco.transferencia(deLaCuenta, paraLaCuenta, cantidad);
                    Thread.Sleep(rand.Next(100));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace VIDEO173HILOS_MONTERO_PAZ_REINOSO
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }
    }

    class Banco
    {
        private double[] cuentas;

        public Banco()
        {
            cuentas = new double[100];
            for (int i = 0; i < cuentas.Length; i++)
            {
                cuentas[i] = 2000;
            }
        }

        public void transferencia (int cuentaOrigen, int cuentaDestino, double cantidad)
        {
            if (cuentas[cuentaOrigen] < cantidad)//evalúa q el saldo no es inferior a la transferencia
            {
                return;
            }
            Console.WriteLine(Thread.CurrentThread.ToString());
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
}

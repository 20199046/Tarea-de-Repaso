using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asignacion2
{
    class Cliente
    {
        private string nombre;
        private int monto;

        public Cliente(string name)
        {
            nombre = name;
            monto = 0;
        }

        public void Depositar(int mon)
        {
            monto = monto + mon;
        }

        public void Extraer(int mon)
        {
            monto = monto - mon;
        }

        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }
    }

    class Banco
    {
        private Cliente cliente1, cliente2, cliente3;

        public Banco()
        {
            cliente1 = new Cliente("jairo");
            cliente2 = new Cliente("lisandra");
            cliente3 = new Cliente("chriphtofer");
        }

        public void Operar()
        {
            cliente1.Depositar(5000);
            cliente2.Depositar(7000);
            cliente3.Depositar(4500);
            cliente3.Extraer(8500);
        }

        public void DepositosTotales()
        {
            int ttl = cliente1.RetornarMonto() + cliente2.RetornarMonto() +
                    cliente3.RetornarMonto();

            Console.WriteLine("El total de dinero en el banco es:" + ttl);

            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }

        static void Main(string[] args)
        {
            Banco banco1 = new Banco();
            banco1.Operar();
            banco1.DepositosTotales();
            Console.ReadKey();
        }
    }
}


 using System;

namespace Asignacion1
{
    public class CuentaBancaria
    {

        public string titularCta;
        public string cuit;
        public decimal saldo;
        public long numeroCBU;
        


        static void Main(string[] args)
        {
            CuentaBancaria instancia1 = new CuentaBancaria();
            CuentaBancaria instancia2 = new CuentaBancaria();

            instancia1.titularCta = "Juan Alonso";
            instancia1.cuit = "20 - 26987456 - 7";
            instancia1.saldo = 1258.75m;
            instancia1.numeroCBU = 1236547896554;
            Console.WriteLine("instancia1 titularCta = {0} cuit = {1} saldo = {2} numeroCBU = {3}" 
                , instancia1.titularCta, instancia1.cuit, instancia1.saldo, instancia1.numeroCBU);

            instancia2.titularCta = "Alberto Lopez";
            instancia2.cuit = "23-15654321-9";
            instancia2.saldo = 25698.78m;
            instancia2.numeroCBU = 9876546546557;
            Console.WriteLine("instancia1 titularCta = {0} cuit = {1} saldo = {2} numeroCBU = {3}"
                , instancia2.titularCta, instancia2.cuit, instancia2.saldo, instancia2.numeroCBU);

            Console.WriteLine("Presiona enter para salir");
            Console.ReadKey();





            /*instancia1.titularCta = "Juan Alonso";
            instancia1.cuit = "20 - 26987456 - 7";
            instancia1.saldo = 1258.75m;
            instancia1.numeroCBU = 1236547896554;*/

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10_practica3
{
    class Program
    {
        static void Main(string[] args)
        {

            double monto = 0, mil = 0, quinientos = 0, cien = 0;
            string Clave;

            Console.WriteLine("Ingrese su Clave....");
            Clave = Console.ReadLine();

            Console.WriteLine("Ingrese el Monto");
            monto = Convert.ToDouble(Console.ReadLine());

            if (monto % 3 == 0)
            {
                mil = monto / 1000;
                monto = monto % 1000;
                quinientos = monto / 500;
                monto = monto % 500;
                cien = monto / 100;
                monto = monto % 100;


                Console.WriteLine("El monto en billetes de $1000 es................ " + mil , + quinientos, + cien );
                mil = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine("El monto en billetes de $500 es................. " + quinientos);
                //quinientos = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine("El monto en billetes de $100 es................. " + cien);
                //cien = Convert.ToDouble(Console.ReadLine());

            }
            else
            {
                Console.WriteLine("Monto no valido...");
            }

           


            Console.ReadLine();


        } 

        
        

        
        
    }
}

using System;

namespace Ejercicio_M2._1
{
    class Program
    {

        static void Main(string[] args)
        {

            //VARIABLES ESPECIFICAS FASE 1

            string strName = "Marcos";
            string strLastName1 = "Garcia";
            string strLastName2 = "García";
            int intDay = 3;
            int intMonth = 6;
            int intYear = 1962;

            //VARIABLES ESPECIFICAS FASE 2

            const int intLeapYear = 1948;
            int intPeriodLeapYear = 4;
            int intQtyLeapYear = 0;
            bool boolBornLeapYear = false;

            //VARIABLES ESPECIFICAS FASE 3

            string strNoLeapYear= "El meu any de naixement no és de traspàs";
            string strYesLeapYear = "El meu any de naixement és de traspàs";

            string strFullName= strName + " " + strLastName1 + " " + strLastName2;

            Console.WriteLine("Ejercicio FASE 1");
            Console.WriteLine();
            Console.WriteLine(strLastName1+ " " + strLastName2+" " + strName);
            Console.WriteLine();
            Console.WriteLine(intDay + "/" + intMonth + "/" + intYear);
            Console.WriteLine();



            for (int i = intLeapYear; i <= intYear; i += intPeriodLeapYear) {
                intQtyLeapYear++;
                if (i == intYear) { boolBornLeapYear = true; }

                // FASE 3
                if (i == intLeapYear) {Console.WriteLine("Anys de traspàs:");}
 
                Console.WriteLine(i);



                /* No es necesario cambiar ni la condición ni el tipo de intLeapYear.Imprimiendo
                  el valor que adquiere el contador del bucle, podemos conocer cuales 
                    son los años bisiestos*/
                // FIN FASE 3

            }

            Console.WriteLine();
            Console.WriteLine("Ejercicio FASE 2");
            Console.WriteLine();
            Console.WriteLine("La quantitat d'anys de traspàs és: " + intQtyLeapYear);
            Console.WriteLine();


            Console.WriteLine("Ejercicio FASE 3");
            Console.WriteLine();
            Console.WriteLine("Mi nombre es " + strFullName);
            Console.WriteLine();

            Console.Write("Nací el ");

            Console.WriteLine(addZero(intDay) + addZero(intMonth) + intYear);
            Console.WriteLine();

            if (!(boolBornLeapYear)){

                Console.WriteLine(strNoLeapYear);

            }
            else {
                Console.WriteLine(strYesLeapYear);
            }

        }
        /* Función que añade un cero si la longitud del parámetro envado es 1*/
        static string addZero(int value) {

            if (value.ToString().Length == 1)
            {
                return "0" + value.ToString()+ "/";

            }
            else
            {
                return value.ToString()+"/";
            }
        
        }
    }
}

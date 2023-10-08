using Parcial.Clases;
using System;
namespace Parcial
{

    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("PARCIAL!");

                int day, month, year;
                Console.Write("Ingresar el dia :");
                day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el mes :");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingresar el año :");
                year = Convert.ToInt32(Console.ReadLine());

                Persona dateObject = new Persona(year, month, day);
                Console.WriteLine(dateObject.ToString());

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }




            
        }
    }
}




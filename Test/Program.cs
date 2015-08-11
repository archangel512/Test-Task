using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleSide_1, triangleSide_2, triangleSide_3;

            try
            {
                Console.WriteLine("Side_1 = ");
                triangleSide_1 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Side_2 = ");
                triangleSide_2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Side_3 = ");
                triangleSide_3 = Convert.ToDouble(Console.ReadLine());

                bool treangleExist = (triangleSide_1 < triangleSide_2 + triangleSide_3) && (triangleSide_2 < triangleSide_1 + triangleSide_3) && (triangleSide_3 < triangleSide_1 + triangleSide_2);

                if (treangleExist)
                {

                    Triangle newTriangle = new Triangle(triangleSide_1, triangleSide_2, triangleSide_3);
                    
                    Console.WriteLine("Area = " + newTriangle.Area());
                }
                else
                    throw new Exception("Triangle does not exist");
            }
           
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}

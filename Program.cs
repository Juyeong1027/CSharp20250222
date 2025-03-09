using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Serialization;


namespace CSharpStudy20250222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * 찍는 문제
            // 문제 1. 왼쪽 정렬된 직각 삼각형
            // *
            // **
            // ***
            // ****
            // *****

            //for (int a = 1; a <= 5; a++)
            //{
            //    for (int b = 1; b <= a; b++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("");

            //for (int c = 1; c <= 5; c++)
            //{
            //    for (int d = 5; d >= c; d--)
            //    {

            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}


            // 문제 2. 오른쪽 정렬된 직각 삼각형

            //for (int e = 1; e <= 5; e++)
            //{
            //    for (int f = 4; f >= e; f--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int g = 1; g <= e; g++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}



            // 문제 3. 피라미드(중앙 정렬)
            //    *
            //   ***
            //  *****
            // *******
            //*********

            //for (int h = 1; h <= 5; h++) // Z값 조건 : 5칸 / X칸 조건 : 9
            //{
            //    for (int i = 4; i >= h; i--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < h; j++)
            //    { 
            //        Console.Write("*");
            //        for (int k = 1; k <= j; k+=4)
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine("");
            //}


            // 문제 4. 다이아몬드 

            string ab = Console.ReadLine();
            int acac = int.Parse(ab);

            int ah = acac / 2 + 1;
            int ad = acac / 2 - 1;
            int ap = acac / 2;
            

            // 5 ( 상단 3 / 하단 2 )

            for (int h = 1; h <= ah; h++)
            {
                for (int i = acac; i >= h; i--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < h; j++)
                {
                    Console.Write("*");
                    for (int k = 0; k < j; k += ah)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            }
            for (int h = ap; h >= 1; h--)
            {
                for (int i = acac; i >= h; i--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < h; j++)
                {
                    Console.Write("*");
                    for (int k = 0; k < j; k += ad)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            }
        }
        }
    }

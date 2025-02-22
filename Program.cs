using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Serialization;

namespace CSharpStudy20250222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수의 선언과 데이터 타입
            // 정수형 데이터
            // (데이터 타입) (변수 이름) = (값)

            Console.WriteLine("Hello, World!");

            string myName = "Hello";
            Console.WriteLine(myName);

            int age = 25;
            Console.WriteLine(age);


            // 정수형 데이터
            int myint = 25;
            short myshort = 25;
            long mylong = 25;
            byte mybyte = 25;

            Console.WriteLine(myint);
            Console.WriteLine(myshort);
            Console.WriteLine(mylong);
            Console.WriteLine(mybyte);
        }
    }
}
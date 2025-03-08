﻿using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Serialization;


namespace CSharpStudy20250222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 놀이동산 입장권
            // 사용자로부터 나이, 군인 할인, 연간 회원 여부를 입력 받아서 입장 요금을 계산합니다.

            // 무료입장 조건
            // 1. 나이가 3세 이하
            // 2. 나이가 65세 이상
            // 3. 연간 회원

            // 할인 적용
            // 1. 군인 -> 30% 할인

            // 일반 요금
            // 성인(19~64) : 10,000원
            // 청소년(13~18) : 8,000원
            // 어린이(4~12) : 5,000원


            //성인 할인 : 7,000원


            // 출력 예시 
            // 나이를 입력 하세요 : 20
            // 군인인가요? (네/아니요) : 네
            // 연간 회원인가요? (네/아니요) : 아니요
            // 입장료 : '7,000'원 입니다

            // 출력 예시 
            // 나이를 입력 하세요 : 20
            // 군인인가요? (네/아니요) : 네
            // 연간 회원인가요? (네/아니요) : 네
            // 입장료 : 무료 입장입니다.




            Console.Write("나이를 입력하세요 : ");
            string ageInput = Console.ReadLine();



            int age = int.Parse(ageInput);



            if (age <= 3 || age >= 65 )
            {
                Console.WriteLine("입장료 : 무료 입장입니다.");
            }
            else if (age >= 4 && age <= 18){
                Console.Write("연간 회원이신가요? (네/아니요) : ");
                 string yuser = Console.ReadLine();

                if (yuser == "네")
                {
                    System.Console.WriteLine("입장료 : 무료 입장입니다.");
                }
                 else if (yuser == "아니요" && age <= 12)
                {
                    System.Console.WriteLine("입장료 : 5,000원 입니다.");
                }
                else{
                    System.Console.WriteLine("입장료 : 8,000원 입니다.");
                }
            }
            else 
            {
            Console.Write("군인이신가요? (네/아니요) : ");
            string army = Console.ReadLine();

            if (army == "네" && age >= 19){
                System.Console.WriteLine("입장료 : 7,000원 입니다.");
            }
            else 
            {
                Console.Write("연간 회원이신가요? (네/아니요) : ");
                 string yuser = Console.ReadLine();

                if (yuser == "네")
                {
                    System.Console.WriteLine("입장료 : 무료 입장입니다.");
                }
                 else
                {
                    System.Console.WriteLine("입장료 : 10,000원 입니다.");
            }
            }
            }
        }
        }
    }

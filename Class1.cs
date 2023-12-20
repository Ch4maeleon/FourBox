using System;
using System.Collections.Generic;

namespace FourBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 3, 2, 2, 3 };
            var s1 = new SortedSet<int>(arr);
            var s2 = new HashSet<int>(arr);

            Console.WriteLine("arr 출력 테스트");

            foreach (int i in arr)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine();

            Console.WriteLine("set 출력 테스트");

            foreach (int i in s1)
            {
                Console.WriteLine($"{i}");
            }

            s1.Add(4);
            s1.Add(5);

            s1.Remove(1);

            Console.WriteLine();

            Console.WriteLine("set 출력 테스트");

            foreach (int i in s1)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine();

            Console.WriteLine(s1.Contains(4));

            Console.WriteLine(s1.Count);

            Console.WriteLine();

            foreach (int i in s2)
            {
                Console.WriteLine($"{i}");
            }

            // sorted set : 순서가 있는 집합
            // hash set : 순서가 없는 집합

            // 데이터를 저장할때 바로 저장하지 않고 hast table을 사용하여 저장

            // 중복된 값을 골라내야할 때
            // 특정값이 있는지 빠르게 확인해야할 때
            // 순서가 상관없을 때

            // 만약 순서도 상관있으면서 중복제거 -> sorted set 사용

            // 
        }
    }
}
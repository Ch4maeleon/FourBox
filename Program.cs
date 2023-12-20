using System;
using System.Collections.Generic;

namespace FourBox
{
    public class FourBox
    {
        public HashSet<(int, int)> coordinates;

        public FourBox(string line)
        {
            DrawRect(line);
        }

        public void DrawRect(string line)
        {
            coordinates = new HashSet<(int, int)>();

            string[] values = line.Replace("  ", " ").Split();

            for (int i = 0; i < values.Length; i += 4)
            {
                var x1 = int.Parse(values[i]);
                var y1 = int.Parse(values[i + 1]);
                var x2 = int.Parse(values[i + 2]);
                var y2 = int.Parse(values[i + 3]);

                for (int x = x1; x < x2; x++)
                {
                    for (int y = y1; y < y2; y++)
                    {
                        coordinates.Add((x, y));
                    }
                }
            }

            /*
            foreach (var i in coordinates)
            {
                Console.WriteLine(i);
            }
            */
        }

        public int Area()
        {
            return coordinates.Count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string ln1 = "0 0 200 200  0 0 200 200  0 0 200 200  0 0 200 200";
            string ln2 = "1 2 4 4  2 3 5 7  3 1 6 5  7 3 8 6";

            FourBox boxes1 = new FourBox(ln1);
            FourBox boxes2 = new FourBox(ln2);

            Console.WriteLine($"Boxes1 Area : {boxes1.Area()}");
            Console.WriteLine($"Boxes2 Area : {boxes2.Area()}");
        }
    }
}

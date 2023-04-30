using System;
using System.Collections;
using Line_comparison;


namespace Line_comparison{

    public class Program {
        public static void Main(string[] args)
        {
            Line line = new Line(2,3,4,5);
           Line_comparison obj = new Line_comparison();
           obj.LengthOfTheLine(line);
           Console.WriteLine("Length of the line: " + line.LineLength);



        }

    }
}
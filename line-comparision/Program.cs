using System;
using System.Collections;


namespace Line_comparison{

    public class Program {
        public static void Main(string[] args)
        {
           Line line1 = new Line(2,3,5,7);
           Line line2 = new Line(4,4,7,7);
           Line.Compare(line1,line2);
        }
    }

}
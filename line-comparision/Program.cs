using System;
using System.Collections;
using Line_comparison;


namespace Line_comparison{

    public class Program {
        public static void Main(string[] args)
        {
            Line line1=new Line(233,65,43,87);
            Line line2=new Line(23,65,43,87);
            Line_comparison obj = new Line_comparison();
            obj.CompareLine(line1,line2);


        }

    }
}
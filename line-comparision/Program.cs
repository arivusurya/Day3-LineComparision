using System;
using System.Collections;


namespace Line_comparison{

    public class Program {
        public static void Main(string[] args)
        {
           Line line1 = new Line(2,3,5,7);
           Line line2 = new Line(4,4,7,7);
           double Length1 =line1.Calculate();
           double Length2 =line2.Calculate();

            if(Length1.CompareTo(Length2) == 0)
                Console.WriteLine("Both Lines are equal");
            else if(Length1.CompareTo(Length2) > 0)
                System.Console.WriteLine("Line1 is loger than Line2");
            else 
                System.Console.WriteLine("Line2 is Longer than Line 1");
    }

}
}
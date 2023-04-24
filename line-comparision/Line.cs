namespace Line_comparison
{
    public class Line
    {
        int x_1,y_1,x_2,y_2;
        public Line(int x_1,int y_1,int x_2,int y_2){
            this.x_1 =  x_1;
            this.y_1=y_1;
            this.x_2=x_2;
            this.y_2=y_2;
        }

        public double Calculate(){
            // A Length as 2 Points (x1, y1) and (x2, y2) - Length of a Line = sqrt( (x2 - x1) ^ 2 + (y2- y1) ^ 2)
            double Length = Math.Sqrt(Math.Pow((x_2-x_1),2)+Math.Pow((y_2-y_1),2));
            return Length;
        }

        public static void Compare(Line line1,Line line2){
            double Length1 = line1.Calculate();
            double Length2 = line2.Calculate();

            if(Length1 > Length2){
                Console.WriteLine("The Line 1 Longer than Line2");
            }else if(Length1 == Length2){
                Console.WriteLine("The both have the same Length");
            }
            else{
                Console.WriteLine("The Line 2 longer than Line 1");
            }
        }
    }
}
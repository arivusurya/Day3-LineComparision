using Line_comparison;
namespace Line_comparison
{
    public class  Line_comparison
    {

        public void LengthOfTheLine(Line line){
            double Length = Math.Sqrt(Math.Pow((line.x2-line.x1),2)+Math.Pow((line.y2-line.y1),2));
            line.LineLength = (int)Length;
        }

    }
}
using Line_comparison;
namespace Line_comparison
{
    public class  Line_comparison
    {

   
        public void CompareLenth(Line lin1,Line lin2){
            if(lin1.LineLength.Equals(lin2.LineLength)){
                System.Console.WriteLine("Both lines are equal");
            }else{
                System.Console.WriteLine("Both lines are not equal");
            }
        }
    }
}
using Line_comparison;
namespace Line_comparison
{
    public class  Line_comparison
    {

   
        public void Equals(Line lin1,Line lin2){
            if(lin1.LineLength.Equals(lin2.LineLength)){
                System.Console.WriteLine("Both lines are equal");
            }else{
                System.Console.WriteLine("Both lines are not equal");
            }
        }
        public void CompareLine(Line lin1,Line lin2){
            int status = lin1.LineLength.CompareTo(lin2.LineLength); 

            if(status > 0){
                System.Console.WriteLine("line 1 grater that Line2" );
            }  

            else if(status < 0){
                System.Console.WriteLine("line 1 is lesser than line2");
            }else{
                System.Console.WriteLine("both are  equal");
            }
        }


    }
}
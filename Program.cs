using System.Linq;
using System.Collections.Generic;

namespace Transportation 
{
    public class Program
    {

        public static void Main() 
        {
            // Build a collection of all vehicles that fly
            Transport Air = new Transport("Air");

            // With a single `foreach`, have each vehicle Fly()



            // Build a collection of all vehicles that operate on roads
            Transport Land = new Transport("Land");

            // With a single `foreach`, have each road vehicle Drive()



            // Build a collection of all vehicles that operate on water
            Transport Water = new Transport("Water");
            
            // With a single `foreach`, have each water vehicle Drive()
        }
    }
}
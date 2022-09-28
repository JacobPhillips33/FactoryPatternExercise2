using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ObjectOriented : IDataAccess
    {
        public void AccessDatabase()
        {
            Console.WriteLine("Accessing Object-Oriented Database...");
        }
    }
}

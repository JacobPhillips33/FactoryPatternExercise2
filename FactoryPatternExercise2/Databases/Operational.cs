using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class Operational : IDataAccess
    {
        public void AccessDatabase()
        {
            Console.WriteLine("Accessing Operational Database...");
        }
    }
}

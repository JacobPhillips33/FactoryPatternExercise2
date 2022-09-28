using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class Relational : IDataAccess
    {
        public void AccessDatabase()
        {
            Console.WriteLine("Accessing Relational Database...");
        }
    }
}

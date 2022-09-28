using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class Centralized : IDataAccess
    {
        public void AccessDatabase()
        {
            Console.WriteLine("Accessing Centralized Database...");
        }
    }
}

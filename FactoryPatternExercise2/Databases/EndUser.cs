﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class EndUser : IDataAccess
    {
        public void AccessDatabase()
        {
            Console.WriteLine("Accessing End-User Database...");
        }
    }
}

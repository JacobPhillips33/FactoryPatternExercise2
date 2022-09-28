using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class DataAccessFactory
    {
        public static IDataAccess BuildDatabase()
        {
            Console.WriteLine("What type of database would you like to access?");
            Console.WriteLine("(Distributed, Centralized, Cloud, Commercial, Object-Oriented, End-User, Graph, NoSQL, " +
                              "Open-Source, Operational, Personal, Relational)");
            Console.WriteLine();
                        
            var userInput = Console.ReadLine().ToLower();

            while (userInput != "distributed" && userInput != "centralized" && userInput != "cloud" && userInput != "commercial" &&
                   userInput != "object-oriented" && userInput != "end-user" && userInput != "graph" && userInput != "nosql" &&
                   userInput != "open-source" && userInput != "operational" && userInput != "personal" && userInput != "relational")
            {
                Console.WriteLine();
                Console.WriteLine("Invalid entry. Please try again.");
                Console.WriteLine();
                Console.WriteLine("What type of database would you like to access?");
                Console.WriteLine("(Distributed, Centralized, Cloud, Commercial, Object-Oriented, End-User, Graph, NoSQL, " +
                                  "Open-Source, Operational, Personal, Relational)");
                Console.WriteLine();
                userInput = Console.ReadLine().ToLower();
            }

            Console.WriteLine();

            switch (userInput)
            {
                case "distributed": return new Distributed();
                case "centralized": return new Centralized();
                case "cloud": return new Cloud();
                case "commercial": return new Commercial();
                case "object-oriented": return new ObjectOriented();
                case "end-user": return new EndUser();
                case "graph": return new Graph();
                case "nosql": return new NoSQL();
                case "open-source": return new OpenSource();
                case "operational": return new Operational();
                case "personal": return new Personal();
                case "relational": return new Relational();
                default: return new OpenSource();
            }  
        }
    }
}

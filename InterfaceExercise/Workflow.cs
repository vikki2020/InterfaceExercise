using System.Collections.Generic;

namespace InterfaceExercise
{
   
    public class Workflow:IWorkflow
    {
        public List<string> _workflows { get; set; }

        public Workflow()
        {
            _workflows = new List<string> {"turn on the laptop","surf on udemy","watch Mosh's tuto","do the damn exercises.." };


            
        }

        public void Execute()
        {
            System.Console.WriteLine("learning C#' workflow:\n");
            foreach(string workflow in _workflows)
            {
                System.Console.WriteLine($"{workflow}.\n");
            }

        }


    }
}

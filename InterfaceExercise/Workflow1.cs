using System.Collections.Generic;

namespace InterfaceExercise
{
    public class Workflow1:IWorkflow
    {
        public List<string> _workflows { get; set; }

        public Workflow1()
        {
            _workflows = new List<string> { "having bugggs", "accept it", "just solve the damn bugggs.." };
        }
        public void Execute()
        {
            System.Console.WriteLine("The daily life as a developer->\n");
            foreach(string workflow1 in _workflows)
            {
                System.Console.WriteLine($"{workflow1}.\n");

            }
        }
    }
}

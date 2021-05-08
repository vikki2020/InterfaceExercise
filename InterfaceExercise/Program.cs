using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            WorkflowEngine.Run(new Workflow());
            WorkflowEngine.Run(new Workflow1());
        }
    }
}

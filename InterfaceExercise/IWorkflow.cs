using System.Collections.Generic;

namespace InterfaceExercise
{
    public interface IWorkflow
    {
        List<string> _workflows { get; set; }
        void Execute();
    }
}

namespace InterfaceExercise
{
    public class WorkflowEngine
    {

        public static void Run(IWorkflow newWorkflows)
        {
            newWorkflows.Execute();

         
        }
    }
}

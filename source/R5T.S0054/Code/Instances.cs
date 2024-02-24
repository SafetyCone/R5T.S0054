using System;


namespace R5T.S0054
{
    public static class Instances
    {
        public static L0066.IContextOperations ContextOperations => L0066.ContextOperations.Instance;
        public static L0066.IContextOperator ContextOperator => L0066.ContextOperator.Instance;
        public static ISolutionFileContextOperations SolutionFileContextOperations => S0054.SolutionFileContextOperations.Instance;
    }
}
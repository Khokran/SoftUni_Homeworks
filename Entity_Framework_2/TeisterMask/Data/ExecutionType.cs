namespace TeisterMask.Data
{
    using System.Collections.Generic;
    public class ExecutionType
    {
        private IEnumerable<ExecutionType> executionType;

        public IEnumerable<ExecutionType> GetExecutionType()
        {
            IEnumerable<ExecutionType> executionType = null;
            return executionType;
        }

        public void SetExecutionType(IEnumerable<ExecutionType> value)
        {
            executionType = value;
        }
    }
}

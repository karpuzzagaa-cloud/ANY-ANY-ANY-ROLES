namespace AnyAnyAnyRoles
{
    public class AbilityExecutionResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public AbilityExecutionResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public static AbilityExecutionResult Successful(string message)
        {
            return new AbilityExecutionResult(true, message);
        }

        public static AbilityExecutionResult Failed(string message)
        {
            return new AbilityExecutionResult(false, message);
        }
    }
}
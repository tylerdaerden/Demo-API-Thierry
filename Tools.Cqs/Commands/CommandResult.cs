namespace Tools.Cqs.Commands
{
    internal class CommandResult : ICommandResult
    {
        public bool IsSuccess { get; init; }
        public bool IsFailure { get => !IsSuccess; }
        public string? Message { get; init; }

        internal CommandResult(bool isSuccess, string? message = null)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        
    }
}

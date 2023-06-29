namespace Tools.Cqs.Commands
{
    public interface ICommandHandler<TCommand>
        where TCommand : class, ICommandDefinition
    {
        ICommandResult Execute(TCommand command);
    }
}

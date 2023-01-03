namespace AllPlay.Application.Common.Abstractions;

public interface ICommandDispatcher
{
    Task SendAsync<TCommand>(TCommand command) where TCommand : class, ICommand;
}
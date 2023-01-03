namespace AllPlay.Application.Common.Abstractions;

public interface IDispatcher
{
    Task SendAsync<TCommand>(TCommand command) where TCommand : class, ICommand;

    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
}



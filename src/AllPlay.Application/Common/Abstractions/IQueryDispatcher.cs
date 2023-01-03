namespace AllPlay.Application.Common.Abstractions;

public interface IQueryDispatcher
{
    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
}
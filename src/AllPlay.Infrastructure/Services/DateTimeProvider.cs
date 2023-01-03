using AllPlay.Application.Common.Abstractions;

namespace AllPlay.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
using AllPlay.Application.Interfaces.Services;

namespace AllPlay.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
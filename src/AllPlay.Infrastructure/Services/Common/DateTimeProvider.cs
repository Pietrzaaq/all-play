using AllPlay.Application.Abstractions.Common;

namespace AllPlay.Infrastructure.Services.Common;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
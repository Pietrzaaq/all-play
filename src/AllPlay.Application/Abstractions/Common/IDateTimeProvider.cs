﻿namespace AllPlay.Application.Abstractions.Common;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
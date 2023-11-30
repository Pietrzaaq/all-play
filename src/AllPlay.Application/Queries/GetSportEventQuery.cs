﻿using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.DTO;
using MediatR;

namespace AllPlay.Application.Queries;

public record GetSportEventsQuery(
    Guid Id) : IRequest<SportEventDto>;

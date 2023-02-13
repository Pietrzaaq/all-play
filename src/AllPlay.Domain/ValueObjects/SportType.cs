using AllPlay.Domain.Exceptions;

namespace AllPlay.Domain.ValueObjects;

public sealed record SportType
{

    public string Sport { get; }

    private static readonly IReadOnlyList<string> ValidSportTypes = new List<string>
    {
        "basketball"
    };

    public SportType(string sport)
    {
        if (ValidSportTypes.Any(sportType => sportType.Equals(sport)))
        {
            throw new InvalidSportTypeException();
        }
        
        Sport = sport;
    }

}

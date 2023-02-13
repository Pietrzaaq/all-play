using System.Text.RegularExpressions;
using AllPlay.Domain.Exceptions;

namespace AllPlay.Domain.ValueObjects.Common;

public sealed record PhoneNumber
{
    public string Value { get; }
    private readonly string _phoneNumberRegex = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";

    public PhoneNumber(String phoneNumber)
    {
        var regex = new Regex(_phoneNumberRegex);
        
        if (!regex.IsMatch(phoneNumber))
        {
            throw new InvalidPhoneNumberException(phoneNumber);
        }

        Value = phoneNumber;
    }
}
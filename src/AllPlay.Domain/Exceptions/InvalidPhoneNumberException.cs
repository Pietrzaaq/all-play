namespace AllPlay.Domain.Exceptions;

public class InvalidPhoneNumberException : AllPlayException
{
    public string PhoneNumber { get; }

    public InvalidPhoneNumberException(string phoneNumber)
        : base($"Phone number {phoneNumber} is invalid")
    {
        PhoneNumber = phoneNumber;
    }
}
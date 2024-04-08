using System.Text.RegularExpressions;

namespace entities.Helpers;

public static class ValidationHelper
{
    public static bool IsPhoneNumber(string number)
    {
        return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
    }
}
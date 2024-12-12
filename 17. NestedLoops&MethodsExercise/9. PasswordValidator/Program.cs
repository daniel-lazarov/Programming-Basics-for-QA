string password = Console.ReadLine();

if (!IsValidLength(password) && !ContainsOnlyLettersAndDigits(password) && !HasAtLeastTwoDigits(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
    Console.WriteLine("Password must consist only of letters and digits");
    Console.WriteLine("Password must have at least 2 digits");
}
else if (!IsValidLength(password) && !ContainsOnlyLettersAndDigits(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
    Console.WriteLine("Password must consist only of letters and digits");
}
else if (!IsValidLength(password) && !HasAtLeastTwoDigits(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
    Console.WriteLine("Password must have at least 2 digits");
}
else if (!ContainsOnlyLettersAndDigits(password) && !HasAtLeastTwoDigits(password))
{
    Console.WriteLine("Password must consist only of letters and digits");
    Console.WriteLine("Password must have at least 2 digits");
}
else if (IsValidLength(password) && !HasAtLeastTwoDigits(password))
{
    Console.WriteLine("Password must have at least 2 digits");

}
else if (IsValidLength(password) && !ContainsOnlyLettersAndDigits(password))
{
    Console.WriteLine("Password must consist only of letters and digits");

}
else if (!IsValidLength(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}
else
{
    Console.WriteLine("Password is valid");
}

static bool IsValidLength(string password)
{
    return password.Length >= 6 && password.Length <= 10;
}

static bool ContainsOnlyLettersAndDigits(string password)
{
    return password.All(char.IsLetterOrDigit);
}

static bool HasAtLeastTwoDigits(string password)
{
    return password.Count(char.IsDigit) >= 2;
}
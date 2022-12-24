using System.Text.RegularExpressions;

// ...

string email = "example@example.com";

if (Regex.IsMatch(email, @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$"))
{
    // email adresi geçerli
}
else
{
    // email adresi geçersiz
}
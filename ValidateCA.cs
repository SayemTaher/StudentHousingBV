using System;
using System.Text.RegularExpressions;

public class ValidateCA
{
    public bool Isvalid_FirstName(string n)
    {
        System.Text.RegularExpressions.Regex check = new Regex(@"^([A-Za-z][A-Z-a-z]+)$");
        bool valid = false;
        valid = check.IsMatch(n);
        if (valid == true)
        {
            return valid;
        }
        else
        {
            return valid;
        }
    }

    public bool Isvalid_LastName(string m)
    {
        return Isvalid_FirstName(m);
    }


    public  bool Validate(string emailAddress)
    {
        var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        bool isValid = Regex.IsMatch(emailAddress, regex, RegexOptions.IgnoreCase);
        return isValid;
    }

    public bool checkPassword(string input)
    {
        bool hasNumber = false;
        bool hasCapital = false;
        bool hasLower = false;
        bool hasSpace = false;
        int minimum = 5;
        char currentCharacter;
        if (!(input.Length >= minimum))
        {
            return false;
        }
        for (int i = 0; i < input.Length; i++)
        {
            currentCharacter = input[i];
            if (char.IsDigit(currentCharacter))
            {
                hasNumber = true;
            }
            else if (char.IsUpper(currentCharacter))
            {
                hasCapital = true;
            }
            else if (char.IsLower(currentCharacter))
            {
                hasLower = true;
            }
            else if (!char.IsLetterOrDigit(currentCharacter))
            {
                hasSpace = true;
            }
            if (hasNumber && hasCapital && hasLower && hasSpace)
            {
                return true;
            }
        }
        return false;

    }
    }

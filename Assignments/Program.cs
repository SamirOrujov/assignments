using System;

class Reversed
{

    public static string Reverse(string Input)
    {
        char[] charArray = Input.ToCharArray();

        string reversedString = String.Empty;

        for (int i = charArray.Length - 1; i > -1; i--)
        {
            reversedString += charArray[i];
        }

        return reversedString;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Reverse("Salam necesen"));
    }
}

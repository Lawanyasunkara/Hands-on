using System;
class problem12
{
    bool TestForNullOrEmpty(string s)
    {
        bool result;
        result = s == null || s == string.Empty;
        return result;
    }

    string s1 = null;
    string s2 = "";
    Console.WriteLine(TestForNullOrEmpty(s1));
    Console.WriteLine(TestForNullOrEmpty(s2));
}
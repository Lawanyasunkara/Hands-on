using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
{
    internal class prob10
    {
        var users = new Dictionary<string, int>()
{
    { "John Doe", 41 },
    { "Jane Doe", 38 },
    { "Lucy Brown", 29 },
};

users["Paul Brown"] = 33;
users.Add("Thomas Pattison", 34);

Console.WriteLine(string.Join(", ", users));

users.Remove("Jane Doe");

Console.WriteLine(string.Join(", ", users));

users.Clear();

if (users.Count == 0)
{
    Console.WriteLine("The users dictionary is empty");
}
    }
}

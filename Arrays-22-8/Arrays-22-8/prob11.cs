using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_22_8
{
    internal class prob11
    {
        var users = new Dictionary<string, int>()
{
    { "John", 41 },
    { "Jane", 38 },
    { "Lucy", 29 },
    { "Paul", 24 }
};

        var sortedUsersByValue = users.OrderBy(user => user.Value);

foreach (var user in sortedUsersByValue)
{
    Console.WriteLine($"{user.Key} is {user.Value} years old");
}
}
}

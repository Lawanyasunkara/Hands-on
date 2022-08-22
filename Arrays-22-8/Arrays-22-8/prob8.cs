// C# program to illustrate how
// remove elements from the hashtable
using System;
using System.Collections;

class prob8
{

    
    static public void Main()
    {

        
        Hashtable my_hashtable = new Hashtable();
        my_hashtable.Add("A1", "Welcome");
        my_hashtable.Add("A2", "to");
        my_hashtable.Add("A3", "Training");

        // Using remove method
        // remove A2 key/value pair
        my_hashtable.Remove("A2");

        Console.WriteLine("Key and Value pairs :");

        foreach (DictionaryEntry ele1 in my_hashtable)
        {
            Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
        }

        // Before using Clear method
        Console.WriteLine("Total number of elements present" +
                " in my_hashtable:{0}", my_hashtable.Count);

        my_hashtable.Clear();

        // After using Clear method
        Console.WriteLine("Total number of elements present in" +
                    " my_hashtable:{0}", my_hashtable.Count);
    }
}

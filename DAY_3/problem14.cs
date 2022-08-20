using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo {

   class fahrenheit {

      static void Main(string[] args) {

         double fahrenheit;

         double celsius = 36;
         Console.WriteLine("Celsius: " + celsius);

         fahrenheit = (celsius * 9) / 5 + 32;
         Console.WriteLine("Fahrenheit: " + fahrenheit);

         Console.ReadLine();
      }
   }
}

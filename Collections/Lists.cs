using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    [TestClass]
    public class Lists
    {
        [TestMethod]
        public void ListDeclaration()
        {
            // List OF String - empty list - no capacity
            List<string> listOfStrings = new List<string>();

            List<int> listOfInt = new List<int> { 2, 3, 4, 123, -456, 1000, 234, 345, };

            foreach(int num in listOfInt)
            {
                Console.WriteLine(num);
            }
        }

        [TestMethod]
        public void ListCapacity()
        {
            List<string> listOfStrings = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                listOfStrings.Add(i.ToString());
                Console.WriteLine($"{i}. Count: {listOfStrings.Count} Capacity: {listOfStrings.Capacity}");
            }
        }

        [TestMethod]
        public void UsefulMethods()
        {
            List<decimal> listOfDecimals = new List<decimal>();
            List<decimal> anotherList = new List<decimal> { 3m, 2m, 123.45m, -234.34m };

            listOfDecimals.Add(3.45m);

            listOfDecimals.Remove(3.45m);

            listOfDecimals.AddRange(anotherList);

            decimal myDecimal = listOfDecimals.ElementAt(0);
            // decimal myDecimal = listOfDecimals[0];

            // will return a default value if there is no element
            decimal anotherDecimal = listOfDecimals.ElementAtOrDefault(13);

            listOfDecimals.Sort();
        }

        /*
         
            - create an empty list of strings
            - create a list of strings with 10 strings on it (initialize it)
            - use a foreach loop to add the strings from the second list to the first list
            - use a foreach loop to write all the strings now on the first list to the console.
         
         */
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    [TestClass]
    public class Dictionaries
    {
        [TestMethod]
        public void DeclaringDictionaries()
        {
            // Dictionary of string, int
            Dictionary<string, int> myDictionary = new Dictionary<string, int>(); // Lookups

            myDictionary.Add("hi", 2);
            Console.WriteLine(myDictionary["hi"]);

            myDictionary.Add("HI", 234234);

            // Object initialization syntax 
            Dictionary<int, DateTime> anotherDictionary = new Dictionary<int, DateTime> 
            {
                { 3, new DateTime() },
                { 42, DateTime.Now },
                { -46, new DateTime(2021, 6, 24)},
            };

            List<string> myList = new List<string> { "", "", "", };

            Developer dev = new Developer
            {
                Id = 1, 
                Name = "Name",
            };
        }

        [TestMethod]
        public void HandlingAddingKeys()
        {
            // ContainsKey method
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            string key = "myKey";
            string value = "myValue";

            if (!myDictionary.ContainsKey(key))
            {
                myDictionary.Add(key, value);
            }

            if (!myDictionary.ContainsKey(key))
            {
                myDictionary.Add(key, value);
            }

            myDictionary.TryGetValue("hello", out string anotherValue);
            int length = anotherValue.Length;

            if (myDictionary.TryGetValue(key, out string myValue))
            {
                Console.WriteLine(myValue.Length);
            }

            if (int.TryParse("", out int result))
            {
                // do something
            }
        }

        [TestMethod]
        public void IteratingThroughADictionary()
        {
            Dictionary<int, DateTime> anotherDictionary = new Dictionary<int, DateTime>
            {
                { 3, new DateTime() },
                { 42, DateTime.Now },
                { -46, new DateTime(2021, 6, 24)}
            };

            foreach(KeyValuePair<int, DateTime> kvp in anotherDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
            }
        }

        private (bool, string) Example(string example)
        {
            string myOut = null;

            bool isLongerThanTwo = example.Length > 2;
            if (isLongerThanTwo)
            {
                myOut = example;
            }

            return (isLongerThanTwo, myOut);
        }

        /* 
         
                      // Dictionaries:
                Create a dictionary containing the following key value pairs (use int and string as your types):
                    - Key: 1, Value: "Hi"
                    - Key: 2, Value: "Hello"
                    - Key: 3, Value: "Greetings"
                Use your [] "indexer" to print "Greetings" to the Console
                Use a foreach loop to Print all keys and values to the console in the following format 
                    Key: 1 Value: Hi
                    Key: 2 Value: Hello
                    Key: 3 Value: Greetings
         
         
         */
    }

    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

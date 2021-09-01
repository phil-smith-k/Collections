using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    [TestClass] // Attributes
    public class Arrays
    {
        [TestMethod] //Attribute
        public void DeclaringArrays()
        {
            int[] myArray = new int[8];

            myArray[0] = 1000;
            myArray[1] = -32;
            myArray[2] = -500;
            myArray[3] = 10000;
            myArray[4] = 750;
            myArray[5] = -4500;
            myArray[6] = 1_000_000;
            myArray[7] = -2450;

            Console.WriteLine(myArray[4]);
        }

        [TestMethod]
        public void DeclaringArraysWithObjectInitialization()
        {
            string[] myArray = { "My", "name", "is", "phil", "smith" };
            // Array
            myArray[3] = "john";

            foreach (var item in myArray) // the reason we can foreach is because arrays implement IEnumerable
            {
                Console.WriteLine(item);
            }

            List<string> myList = myArray.ToList();
            myList.ToArray();
        }

        [TestMethod]
        public void JaggedArray()
        {
            int[][] twoDimensional = new int[3][];

            twoDimensional[0] = new int[3];
            twoDimensional[1] = new int[10];
            twoDimensional[2] = new int[1];

            int[][][] threeDimensional = new int[5][][];

            //int[,] twoDimension = new int[4, 3];
        }

        /*
         
            Declare Three Arrays    
            - one empty int array with a capacity/length of 10
            - one string array (initialize it with four strings of your choice)
            - one char array (initialize it with 6 characters) and then use your [] indexer to 
            write the third and only the third character to the console
         
        */
    }
}

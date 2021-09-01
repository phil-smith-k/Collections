using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    [TestClass]
    public class Queues
    {
        [TestMethod]
        public void QueueDeclaration()
        {
            Queue<string> strings = new Queue<string>();


        }

        [TestMethod]
        public void EnqueueAndDequeue()
        {
            Queue<int> ints = new Queue<int>();
            for (int i = 0; i < 20; i++)
            {
                ints.Enqueue(i);
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{ints.Dequeue()} {ints.Count}");
            }
        }

        [TestMethod]
        public void Peek()
        {
            Queue<int> ints = new Queue<int>(GetIntegers());

            Console.WriteLine(ints.Count); // the count should be the same
            Console.WriteLine(ints.Peek()); // return the value but not remove it
            Console.WriteLine(ints.Count); // the count should be the same
        }

        private IEnumerable<int> GetIntegers()
        {
            //for (int i = 0; i < 50; i++)
            //{
            //    yield return i;
            //}

            return Enumerable.Range(0, 50);
        }

        [TestMethod]
        public void Solution()
        {
            Queue<int> ints = new Queue<int>();
            for (int i = 1; i <= 100; i++)
            {
                ints.Enqueue(i);
            }

            while (ints.Count > 0)
            {
                int peek = ints.Peek();

                if (peek %  5 == 0)
                {
                    Console.WriteLine($"It's a multiple of 5!");
                }

                ints.Dequeue();
            }
        }

        /*
            - create an empty queue of ints
            - Use a for loop to enqueue numbers 1 - 100 to the queue 
            - Use a while loop to iterate through the queue. Peek each number, and then dequeue. if the number is a multiple of 5 
            Console.WriteLine "It's a multiple of 5" then dequeue

         */
    }
}

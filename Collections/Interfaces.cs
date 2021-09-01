using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    [TestClass]
    public class Interfaces
    {
        [TestMethod]
        public void IEnumerableExample()
        {
            List<string> newList = new List<string>();
            Queue<string> queue = new Queue<string>();
            string[] array = new string[5];
            IEnumerable<string> myEnumerable = new List<string>();
            IEnumerable<string> anotherEnumerable = Enumerable.Empty<string>(); // makes an empty enumerable

            LoopThrough(newList);
            LoopThrough(queue);
            LoopThrough(array);
            LoopThrough(myEnumerable);

            // Interfaces force classes to have the same properties or behaviors

        }

        [TestMethod]
        public void IAnimalTest()
        {
            Fish animal1 = new Fish();
            Dog animal2 = new Dog();

            List<IAnimal> animals = new List<IAnimal>();

            animals.Add(animal1);
            animals.Add(animal2);

            foreach(IAnimal animal in animals)
            {
                // Pattern matching
                if (animal is Fish)
                {
                    Fish fish = animal as Fish;
                    fish.Swim();
                }
            }
        }

        private void LoopThrough(IEnumerable<string> enumerable)
        {
            foreach(string item in enumerable)
            {
                Console.WriteLine(item);
            }
        }

        //private void LoopThrough(List<string> enumerable)
        //{
        //    foreach (string item in enumerable)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //private void LoopThrough(Queue<string> enumerable)
        //{
        //    foreach (string item in enumerable)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //private void LoopThrough(string[] enumerable)
        //{
        //    foreach (string item in enumerable)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }

    public class Fish : IAnimal
    { 
        public bool IsMammal { get; set; }

        public string Species { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("blub blub blub");
        }

        public void Swim()
        {
            Console.WriteLine("Just keep swimming");
        }
    }

    public class Dog : IAnimal
    {
        public bool IsMammal { get; set; }

        public string Species { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Woof woof");
        }
    }



    public interface IAnimal
    {
        bool IsMammal { get; set; }

        string Species { get; set; }

        void MakeSound();
    }
}

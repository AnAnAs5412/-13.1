using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР13._1
{
    class Animals
    {
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine("Кушает");
        }
        public void Sleep()
        {
            Console.WriteLine("Спит");
        }
    }
    class Dog : Animals
    {
        public void Play()
        {
            Console.WriteLine("Играет");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = Console.ReadLine();
            dog.Play();
            dog.Eat();
            dog.Sleep();
        }
    }
}

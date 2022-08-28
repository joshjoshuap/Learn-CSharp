namespace CSharp_OOP_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            dog.makeSound();
            cat.makeSound();
            /* 
             arf arf
            meow meow
             */
        }
    }

    abstract class Animal
    {
        public abstract void makeSound();
    }

    class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("arf arf");
        }
    }

    class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("meow");
        }
    }

}
namespace CSharp_OOP_Polymorphism
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

    class Animal
    {
        virtual public void makeSound()
        {
            Console.WriteLine("Cant Determine Sound"); // cant displat because it override by other method from other class
        }
    }

    class Dog : Animal
    {
        override public void makeSound()
        {
            Console.WriteLine("arf arf");
        }
    }

    class Cat : Animal
    {
        override public void makeSound()
        {
            Console.WriteLine("meow");
        }
    }
}
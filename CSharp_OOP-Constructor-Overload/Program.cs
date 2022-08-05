using System;

namespace CSharp_OOP_Constructor_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Avengers","Heroes",10, 100);
            Movie movie2 = new Movie("Minions", "Comedy", 9); // no price

            Console.WriteLine($"Movie: {movie1.title} Genre: {movie1.description} Rate: {movie1.rating} Price: {movie1.price}");
            // Movie: Avengers Genre: Heroes Rate: 100 Price: 100

            Console.WriteLine($"Movie: {movie2.title} Genre: {movie2.description} Rate: {movie2.rating} Price: {movie2.price}");
            // Movie: Avengers Genre: Comedy Rate: 9 Price: 0
        }
    }
}

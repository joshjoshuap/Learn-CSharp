// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string firstName = "Joshua";
string lastName = "Pautanes";
int age = 22;
Console.WriteLine($"My name is {firstName} {lastName} and {age} years old");

int inputNumber1, inputNumber2, choiceNumber;
int total = 0;

Console.WriteLine("--- Hello Welcome ---");
Console.WriteLine("Enter First Number");
inputNumber1 = Convert.ToInt32(Console.ReadLine()); // convert string to int
Console.WriteLine("Enter Second Number");
inputNumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Choose Aritmetic: \n(1) Addition \n(2) Subtraction \n(3) Multiplication \n(4) Division");
choiceNumber = Convert.ToInt32(Console.ReadLine());

if (choiceNumber == 1) total = inputNumber1 + inputNumber2;
if (choiceNumber == 2) total = inputNumber1 - inputNumber2;
if (choiceNumber == 3) total = inputNumber1 * inputNumber2;
if (choiceNumber == 4) total = inputNumber1 / inputNumber2;

Console.WriteLine($"Total: {total}");

string[] fruit = { "Apple", "Banana", "Orange" };
Console.WriteLine($"Fruits: {fruit[0]}, {fruit[1]}, {fruit[2]}");

string[,] cars = {
{"Toyta", "Vios"},
{"Mitsubishi", "Mirage"},
{"Honda", "City"}
};

Console.WriteLine("Cars:");
Console.WriteLine($"1. {cars[0, 0]}, {cars[0, 1]} \n2. {cars[1, 0]}, {cars[1, 1]} \n2. {cars[2, 0]}, {cars[2, 1]}");

int[] numbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Number {numbers[i]}");
}

string[,] names = {
    {"Jose", "Rizal"},
    {"Andres", "Bonifacio"},
    {"Emilo", "Aguinaldo"},
};

for (int row = 0; row < names.GetLength(0); row++)
{
    Console.WriteLine($"Name: {names[row, 0]} {names[row, 1]}");
}


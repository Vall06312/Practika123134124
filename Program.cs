using System;
class Person
{
    public string name = "Валера"; 
    public int age = 18;

    public void Print()
    {
        Console.WriteLine($"Имя: {name} Возраст: {age}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Print();

        Console.ReadLine();
    }
}
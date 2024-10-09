using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is your age?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your eye color?");
        string eyeColor = Console.ReadLine();

        Console.WriteLine("What color is your hair?");
        string hairColor = Console.ReadLine();

        Console.WriteLine("What is your shoe size?");
        float shoeSize = float.Parse(Console.ReadLine());

        Console.WriteLine("What is your favorite color?");
        string favoriteColor = Console.ReadLine();

        Console.WriteLine("What is your favorite TV show or movie?");
        string favoriteShowOrMovie = Console.ReadLine();

        Console.WriteLine("Who is your favorite teacher?");
        string favoriteTeacher = Console.ReadLine();;

        Console.WriteLine("What is your favorite class?");
        string favoriteClass = Console.ReadLine();;

        Console.WriteLine("What is your favorite holiday?");
        string favoriteHoliday = Console.ReadLine();

        Console.WriteLine("What is your favorite season?");
        string favoriteSeason = Console.ReadLine();

        Console.WriteLine("What is your dream job?");
        string dreamJob = Console.ReadLine();

        Console.WriteLine("Your age in 5 years will be " + (age + 5) + "!");

        Console.WriteLine("How many siblings do you have?");
        int siblingsAmount = int.Parse(Console.ReadLine());

        string hasSiblings;
        if (siblingsAmount > 0) hasSiblings = null;
        else hasSiblings = "not ";

        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eye color is " + eyeColor + ". "
         + name + "'s hair color is " + hairColor + ". " + name + "'s shoe size is " + shoeSize + ". Their favorite color is " + favoriteColor + ". "
         + name + "'s favorite TV show/movie is " + favoriteShowOrMovie + ". " + name + "'s favorite class is Software and Game Development instructed by Mr. Martinez! " + name + "'s favorite holiday is " + favoriteHoliday + ". "
         + name + "'s favorite season is " + favoriteSeason + ". " + name + "'s dream job is " + dreamJob + ". " + name + " does " + hasSiblings + "have siblings.");
    }
}

using System;

public class Program
{
    static string name;
    static string age;
    static string eyeColor;
    static string hairColor;
    static float shoeSize;
    static string favoriteColor;
    static string favoriteShowOrMovie;
    static string favoriteTeacher;
    static string favoriteClass;
    static string favoriteHoliday;
    static string favoriteSeason;
    static string dreamJob;
    static string ageIn5Years;
    static int siblingsAmount;
    static string hasSiblings;
    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteShowOrMovie();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(age);
        AskNumberOfSiblings();
        DisplaySummaryMessage();
    }

    public static void AskName()
    {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
    }

    public static void AskAge()
    {
        Console.WriteLine("What is your age?");
        age = Console.ReadLine();
    }

    public static void AskEyeColor()
    {
        Console.WriteLine("What is your eye color?");
        eyeColor = Console.ReadLine();
    }

    public static void AskHairColor()
    {
        Console.WriteLine("What color is your hair?");
        hairColor = Console.ReadLine();
    }

    public static void AskShoeSize()
    {
        Console.WriteLine("What is your shoe size?");
        shoeSize = float.Parse(Console.ReadLine());
    }

    public static void AskFavoriteColor()
    {
        Console.WriteLine("What is your favorite color?");
        favoriteColor = Console.ReadLine();
    }

    public static void AskFavoriteShowOrMovie()
    {
        Console.WriteLine("What is your favorite TV show or movie?");
        favoriteShowOrMovie = Console.ReadLine();
    }

    public static void AskFavoriteTeacher()
    {
        Console.WriteLine("Who is your favorite teacher?");
        favoriteTeacher = Console.ReadLine();;
    }

    public static void AskFavoriteClass()
    {
        Console.WriteLine("What is your favorite class?");
        favoriteClass = Console.ReadLine();
    }

    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("What is your favorite holiday?");
        favoriteHoliday = Console.ReadLine();
    }

    public static void AskFavoriteSeason()
    {
        Console.WriteLine("What is your favorite season?");
        favoriteSeason = Console.ReadLine();
    }

    public static void AskDreamJob()
    {
        Console.WriteLine("What is your dream job?");
        dreamJob = Console.ReadLine();
    }

    public static void CalculateAgeIn5Years(string currentAge)
    {
        int intAge = int.Parse(currentAge);
        ageIn5Years = (intAge + 5).ToString();
        Console.WriteLine("Your age in 5 years will be " + ageIn5Years + "!");
    }

    public static void AskNumberOfSiblings()
    {
        Console.WriteLine("How many siblings do you have?");
        siblingsAmount = int.Parse(Console.ReadLine());

        if (siblingsAmount > 0) hasSiblings = null;
        else hasSiblings = "not ";
    }

    public static void DisplaySummaryMessage()
    {
        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eye color is " + eyeColor + ". "
         + name + "'s hair color is " + hairColor + ". " + name + "'s shoe size is " + shoeSize + ". Their favorite color is " + favoriteColor + ". "
         + name + "'s favorite TV show/movie is " + favoriteShowOrMovie + ". " + name + "'s favorite class is definitely Software and Game Development instructed by Mr. Martinez! " + name + "'s favorite holiday is " + favoriteHoliday + ". "
         + name + "'s favorite season is " + favoriteSeason + ". " + name + "'s dream job is " + dreamJob + ". " + name + " does " + hasSiblings + "have siblings.");
    }
}

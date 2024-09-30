#pragma warning disable CS8321 // Local function is declared but never used

using System.ComponentModel;
using System.Text.RegularExpressions;

Console.Clear();

// Your classmates asked you to copy some paperwork for them. 
// You know that there are 'n' classmates and the paperwork has 'm' pages.
// Your task is to calculate how many blank pages do you need. If n < 0 or m < 0 return 0.
static void PaperworkKata()
{

    if (Paperwork(5, -5).Equals(0)) Console.WriteLine("Success !");
    else Console.WriteLine("Fail");

    if (Paperwork(-5, -5).Equals(0)) Console.WriteLine("Success !");
    else Console.WriteLine("Fail");

    if (Paperwork(5, 5).Equals(25)) Console.WriteLine("Success !");
    else Console.WriteLine($"Fail : {Paperwork(5, 5).Equals(25)}");

    if (Paperwork(10, 5).Equals(50)) Console.WriteLine("Success !");
    else Console.WriteLine("Fail");

    static int Paperwork(int n, int m) => (n > 0 && m > 0) ? n * m : 0;
}
// PaperworkKata();


/******************************************************************************/

// Clock shows h hours, m minutes and s seconds after midnight.
// Your task is to write a function which returns the time since midnight in milliseconds.
// Clock();
static void Clock()
{
    int miliSecondsSinceMidnight = Past(0, 1, 1);
    const int result = 61000;
    if (miliSecondsSinceMidnight.Equals(result)) Console.WriteLine("Success !");
    else Console.WriteLine("Fail !");
    static int Past(int h, int m, int s)
    {
        const int secondToMs = 1000;
        const int minuteToMs = secondToMs * 60;
        const int hourToMs = minuteToMs * 60;

        return h * hourToMs + m * minuteToMs + s * secondToMs;
    }
}

/******************************************************************************/
// SpacesRemover();
static void SpacesRemover()
{
    (string, string) test_1 = ("8 j 8   mBliB8g  imjB8B8  jl  B", "8j8mBliB8gimjB8B8jlB");
    (string, string) test_2 = ("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd", "88Bifk8hB8BB8BBBB888chl8BhBfd");
    (string, string) test_3 = ("8aaaaa dddd r     ", "8aaaaaddddr");

    if (NoSpace(test_1.Item1).Equals(test_1.Item2)) Console.WriteLine("Success !");
    else Console.WriteLine($"Fail, result should be {test_1.Item2}");

    if (NoSpace(test_2.Item1).Equals(test_2.Item2)) Console.WriteLine("Success !");
    else Console.WriteLine($"Fail, result should be {test_1.Item2}");

    if (NoSpace(test_3.Item1).Equals(test_3.Item2)) Console.WriteLine("Success !");
    else Console.WriteLine($"Fail, result should be {test_1.Item2}");

    static string NoSpace(string input) => input.Replace(" ", "");
}


/******************************************************************************/

//Given an array of integers, return a new array with each value doubled. 
// LostWithoutaMap();
static void LostWithoutaMap()
{
    (int[], int[]) test_1 = (new[] { 1, 2, 3 }, new[] { 2, 4, 6 });
    (int[], int[]) test_2 = (new[] { 4, 1, 1, 1, 4 }, new[] { 8, 2, 2, 2, 8 });
    (int[], int[]) test_3 = (new[] { 2, 2, 2, 2, 2, 2 }, new[] { 4, 4, 4, 4, 4, 4 });

    if (Maps(test_1.Item1).SequenceEqual(test_1.Item2)) Console.WriteLine("test_1 success !");
    else Console.WriteLine("test_1 Fail !");

    if (Maps(test_2.Item1).SequenceEqual(test_2.Item2)) Console.WriteLine("test_2 success !");
    else Console.WriteLine("test_2 Fail !");

    if (Maps(test_3.Item1).SequenceEqual(test_3.Item2)) Console.WriteLine("test_3 success !");
    else Console.WriteLine("test_3 Fail !");


    static int[] Maps(int[] intArray)
    {
        for (int i = 0; i < intArray.Length; i++) intArray[i] *= 2;
        return intArray;
    }
}
/******************************************************************************/
// RentalCar();
static void RentalCar()
{
    (int, int) test_1 = (1, 40);
    (int, int) test_2 = (3, 100);
    (int, int) test_3 = (7, 230);

    if (RentalCarCost(test_1.Item1).Equals(test_1.Item2)) Console.WriteLine("Success !");
    else Console.WriteLine($"Fail, result should be {test_1.Item2}");

    if (RentalCarCost(test_2.Item1).Equals(test_2.Item2)) Console.WriteLine("Success !");
    else Console.WriteLine($"Fail, result should be {test_1.Item2}");

    if (RentalCarCost(test_3.Item1).Equals(test_3.Item2)) Console.WriteLine("Success !");
    else Console.WriteLine($"Fail, result should be {test_1.Item2}");

    static int RentalCarCost(int days)
    {
        const int RENT_DAY_OFFER_LOW = 3;
        const int RENT_DAY_OFFER_HIGH = 7;

        const int MIN_OFFER = 20;
        const int MAX_OFFER = 50;

        const int PRICE_PER_DAY = 40;

        int price = days * PRICE_PER_DAY;

        if (days >= RENT_DAY_OFFER_HIGH) return price -= MAX_OFFER;
        if (days >= RENT_DAY_OFFER_LOW) return price -= MIN_OFFER;

        return price;
    }
}

/**********************************************************************************************/
// Your task is to make two functions ( max and min, or maximum and minimum, etc., depending on the language )
// that receive a list of integers as input, and return the largest and lowest number in that list, respectively.
// MinMax();
static void MinMax()
{
    (int[], int) test_1 = (new[] { -52, 56, 30, 29, -54, 0, -110 }, -110);
    (int[], int) test_2 = (new[] { 42, 54, 65, 87, 0 }, 0);
    (int[], int) test_3 = (new[] { 4, 6, 2, 1, 9, 63, -134, 566 }, 566);
    (int[], int) test_4 = (new[] { 5 }, 5);


    if (Min(test_1.Item1).Equals(test_1.Item2)) Console.WriteLine("test_1 success !");
    else Console.WriteLine($"Result should be {test_1.Item2}, but you've return {Max(test_1.Item1)}");

    if (Min(test_2.Item1).Equals(test_2.Item2)) Console.WriteLine("test_2 success !");
    else Console.WriteLine($"Result should be {test_2.Item2}, but you've return {Max(test_2.Item1)}");

    if (Max(test_3.Item1).Equals(test_3.Item2)) Console.WriteLine("test_3 success !");
    else Console.WriteLine($"Result should be {test_3.Item2}, but you've return {Min(test_3.Item1)}");

    if (Max(test_4.Item1).Equals(test_4.Item2)) Console.WriteLine("test_4 success !");
    else Console.WriteLine($"Result should be {test_4.Item2}, but you've return {Min(test_4.Item1)}");


    int Min(int[] list)
    {
        int value = list[0];
        foreach (int number in list)
        {
            if (number < value) value = number;
        }
        return value;
    }

    int Max(int[] list)
    {
        int value = list[0];
        foreach (int number in list)
        {
            if (number > value) value = number;
        }
        return value;
    }
}


/**********************************************************************************************/
// Build a function that returns an array of integers from n to 1 where n>0.

static void ReverseIntArray()
{

    (int, int[]) test_1 = (5, new[] { 5, 4, 3, 2, 1 });
    (int, int[]) test_2 = (1, new[] { 1 });
    (int, int[]) test_3 = (10, new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });

    /* 
        if (ReverseSeq_First(test_1.Item1).SequenceEqual(test_1.Item2)) Console.WriteLine("test_1 success !");
        else Console.WriteLine($"Result should be {DisplayIntArray(test_1.Item2)}, but you've return {DisplayIntArray(ReverseSeq_First(test_1.Item1))}");

        if (ReverseSeq_First(test_2.Item1).SequenceEqual(test_2.Item2)) Console.WriteLine("test_1 success !");
        else Console.WriteLine($"Result should be {DisplayIntArray(test_2.Item2)}, but you've return {DisplayIntArray(ReverseSeq_First(test_2.Item1))}");

        if (ReverseSeq_First(test_3.Item1).SequenceEqual(test_3.Item2)) Console.WriteLine("test_1 success !");
        else Console.WriteLine($"Result should be {DisplayIntArray(test_3.Item2)}, but you've return {DisplayIntArray(ReverseSeq_First(test_3.Item1))}");
    */

    if (ReverseSeq_Second(test_1.Item1).SequenceEqual(test_1.Item2)) Console.WriteLine("test_1 success !");
    else Console.WriteLine($"Result should be {DisplayIntArray(test_1.Item2)}, but you've return {DisplayIntArray(ReverseSeq_Second(test_1.Item1))}");

    if (ReverseSeq_Second(test_2.Item1).SequenceEqual(test_2.Item2)) Console.WriteLine("test_1 success !");
    else Console.WriteLine($"Result should be {DisplayIntArray(test_2.Item2)}, but you've return {DisplayIntArray(ReverseSeq_Second(test_2.Item1))}");

    if (ReverseSeq_Second(test_3.Item1).SequenceEqual(test_3.Item2)) Console.WriteLine("test_1 success !");
    else Console.WriteLine($"Result should be {DisplayIntArray(test_3.Item2)}, but you've return {DisplayIntArray(ReverseSeq_Second(test_3.Item1))}");

    // Ma solution 
    static int[] ReverseSeq_First(int n)
    {
        int index = 0;
        int[] intArray = new int[n];
        while (n > 0)
            intArray[index++] = n--;

        return intArray;
    }

    // Solution "Best practice" proposé sur CodeWars
    static int[] ReverseSeq_Second(int n)
    {
        // Namespace:System.Linq 
        // MS Doc : https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.range?view=net-8.0
        // Enumerable.Range(1, n) => Generates a sequence of integral numbers within a specified range.
        return Enumerable.Range(1, n).Reverse().ToArray();
    }


}


/**********************************************************************************************/
static void SquareSumSequence()
{

    (int[], int) test_1 = (new[] { 1, 2, 2 }, 9);
    (int[], int) test_2 = (new[] { 1, 2 }, 5);
    (int[], int) test_3 = (new[] { 5, 3, 4 }, 50);
    (int[], int) test_4 = (new int[] { }, 0);

    if (SquareSum(test_1.Item1).Equals(test_1.Item2)) Console.WriteLine("test_1 success !");
    else Console.WriteLine($"Result should be {test_1.Item2}, but you've return {SquareSum(test_1.Item1)}");

    if (SquareSum(test_2.Item1).Equals(test_2.Item2)) Console.WriteLine("test_2 success !");
    else Console.WriteLine($"Result should be {test_2.Item2}, but you've return {SquareSum(test_2.Item1)}");

    if (SquareSum(test_3.Item1).Equals(test_3.Item2)) Console.WriteLine("test_3 success !");
    else Console.WriteLine($"Result should be {test_3.Item2}, but you've return {SquareSum(test_3.Item1)}");

    if (SquareSum(test_4.Item1).Equals(test_4.Item2)) Console.WriteLine("test_4 success !");
    else Console.WriteLine($"Result should be {test_4.Item2}, but you've return {SquareSum(test_4.Item1)}");

    // Ma solution 
    // static int SquareSum(int[] numbers)
    // {
    //     int powValue = 2;
    //     int sum = 0;
    //     foreach (int value in numbers)
    //         sum += (int)Math.Pow(value, powValue);

    //     return sum;
    // }

    // Solution raccourci
    static int SquareSum(int[] numbers) => numbers.Sum((value) => (int)Math.Pow(value, 2));
}

/**********************************************************************************************/
// Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. 
// Essentially, rearrange the digits to create the highest possible number.
static void sortInteger()
{

    (int, int) test_1 = (42145, 54421);
    (int, int) test_2 = (145263, 654321);
    (int, int) test_3 = (123456789, 987654321);

    if (sortInt(test_2.Item1).Equals(test_1.Item2)) Console.WriteLine("test_1 success !");
    else Console.WriteLine($"Result should be {test_1.Item2}, but you've return {sortInt(test_2.Item1)}");

    if (sortInt(test_2.Item1).Equals(test_2.Item2)) Console.WriteLine("test_2 success !");
    else Console.WriteLine($"Result should be {test_2.Item2}, but you've return {sortInt(test_2.Item1)}");

    if (sortInt(test_3.Item1).Equals(test_3.Item2)) Console.WriteLine("test_3 success !");
    else Console.WriteLine($"Result should be {test_3.Item2}, but you've return {sortInt(test_3.Item1)}");


    static int sortInt(int number)
    {
        var charList = number.ToString().ToArray();
        Array.Sort(charList);
        Array.Reverse(charList);
        var numberToString = new string(charList);
        return Convert.ToInt32(numberToString);
    }
}


/******************************************************************************/
// Make a program that filters a list of strings and returns a list with only your friends name in it.
// If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours!
// Otherwise, you can be sure he's not...

static void FriendOfFoeKata()
{


    (string[], string[]) test_1 = (new[] { "Mark", "Jimmy", "Abel", "Amanda" }, new[] { "Mark", "Abel" });
    (string[], string[]) test_2 = (new[] { "Peter", "Anna", "Michael" }, new[] { "Anna" });
    (string[], string[]) test_3 = (new[] { "Linus", "Beau", "Azul" }, new[] { "Beau", "Azul" });

    if (FriendOrFoe(test_1.Item1).SequenceEqual(test_1.Item2)) Console.WriteLine("test_1 success !");
    else Console.WriteLine($"Result should be {DisplayStrArray(test_1.Item2)}, but you've return {DisplayStrArray(FriendOrFoe(test_2.Item1).ToArray())}");

    if (FriendOrFoe(test_2.Item1).SequenceEqual(test_2.Item2)) Console.WriteLine("test_2 success !");
    else Console.WriteLine($"Result should be {DisplayStrArray(test_2.Item2)}, but you've return {DisplayStrArray(FriendOrFoe(test_2.Item1).ToArray())}");

    if (FriendOrFoe(test_3.Item1).SequenceEqual(test_3.Item2)) Console.WriteLine("test_3 success !");
    else Console.WriteLine($"Result should be {DisplayStrArray(test_3.Item2)}, but you've return {DisplayStrArray(FriendOrFoe(test_3.Item1).ToArray())}");



    static IEnumerable<string> FriendOrFoe(string[] names)
    {
        // Iterative method 
        // var friends = new List<string>();
        // foreach (string name in names)
        //     if (name.Length == 4) friends.Add(name);
        // return friends;


        // Thanks to the Linq doc ! https://learn.microsoft.com/fr-fr/dotnet/csharp/linq/standard-query-operators/filtering-data
        // With LINQ (Language-Integrated Query) Query syntaxe
        // return from persons in names where persons.Length == 4 select persons;

        // With LINQ Method syntax
        return names.Where(name => name.Length == 4);
    }
}

/**********************************************************************************************/

static void ATMPinCode()
{

    (string, bool) test_1 = ("1234", true);
    (string, bool) test_2 = ("123456", true);
    (string, bool) test_3 = ("123", false);
    (string, bool) test_4 = ("12345", false);

    if (isPinCodeValid(test_2.Item1).Equals(test_1.Item2)) Console.WriteLine("test_1 success !");
    else Console.WriteLine($"Result should be {test_1.Item2}, but you've return {isPinCodeValid(test_2.Item1)}");

    if (isPinCodeValid(test_2.Item1).Equals(test_2.Item2)) Console.WriteLine("test_2 success !");
    else Console.WriteLine($"Result should be {test_2.Item2}, but you've return {isPinCodeValid(test_2.Item1)}");

    if (isPinCodeValid(test_3.Item1).Equals(test_3.Item2)) Console.WriteLine("test_3 success !");
    else Console.WriteLine($"Result should be {test_3.Item2}, but you've return {isPinCodeValid(test_3.Item1)}");

    if (isPinCodeValid(test_4.Item1).Equals(test_4.Item2)) Console.WriteLine("test_4 success !");
    else Console.WriteLine($"Result should be {test_4.Item2}, but you've return {isPinCodeValid(test_4.Item1)}");


    static bool isPinCodeValid(string pin)
    {
        /*
        God thanks : https://download.microsoft.com/download/D/2/4/D240EBF6-A9BA-4E4F-A63F-AEB6DA0B921C/Regular%20expressions%20quick%20reference.pdf
        Patterns : 
        - \s : White char
        - () : capture group
        - [0-9] : number from 0 to 9
        - {0,3} : 0 to 3 occurence
        */
        string fourDigitPattern = @"\d{4}";
        string sixDigitPattern = @"\d{6}";
        if (pin.Length == 4) return Regex.IsMatch(pin, fourDigitPattern);
        if (pin.Length == 6) return Regex.IsMatch(pin, sixDigitPattern);

        return false;
    }
}


// Launch Katas : 
// PaperworkKata();
// Clock();
// SpacesRemover();
// LostWithoutaMap();
// RentalCar();
// MinMax();
// ReverseIntArray();
// SquareSumSequence();
// sortInteger();
// FriendOfFoeKata();
ATMPinCode();

static string DisplayIntArray(int[] array)
{
    string[] resultArray = new string[array.Length];
    int index = 0;
    Array.ForEach(array, (value) =>
    {
        resultArray[index++] = value.ToString();
    });
    return $"[{string.Join(", ", resultArray)}]";
}

static string DisplayStrArray(string[] array) => $"[{string.Join(", ", array)}]";

static string DisplayCharArray(char[] array) => $"[{string.Join(", ", array)}]";
